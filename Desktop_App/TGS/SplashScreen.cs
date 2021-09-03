using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TGS {
    public partial class SplashScreen : Form {
        public SplashScreen() {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m) {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1) {
                return;
            }
            base.WndProc(ref m);
        }
        private void timer1_Tick(object sender, EventArgs e) {
            if(this.Opacity < 1) {
                this.Opacity += 0.1;
            } else {
                timer1.Enabled = false;
                this.Hide();
                Login login = new Login();
                login.ShowDialog();

                
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e) {
            this.Opacity = 0;
        }
    }
}
