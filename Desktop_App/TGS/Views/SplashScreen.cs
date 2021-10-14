using System;
using System.Windows.Forms;
using TGS.Controllers.Main;

namespace TGS.Views {
    public partial class SplashScreen : Form {
        public SplashScreen() {
            InitializeComponent();
        }

        AlterPageController alterPageController = new AlterPageController();

        protected override void WndProc(ref Message m) {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1) {
                return;
            }
            base.WndProc(ref m);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            timer1.Enabled = false;
            alterPageController.AlterPage(ActiveForm, "login");
        }
    }
}
