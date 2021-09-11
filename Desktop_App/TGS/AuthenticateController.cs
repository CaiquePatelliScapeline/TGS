using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TGS {
    class AuthenticateController {
        MainController mainController = new MainController();

        public void Login(String user, String password, Form form) {
            mainController.AlterPage(form, "home");
        }

        public void Logout(Form form) {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                mainController.AlterPage(form, "login");
            }
        }
    }
}
