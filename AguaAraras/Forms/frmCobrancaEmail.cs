using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Rhetos.Utilities;
using GCAWeb.Utils;

namespace AguaAraras {
    public partial class frmCobrancaEmail : Form {
        public List<ReciboItem> Items { get; set; }
        private string _textoOriginal;
        private readonly string _desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private readonly string _exeFolder = Application.StartupPath;
        public frmCobrancaEmail() {
            InitializeComponent();
        }

        private void frmCobrancaEmail_Load(object sender, EventArgs e) {
            listBoxNomes.Items.AddRange(Items.ToArray());
            labelFolder.Text = _desktopFolder;
            textBoxAssunto.Text = $@"Água Araras {Items[0].ReciboNumeroAno}";
            _textoOriginal = File.ReadAllText(_exeFolder + @"\Body.txt");
            textBoxBody.Text = _textoOriginal;
        }

        private void buttonGerar_Click(object sender, EventArgs e) {
            var progressDialog = new frmProgressBar();
            var itemsToSend = radioButtonTodos.Checked ?
                Items :
                listBoxNomes.SelectedItems.Cast<ReciboItem>().ToList();

            var backgroundThread = new Thread(
                () => {
                    var files = new List<string>();
                    char[] sep = { '#' };
                    var eMails =
                     (from p in itemsToSend
                      group p by p.EMail into g
                      select new {
                          KeyEMail = g.Key.Replace("\r\n", "#").Split(sep)[0],
                          AllEMails = g.Key
                      }).ToArray();
                    progressDialog.Maximum = eMails.Count();

                    foreach (var email in eMails) {
                        progressDialog.UpdateProgress(email.KeyEMail);
                        files.Add(CreatePDF(itemsToSend.Where(i => i.EMail == email.AllEMails).ToList()));
                    }
                    progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    if (!radioButtonEnviarDeletar.Checked) return;
                    foreach (var file in files) {
                        var notDeleted = true;
                        for (var i = 0; i < 10 && notDeleted; i++) {
                            try {
                                File.Delete(file);
                                notDeleted = false;
                            }
                            catch (Exception) {
                                Thread.Sleep(2000);
                            }
                            if (!notDeleted)
                                MessageBox.Show($@"Arquivo {file} não pode ser deletado.", @"Cobranças",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            );
            backgroundThread.Start();
            progressDialog.ShowDialog();
        }

        private string CreatePDF(List<ReciboItem> itens) {
            //string rptPath = ConfigurationManager.AppSettings["reportpath"].ToString() + @"{0}.rdlc";
            var x = AppDomain.CurrentDomain.BaseDirectory;
            var rptPath = string.Join(@"\", x.Split('\\'), 0, x.Count(c => c == '\\') - 2) + @"\{0}.rdlc";
            string v_mimetype;
            string v_encoding;
            string v_filename_extension;
            string[] v_streamids;
            Microsoft.Reporting.WinForms.Warning[] warnings;

            var nomes = itens.Select(i => i.Nome).Distinct().ToArray();
            var filename = new StringBuilder(labelFolder.Text + @"\Cobrança" + (nomes.Count() == 1 ? @"" : @"s") + " - ");

            if (nomes.Length == 1) {
                filename.AppendFormat($@"{nomes[0]} - ");
                if (itens.Count == 1)
                    filename.AppendFormat($"{itens[0].ReciboNumeroAno}.pdf");
                else {
                    var recibos = itens.Select(i => i.ReciboNumeroAno).ToArray();
                    filename.Append(
                            recibos.Take(recibos.Length - 1)
                                .Aggregate((current, next) => $@"{current}, {next}"))
                                .Append(" e ").Append(recibos.Last()).Append(".pdf");
                }
            }
            else {
                var recibos = itens.Select(i => i.ReciboNumeroAno).Distinct().ToArray();
                if (recibos.Length == 1) {
                    filename.Append(nomes.Take(nomes.Length - 1)
                                        .Aggregate((current, next) => $@"{current}, {next}") +
                                        " e " + nomes.Last()).Append(" ")
                        .Append(itens[0].ReciboNumeroAno).Append(".pdf");
                }
                else {
                    recibos = itens.Select(i => $"{i.Nome} {i.ReciboNumeroAno}").ToArray();
                    filename.Append(
                            recibos.Take(recibos.Length - 1)
                                .Aggregate((current, next) => $@"{current}, {next}"))
                        .Append(" e ").Append(recibos.Last()).Append(".pdf");

                }
            }

            var reportViewer1 = new ReportViewer();
            var reportEngine = reportViewer1.LocalReport;
            reportEngine.ReportPath = string.Format(rptPath, "rptCobranca");

            reportEngine.DataSources.Clear();
            reportEngine.DataSources.Add(new ReportDataSource("DataSetReciboItens", itens));
            byte[] byteViewer = reportViewer1.LocalReport.Render("PDF", null, out v_mimetype, out v_encoding, out v_filename_extension, out v_streamids, out warnings);

            var newFile = new FileStream(filename.ToString(), FileMode.Create);
            newFile.Write(byteViewer, 0, byteViewer.Length);
            newFile.Close();
            if (radioButtonEnviar.Checked || radioButtonEnviarDeletar.Checked)
                SendMail(itens, filename.ToString());
            return filename.ToString();
        }

        private void SendMail(IReadOnlyList<ReciboItem> itens, string filename) {
            try {
                char[] sep = { '#' };
                var eMails = itens[0].EMail.Replace("\r\n", "#").Split(sep);
                var recibos = itens.Select(i => i.ReciboNumeroAno).Distinct().ToArray();
                var descricao = recibos.Length == 1 ? "ao trimestre " + recibos[0] :
                                "aos trimestres " + recibos.Take(recibos.Length - 1)
                                .Aggregate((current, next) => $@"{current}, {next}") +
                                " e " + recibos.Last();
                // https://www.codeproject.com/Articles/298519/Fast-Token-Replacement-in-Csharp
                var fastRep = new FastReplacer("[", "]");
                fastRep.Append(textBoxBody.Text);
                fastRep.Replace("[Saudacao]", DateTime.Now.Hour < 12 ? "Bom dia" :
                            (DateTime.Now.Hour < 18 ? "Boa tarde" : "Boa noite"));
                fastRep.Replace("[Descricao]", descricao);
                fastRep.Replace("[s]", itens.Count == 1 ? "" : "s");
                fastRep.Replace("[Nome]", itens[0].Nome);
                var mail = new MailMessage {
                    From = new MailAddress("ararasrede78@gmail.com", "Rede de 78"),
                    Subject = textBoxAssunto.Text.Trim(),
                    Body = fastRep.ToString(),
                    IsBodyHtml = false
                };
                //mail.To.Add("nfrick@gmail.com");
                foreach (var email in eMails)
                    mail.To.Add(email);

                mail.Attachments.Add(new Attachment(filename));

                var smtp = new SmtpClient("smtp.gmail.com") {
                    Port = 587,
                    UseDefaultCredentials = true,
                    Credentials = new System.Net.NetworkCredential("ararasrede78@gmail.com", "qmlyswxmpfvlvwta"),
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Timeout = 20000
                };
                smtp.Send(mail);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e) {
            var checkedButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            listBoxNomes.Enabled = checkedButton.Text == @"Selecionar";
        }

        private void buttonFolder_Click(object sender, EventArgs e) {
            folderBrowserDialog1.Description = @"Salvar arquivos em:";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                labelFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void frmCobrancaEmail_FormClosing(object sender, FormClosingEventArgs e) {
            if (textBoxBody.Text.Equals(_textoOriginal)) return;
            switch (MessageBox.Show(@"Texto base foi alterado. Salvar?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                case DialogResult.Yes: File.WriteAllText(_exeFolder + @"\Body.txt", textBoxBody.Text); break;
                case DialogResult.No: break;
                case DialogResult.Cancel: e.Cancel = true; break;
            }
        }
    }
}
