using DbContextExtensions;
using System.Data.Entity;
using System.Windows.Forms;

namespace AguaAraras {
    public class SaveTools {
        private readonly DbContext _ctx;
        private readonly string _title;

        public SaveTools(DbContext ctx, string title) {
            _ctx = ctx;
            _title = title;
        }

        public bool SalvarAlteracoes() {
            if (_ctx.SaveChanges(out var message)) {
                return true;
            }

            MessageBox.Show(message, _title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        public void FormClosing(object sender, FormClosingEventArgs e) {
            if (!_ctx.ChangeTracker.HasChanges()) {
                return;
            }
            switch (MessageBox.Show(_ctx.TextoSalvar(), _title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                case DialogResult.Yes:
                    e.Cancel = !SalvarAlteracoes();
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
