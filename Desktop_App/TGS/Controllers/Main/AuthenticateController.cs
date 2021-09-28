using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TGS {
    class AuthenticateController {
        AlterPageController alterPageController = new AlterPageController();

        public void Login(String user, String password, Form form) {
            alterPageController.AlterPage(form, "home");
        }

        public void Logout(Form form) {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                alterPageController.AlterPage(form, "login");
            }
        }
    }
}
