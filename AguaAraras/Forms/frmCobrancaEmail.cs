using DataLayer;
using Microsoft.Reporting.WinForms;
using Rhetos.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RadioButton = System.Windows.Forms.RadioButton;

namespace AguaAraras {
    public partial class frmCobrancaEmail : Form {
        private readonly string _desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private readonly string _rptPath =
            AppDomain.CurrentDomain.BaseDirectory + @"Reports\rptCobrancaAttachment.rdlc";
        private readonly string _bodyTextPath = AppDomain.CurrentDomain.BaseDirectory + @"\Body.txt";
        private readonly int _ReciboID;

        private Cota[] _cobrancas;
        private string _textoOriginal;

        public frmCobrancaEmail(Form parent, int ReciboID) {
            MdiParent = parent;
            _ReciboID = ReciboID;
            InitializeComponent();
        }

        private void GetData() {
            using (var ctx = new AguaArarasEntities()) {
                var x = checkBoxIncluirCobrancasAnteriores.Checked ?
                    ctx.Cotas.Where(c => c.Data == null && c.Pessoa.Cobranca == 2) :
                    ctx.Cotas.Where(c => c.ReciboID == _ReciboID && c.Pessoa.Cobranca == 2);

                _cobrancas = x.OrderBy(c => c.Pessoa.Nome)
                    .ThenByDescending(c => c.Recibo.Vencimento.Year)
                    .ThenByDescending(c => c.Recibo.Numero).ToArray();

                listBoxNomes.Items.Clear();
                listBoxNomes.Items.AddRange(_cobrancas);
            }
        }

        private void frmCobrancaEmail_Load(object sender, EventArgs e) {
            GetData();
            labelFolder.Text = _desktopFolder;
            textBoxAssunto.Text = $@"Água Araras {_cobrancas[0].ReciboNumeroAno}";

            if (File.Exists(_bodyTextPath)) {
                _textoOriginal = File.ReadAllText(_bodyTextPath);
                textBoxBody.Text = _textoOriginal;
            }

            if (File.Exists(_rptPath)) {
                return;
            }

            MessageBox.Show($@"Arquivo {_rptPath} não encontrado.");
            buttonGerar.Enabled = false;
        }

        private void buttonGerar_Click(object sender, EventArgs e) {
            var itemsToSend = radioButtonTodos.Checked
                ? _cobrancas
                : listBoxNomes.SelectedItems.Cast<Cota>().ToArray();

            var ItemsByEMail = from p in itemsToSend
                               group p by p.EMail
                into g
                               select new EMailDeCobranca { EMail = g.Key, Cobrancas = g.ToList() };

            foreach (var email in ItemsByEMail) {
                email.CreatePDF(labelFolder.Text, _rptPath);
                if (radioButtonSalvar.Checked) {
                    continue;
                }
                if (email.Send(textBoxAssunto.Text, textBoxBody.Text)) continue;
                if (MessageBox.Show($"Erro ao enviar e-mail para:\n{email.EMail}\n\nContinuar envio?",
                        this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    break;
            }
            MessageBox.Show(@"Cobranças geradas.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (!radioButtonEnviarDeletar.Checked) {
                return;
            }

            foreach (var email in ItemsByEMail) {
                var notDeleted = true;
                for (var i = 0; i < 10 && notDeleted; i++) {
                    try {
                        File.Delete(email.PdfName);
                        notDeleted = false;
                    }
                    catch (Exception) {
                        Thread.Sleep(2000);
                    }
                    if (!notDeleted) {
                        MessageBox.Show($@"Arquivo {email.PdfName} não pode ser deletado.", @"Cobranças",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e) {
            var checkedButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            listBoxNomes.Enabled = checkedButton.Text == @"Selecionar";
        }

        private void buttonFolder_Click(object sender, EventArgs e) {
            folderBrowserDialog1.Description = @"Salvar arquivos em:";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                labelFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void frmCobrancaEmail_FormClosing(object sender, FormClosingEventArgs e) {
            if (textBoxBody.Text.Equals(_textoOriginal)) {
                return;
            }

            switch (MessageBox.Show(@"Texto base foi alterado. Salvar?", this.Text, MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question)) {
                case DialogResult.Yes:
                    File.WriteAllText(_bodyTextPath, textBoxBody.Text);
                    break;
                case DialogResult.No: break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void textBoxAssunto_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            textBoxAssunto.Text = textBoxAssunto.Text.Trim();
        }

        private void checkBoxIncluirCobrancasAnteriores_CheckedChanged(object sender, EventArgs e) {
            GetData();
        }
    }

    public class EMailDeCobranca {
        private static readonly SmtpClient _smtp = new SmtpClient("smtp.gmail.com") {
            Port = 587,
            UseDefaultCredentials = true,
            Credentials = new System.Net.NetworkCredential("ararasrede78@gmail.com", "qmlyswxmpfvlvwta"),
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            Timeout = 20000
        };
        public string EMail { get; set; }
        public string PdfName { get; set; }
        public List<Cota> Cobrancas { get; set; }
        public int Count => Cobrancas.Count;
        // public string[] EMailArray => EMail.Replace("\r\n", "#").Split('#');
        public string EMailCSV => EMail.Replace("\r\n", ",");

        public string[] Recibos => Cobrancas.Select(i => i.ReciboNumeroAno).Distinct().ToArray();

        public string Descricao => Recibos.Length == 1
            ? "ao trimestre " + Recibos[0]
            : "aos trimestres " + Recibos.Take(Recibos.Length - 1)
                  .Aggregate((current, next) => $@"{current}, {next}") +
              " e " + Recibos.Last();

        public string[] Valores => Cobrancas.Select(i => i.Valor.ToString("C")).Distinct().ToArray();

        public string ValoresExtenso => Valores.Length == 1
        ? Valores[0]
        : Valores.Take(Valores.Length - 1)
        .Aggregate((current, next) => $@"{current}, {next}") +
        " e " + Valores.Last();

        private void SetPDFName(string tmpPath) {
            var nomes = Cobrancas.Select(i => i.Nome).Distinct().ToArray();
            var filename =
                new StringBuilder(tmpPath + @"\Cobrança" + (nomes.Count() == 1 ? @"" : @"s") + " - ");

            if (nomes.Length == 1) {
                filename.AppendFormat($@"{nomes[0]} - ");
                if (Cobrancas.Count == 1) {
                    filename.AppendFormat($"{Cobrancas[0].ReciboNumeroAno}.pdf");
                }
                else {
                    var numeros = Cobrancas.Select(i => i.ReciboNumeroAno).ToArray();
                    filename.Append(
                            numeros.Take(numeros.Length - 1)
                                .Aggregate((current, next) => $@"{current}, {next}"))
                        .Append(" e ").Append(numeros.Last()).Append(".pdf");
                }
            }
            else {
                var numeros = Cobrancas.Select(i => i.ReciboNumeroAno).Distinct().ToArray();
                if (numeros.Length == 1) {
                    filename.Append(nomes.Take(nomes.Length - 1)
                                        .Aggregate((current, next) => $@"{current}, {next}") +
                                    " e " + nomes.Last()).Append(" ")
                        .Append(Cobrancas[0].ReciboNumeroAno).Append(".pdf");
                }
                else {
                    numeros = Cobrancas.Select(i => $"{i.Nome} {i.ReciboNumeroAno}").ToArray();
                    filename.Append(
                            numeros.Take(numeros.Length - 1)
                                .Aggregate((current, next) => $@"{current}, {next}"))
                        .Append(" e ").Append(numeros.Last()).Append(".pdf");
                }
            }
            PdfName = filename.ToString();
        }

        public void CreatePDF(string tmpPath, string rptPath) {
            SetPDFName(tmpPath);

            var rptViewer = new ReportViewer();
            var reportEngine = rptViewer.LocalReport;
            reportEngine.ReportPath = rptPath;

            reportEngine.DataSources.Clear();
            reportEngine.DataSources.Add(new ReportDataSource("DataSetReciboItens", Cobrancas));
            var byteViewer = rptViewer.LocalReport.Render("PDF", null, out string v_mimetype, out string v_encoding,
                out string v_filename_extension, out string[] v_streamids, out Warning[] warnings);

            var newFile = new FileStream(PdfName, FileMode.Create);
            newFile.Write(byteViewer, 0, byteViewer.Length);
            newFile.Close();
        }

        public bool Send(string subject, string bodyText) {
            try {
                // https://www.codeproject.com/Articles/298519/Fast-Token-Replacement-in-Csharp
                var fastRep = new FastReplacer("[", "]");
                fastRep.Append(bodyText);
                fastRep.Replace("[Saudacao]",
                    DateTime.Now.Hour < 12 ? "Bom dia" : (DateTime.Now.Hour < 18 ? "Boa tarde" : "Boa noite"));
                fastRep.Replace("[Descricao]", Descricao);
                fastRep.Replace("[s]", Count == 1 ? "" : "s");
                fastRep.Replace("[Nome]", Cobrancas.First().Nome);
                fastRep.Replace("[Valor]", ValoresExtenso);

                var mail = new MailMessage {
                    From = new MailAddress("ararasrede78@gmail.com", "Rede de 78"),
                    Subject = subject,
                    Body = fastRep.ToString(),
                    IsBodyHtml = false
                };
                //mail.To.Add("nfrick@gmail.com");
                mail.To.Add(EMailCSV);
                mail.Attachments.Add(new Attachment(PdfName));
                _smtp.Send(mail);
                return true;
            }
            catch (Exception) {
                return false;
            }
        }
    }
}