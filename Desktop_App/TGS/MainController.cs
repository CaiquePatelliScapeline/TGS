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
    class MainController {

        // Classes
        MyMsgBox MyMsgBox = new MyMsgBox();

        //Fields
        private String chatLink = "whatsapp://";

        public void Exit() {
            if (MyMsgBox.Show("Deseja realmente sair?") == DialogResult.Yes) {
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


        public void AlterPage(Form formAtual, String formDestino) {
            formAtual.Hide();

            switch (formDestino) {
                case "home":
                    Home home = new Home();
                    home.ShowDialog();
                    break;
                case "calendar":
                    ListPage calendar = new ListPage("Calendário");
                    calendar.ShowDialog();
                    break;
                case "chat":
                    OpenLink(chatLink);
                    break;
                case "pacientes":
                    ListPage patients = new ListPage("Pacientes");
                    patients.ShowDialog();
                    break;
                case "options":
                    Options options = new Options();
                    options.ShowDialog();

                    break;
                case "employee-registration":

                    break;
                case "consult-category-registration":

                    break;
                case "support":

                    break; 
                case "chat-options":

                    break;
                case "login":
                    Login login = new Login();
                    login.ShowDialog();
                    break;
                default:
                    Errors("Pagina não encontrada!");
                    break;
            }
        }

        private void OpenLink(String link) {
            try {
                System.Diagnostics.Process.Start("cmd", $"/c start {link}");
            } catch (Exception ex) {
                Errors("Não foi possível abrir o aplicativo de mensagem!");
            }
        }

        private void Errors(String message) {
            MessageBox.Show(message);
        }

    }
}
