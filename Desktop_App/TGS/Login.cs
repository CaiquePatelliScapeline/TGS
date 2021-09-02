using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGS {
    public partial class Login : Form {

        public Login() {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                Application.ExitThread();
            } else {
                e.Cancel = true;
            }
        }
    }
}
