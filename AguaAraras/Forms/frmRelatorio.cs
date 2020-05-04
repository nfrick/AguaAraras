using Microsoft.Reporting.WinForms;
using SuperReport;
using System;
using System.Collections.Generic;

namespace AguaAraras {
    public partial class frmRelatorio : SuperReportViewer {

        public frmRelatorio() {
            InitializeComponent();
            RptPath = AppDomain.CurrentDomain.BaseDirectory + @"Reports\{0}.rdlc";
        }

        private void frmImpressos_Load(object sender, EventArgs e) {
            rptViewer.RefreshReport();
        }
    }
}
