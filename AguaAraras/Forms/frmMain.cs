using System;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }

        private void toolStripButtonPessoas_Click(object sender, EventArgs e) {
            var frm = new frmPessoas {MdiParent = this};
            frm.Show();
        }

        private void toolStripButtonRecibos_Click(object sender, EventArgs e) {
            var frm = new frmRecibos {MdiParent = this};
            frm.Show();
        }

        private void toolStripButtonMovimentos_Click(object sender, EventArgs e) {
            var frm = new FrmMovimentos {MdiParent = this};
            frm.Show();
        }

        private void toolStripButtonExtrato_Click(object sender, EventArgs e) {
            var frm = new FrmBalanco {MdiParent = this};
            frm.Show();
        }

        private void toolStripButtonCalculadora_Click(object sender, EventArgs e) {
            var frm = new frmCalculadora {MdiParent = this};
            frm.Show();
        }
    }
}