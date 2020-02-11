using System;
using System.Linq;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void toolStripButtonPessoas_Click(object sender, EventArgs e) {
            var frm = new frmPessoas { MdiParent = this };
            frm.Show();
        }

        private void toolStripButtonRecibos_Click(object sender, EventArgs e) {
            var frm = new frmRecibos { MdiParent = this };
            frm.Show();
        }

        private void toolStripButtonMovimentos_Click(object sender, EventArgs e) {
            var frm = new frmMovimentos { MdiParent = this };
            frm.Show();
        }

        private void toolStripButtonExtrato_Click(object sender, EventArgs e) {
            var frm = new frmBalanco { MdiParent = this };
            frm.Show();
        }

        private void toolStripButtonCalculadora_Click(object sender, EventArgs e) {
            var frm = new frmCalculadora { MdiParent = this };
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            Controls.OfType<MdiClient>().First().BackColor = this.BackColor;
        }

        private void toolStripButtonConfig_Click(object sender, EventArgs e) {
            var frm = new frmConfig { MdiParent = this };
            frm.Show();
        }
    }
}