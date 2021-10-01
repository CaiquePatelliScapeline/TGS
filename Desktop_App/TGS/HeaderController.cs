using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGS {
    class HeaderController {

        // Classes
        MyMsgBox MyMsgBox = new MyMsgBox();

        public void Exit() {
            if (MyMsgBox.Show("", "Deseja realmente sair?", true) == DialogResult.Yes) {
                Application.Exit();
            }
        }

        public void Maximize(Form form) {
            if (form.WindowState == FormWindowState.Normal) {
                form.WindowState = FormWindowState.Maximized;
            } else {
                form.WindowState = FormWindowState.Normal;
            }
        }

        public void Minimize(Form form) {
            form.WindowState = FormWindowState.Minimized;
        }
    }
}
