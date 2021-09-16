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

        public void AlterPage(Form formAtual, String formDestino) {
            if (!(formAtual is null)) {
                formAtual.Hide();
            } 

            switch (formDestino) {
                // Go to home
                case "home":
                    Home home = new Home();
                    home.ShowDialog();
                    break;
                // Go to calendar
                case "calendar":
                    ListPage calendar = new ListPage("consults");
                    calendar.ShowDialog();
                    break;
                // Go to consults registration
                case "consults-registration":
                    FormPage consultsRegistration = new FormPage("consults");
                    consultsRegistration.ShowDialog();
                    break;
                // Go to chat
                case "chat":
                    OpenLink(chatLink);
                    break;
                // Go to patients list
                case "patients":
                    ListPage patients = new ListPage("patients");
                    patients.ShowDialog();
                    break;
                // Go to patientes registration
                case "patients-registration":
                    FormPage patientsRegistration = new FormPage("patients");
                    patientsRegistration.ShowDialog();
                    break;
                // Go to options
                case "options":
                    Options options = new Options();
                    options.ShowDialog();
                    break;
                // Go to employees list
                case "employee-list":
                    ListPage employees = new ListPage("employees");
                    employees.ShowDialog();
                    break;
                // Go to employees registration
                case "employee-registration":
                    FormPage employeesRegistration = new FormPage("employees");
                    employeesRegistration.ShowDialog();
                    break;
                // Go to consults category list
                case "consult-category-list":
                    ListPage consultsCategory = new ListPage("consult-categories");
                    consultsCategory.ShowDialog();
                    break;
                // Go to consults category registration
                case "consult-category-registration":
                    FormPage consultsCategoryRegistration = new FormPage("consults-categories");
                    consultsCategoryRegistration.ShowDialog();
                    break;
                // Go to support
                case "support":

                    break;
                // Go to chat options
                case "chat-options":

                    break;
                // Go to login
                case "login":
                    Login login = new Login();
                    login.ShowDialog();
                    break;
                default:
                    Errors("404", "Página não encontrada!");
                    break;
            }
        }

        private void OpenLink(String link) {
            try {
                System.Diagnostics.Process.Start("cmd", $"/c start {link}");
            } catch (Exception ex) {
                Errors("Erro", "Não foi possível abrir o aplicativo de mensagem!");
            }
        }

        public void Errors(String title, String message) {
            MyMsgBox.Show(title, message, false);
            AlterPage(null, "home");
        }

    }
}
