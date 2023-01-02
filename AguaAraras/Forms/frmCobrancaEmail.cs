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
        //private readonly string _bodyTextPath = AppDomain.CurrentDomain.BaseDirectory + @"\Body.txt";
        private readonly string _EMail_Main_Path = AppDomain.CurrentDomain.BaseDirectory + @"\EMail_Main.html";
        private readonly Recibo _ReciboAtual;

        private Cota[] _cobrancas;
        private string _textoOriginal;

        private readonly List<ExtratoItem> _extrato = new List<ExtratoItem>();

        public frmCobrancaEmail(Form parent, Recibo recibo) {
            MdiParent = parent;
            _ReciboAtual = recibo;
            InitializeComponent();

            var numAnterior = _ReciboAtual.Numero == 1 ? 3 : _ReciboAtual.Numero - 2;  // 0-based quarter
            var anoAnterior = _ReciboAtual.Ano - (numAnterior == 3 ? 1 : 0);

            var inicio = new DateTime(anoAnterior, numAnterior * 3 + 1, 1);
            var termino = inicio.AddMonths(3).AddDays(-1);

            using (var ctx = new AguaArarasEntities()) {
                _extrato = ctx.sp_Extrato(inicio, termino).ToList();
            }
        }

        private void GetData() {
            using (var ctx = new AguaArarasEntities()) {
                _cobrancas = (checkBoxIncluirCobrancasAnteriores.Checked ?
                    ctx.Cotas.Where(c => c.Data == null && c.Pessoa.Cobranca == 2) :
                    _ReciboAtual.Cotas.Where(c => c.Pessoa.Cobranca == 2))
                    .OrderBy(c => c.Pessoa.Nome)
                    .ThenByDescending(c => c.Recibo.Vencimento.Year)
                    .ThenByDescending(c => c.Recibo.Numero).ToArray();
            }

            listBoxNomes.Items.Clear();
            listBoxNomes.Items.AddRange(_cobrancas);
        }

        private void frmCobrancaEmail_Load(object sender, EventArgs e) {
            GetData();
            labelFolder.Text = _desktopFolder;
            var cobrancas = _cobrancas.Select(c=>c.ReciboNumeroAno).Distinct().ToConcatenatedString();

            if (File.Exists(_EMail_Main_Path)) {
                _textoOriginal = File.ReadAllText(_EMail_Main_Path);
                textBoxBody.Text = _textoOriginal;
            }

            if (File.Exists(_rptPath)) {
                return;
            }

            MessageBox.Show($@"Arquivo {_rptPath} não encontrado.");
            buttonGerar.Enabled = false;
        }

        private void buttonGerar_Click(object sender, EventArgs e) {
            EMailDeCobranca.BodyText = textBoxBody.Text;
            var itemsToSend = radioButtonTodos.Checked
                ? _cobrancas
                : listBoxNomes.SelectedItems.Cast<Cota>().ToArray();

            var ItemsByEMail = from p in itemsToSend
                               group p by p.EMail
                into g
                               select new EMailDeCobranca { EMail = g.Key, Extrato = _extrato, Cobrancas = g.ToList() };

            foreach (var email in ItemsByEMail) {
                email.CreatePDF(labelFolder.Text, _rptPath);
                if (radioButtonSalvar.Checked) {
                    continue;
                }
                if (email.Send()) {
                    continue;
                }

                if (MessageBox.Show($"Erro ao enviar e-mail para:\n{email.EMail}\n\nContinuar envio?",
                        this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                    break;
                }
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
                    File.WriteAllText(_EMail_Main_Path, textBoxBody.Text);
                    break;
                case DialogResult.No: break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void checkBoxIncluirCobrancasAnteriores_CheckedChanged(object sender, EventArgs e) {
            GetData();
        }
    }

    public class EMailDeCobranca {
        public static string BodyText;
        private static Properties.Settings settings = Properties.Settings.Default;
        //private static readonly SmtpClient _smtp = new SmtpClient("smtp.gmail.com") {
        private static readonly SmtpClient _smtp = new SmtpClient(settings.smtp) {
            Port = settings.port,   // 587,
            UseDefaultCredentials = true,
            //Credentials = new System.Net.NetworkCredential("ararasrede78@gmail.com", "hdgizwtwaakcdhwu"),
            Credentials = new System.Net.NetworkCredential(settings.email, settings.password),
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            Timeout = settings.timeout  //20000
        };
        public List<ExtratoItem> Extrato { get; set; }
        public string EMail { get; set; }
        public string PdfName { get; set; }
        public List<Cota> Cobrancas { get; set; }
        public int Count => Cobrancas.Count;
        // public string[] EMailArray => EMail.Replace("\r\n", "#").Split('#');
        public string EMailCSV => EMail.Replace("\r\n", ",");

        public string[] Recibos => Cobrancas.Select(i => i.ReciboNumeroAno).Distinct().ToArray();

        private string _trimestre => Recibos.Length == 1 ? "trimestre" : "trimestres";

        private string _trimestreERecibos => $"{_trimestre} {Recibos.ToConcatenatedString()}";

        public string Subject => $@"Água Araras {_trimestreERecibos}";

        public string Descricao => "ao" + (Recibos.Length == 1 ? "" : "s") + $" {_trimestreERecibos}";

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
            File.Delete(PdfName);
        }

        public void CreatePDF(string tmpPath, string rptPath) {
            SetPDFName(tmpPath);

            var rptViewer = new ReportViewer();
            var reportEngine = rptViewer.LocalReport;
            reportEngine.ReportPath = rptPath;
            reportEngine.SubreportProcessing += ProcessSubreport;

            reportEngine.DataSources.Clear();
            reportEngine.DataSources.Add(new ReportDataSource("DataSetReciboItens", Cobrancas));
            var byteViewer = rptViewer.LocalReport.Render("PDF", null, out string v_mimetype, out string v_encoding,
                out string v_filename_extension, out string[] v_streamids, out Warning[] warnings);

            using (var newFile = new FileStream(PdfName, FileMode.Create)) {
                newFile.Write(byteViewer, 0, byteViewer.Length);
                newFile.Close();
            }
        }

        private void ProcessSubreport(object sender, SubreportProcessingEventArgs e) {
            e.DataSources.Add(new ReportDataSource("DataSetExtrato", Extrato));
        }

        public bool Send() {
            try {
                // https://www.codeproject.com/Articles/298519/Fast-Token-Replacement-in-Csharp
                var fastRep = new FastReplacer("[", "]");
                fastRep.Append(BodyText);
                fastRep.Replace("[Trimestre]", Cobrancas.First().ReciboNumero.ToString());
                fastRep.Replace("[Ano]", Cobrancas.First().ReciboAno);
                fastRep.Replace("[Saudacao]",
                    DateTime.Now.Hour < 12 ? "Bom dia" : (DateTime.Now.Hour < 18 ? "Boa tarde" : "Boa noite"));
                fastRep.Replace("[Nome]", Cobrancas.First().Nome);
                fastRep.Replace("[Descricao]", Descricao);
                fastRep.Replace("[s]", Count == 1 ? "" : "s");
                fastRep.Replace("[Valor]", ValoresExtenso);

                var txt = new StringBuilder();
                var body = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\EMail_Body.html");
                foreach (var cobranca in Cobrancas) {
                    var frBody = new FastReplacer("[", "]");
                    frBody.Append(body);
                    frBody.Replace("[Endereco]", cobranca.EnderecoAraras);
                    frBody.Replace("[MesesExtenso]", cobranca.ReciboDescricao);
                    frBody.Replace("[Vencimento]", cobranca.ReciboVencimento.ToString("dd/MM/yyyy"));
                    frBody.Replace("[Tomadas]", cobranca.Tomadas.ToString());
                    frBody.Replace("[Meses]", cobranca.ReciboMeses.ToString());
                    frBody.Replace("[Cota]", cobranca.ReciboCotaValor.ToString("C2"));
                    frBody.Replace("[Total]", cobranca.Valor.ToString("C2"));
                    frBody.Replace("[DepositoIdentificado]", cobranca.DepositoIdentificado);
                    txt.Append(frBody);
                }

                fastRep.Replace("[Corpo]", txt.ToString());

                var mail = new MailMessage {
                    From = new MailAddress("ararasrede78@gmail.com", "Rede de 78"),
                    Subject = Subject,
                    Body = fastRep.ToString(),
                    IsBodyHtml = true
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