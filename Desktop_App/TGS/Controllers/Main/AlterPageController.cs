using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TGS.Views;

namespace TGS.Controllers.Main {
    class AlterPageController {
        //Fields
        private String chatLink = "whatsapp://";

        public void AlterPage(Form formAtual, String formDestino, String IdDetailItem = null) {
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
                    SchedulePage calendar = new SchedulePage();
                    calendar.ShowDialog();
                    break;
                // Go to consults registration
                case "consults-registration":
                    FormPage consultsRegistration = new FormPage("consults");
                    consultsRegistration.ShowDialog();
                    break;
                // Go to employee details
                case "consult-details":
                    DetailsPage consultsDetails = new DetailsPage("consult");
                    consultsDetails.ShowDialog();
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
                // Go to patient details
                case "patient-details":
                    DetailsPage patientDetails = new DetailsPage("patient");
                    patientDetails.ShowDialog();
                    break;
                // Go to options
                case "options":
                    Options options = new Options();
                    options.ShowDialog();
                    break;
                // Go to dentists list
                case "dentists-list":
                    ListPage dentists = new ListPage("dentists");
                    dentists.ShowDialog();
                    break;
                // Go to dentists registration
                case "dentists-registration":
                    FormPage dentistsRegistration = new FormPage("dentists");
                    dentistsRegistration.ShowDialog();
                break;
                // Go to dentist details
                case "dentist-details":
                    DetailsPage dentistDetails = new DetailsPage("dentist", IdDetailItem);
                    dentistDetails.ShowDialog();
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
                // Go to employee details
                case "employee-details":
                    DetailsPage employeeDetails = new DetailsPage("employee");
                    employeeDetails.ShowDialog();
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
                // Go to employee details
                case "consult-category-details":
                    DetailsPage consultsCategoryDetails = new DetailsPage("consult-category");
                    consultsCategoryDetails.ShowDialog();
                    break;
                // Go to support
                case "support":
                    Errors("404", "Não tem KK");
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
