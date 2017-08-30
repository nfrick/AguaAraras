using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
//using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class frmRelatorio : Form {

        private string _rptPath;

        public frmRelatorio() {
            InitializeComponent();
            var p = Application.StartupPath;
            _rptPath = string.Join(@"\", p.Split('\\'), 0, p.Count(c => c == '\\') - 1) + @"\Reports\{0}.rdlc";
            //_rptPath = ConfigurationManager.AppSettings["reportpath"].ToString() + @"{0}.rdlc";

        }

        private void frmImpressos_Load(object sender, EventArgs e) {
            reportViewer1.RefreshReport();
        }

        public void SetReport<T>(List<T> items, string reportName, string reportDataSet) {
            var reportEngine = reportViewer1.LocalReport;
            reportEngine.ReportPath = string.Format(_rptPath, reportName);
            reportEngine.DataSources.Clear();
            reportEngine.DataSources.Add(new ReportDataSource(reportDataSet, items));
            this.Show();
        }
    }
}
