using NUnit.Framework;
using System.Collections.Generic;
using TGS.Controllers.Register;

namespace Unit_Test {
    [TestFixture]
    public class RegisterControllersTesting {
        ConsultsRegistration consultsRegistration = new ConsultsRegistration();
        DentistsRegistration dentistsRegistration = new DentistsRegistration();
        EmployeesRegistration employeesRegistration = new EmployeesRegistration();
        PatientsRegistration patientsRegistration = new PatientsRegistration();
        ProceduresRegistration proceduresRegistration = new ProceduresRegistration();

        [Test, TestCaseSource(typeof(RegisterCases), "Schedulings")]
        public bool ScheduleTest(string cro, string date, string time) => consultsRegistration.ConsultOpen(cro, date, time, true);

        [Test, TestCaseSource(typeof(RegisterCases), "Consults")]
        public bool ConsultTest(string cpf, int procedure, int consult) => consultsRegistration.ConsultRegistration(cpf, procedure, consult, true);

        [Test, TestCaseSource(typeof(RegisterCases), "Dentists")]
        public bool DentistTest(string cro, string name, string lastName, string expertise) => dentistsRegistration.DentistRegistration(cro, name, lastName, expertise, true);

        [Test, TestCaseSource(typeof(RegisterCases), "Employees")]
        public bool EmployeeTest(string cpf, string name, string lastName, string email, string telephone, string cellphone, string password) => employeesRegistration.EmployeeRegistration(cpf, name, lastName, email, telephone, cellphone, password, true);

        [Test, TestCaseSource(typeof(RegisterCases), "Patients")]
        public bool PatientTest(string cpf, string rg, string name, string lastName, string nickname, string birthDate, string height, string weight, string email, string telephone, string cellphone, string street, string neighborhood, string city, string district, string cep, string complement, string number) => patientsRegistration.PatientRegistration(cpf, rg, name, lastName, nickname, birthDate, height, weight, email, telephone, cellphone, street, neighborhood, city, district, cep, complement, number, true);

        [Test, TestCaseSource(typeof(RegisterCases), "Procedures")]
        public bool ProcedureTest(string title) => proceduresRegistration.ProcedureRegistration(title, true);
    }

    public class RegisterCases {
        public static List<TestCaseData> Schedulings {
            get {
                return new List<TestCaseData>() {
                    
                };
            }
        }

        public static List<TestCaseData> Consults {
            get {
                return new List<TestCaseData>() {

                };
            }
        }

        public static List<TestCaseData> Dentists {
            get {
                return new List<TestCaseData>() {
                    new TestCaseData("12.623", "Roberto", "Lakhross", "Canal").Returns(true).SetCategory("Dentista Válido"),
                    new TestCaseData("12123", "Roberto", "Lakhross", "Canal").Returns(false).SetCategory("Dentista Inválido"),
                    new TestCaseData("12-123", "Roberto", "Lakhross", "Canal").Returns(false).SetCategory("Dentista Inválido"),
                    new TestCaseData("12.1234", "Roberto", "Lakhross", "Canal").Returns(false).SetCategory("Dentista Inválido"),
                    new TestCaseData("12.12", "Roberto", "Lakhross", "Canal").Returns(false).SetCategory("Dentista Inválido")
                };
            }
        }

        public static List<TestCaseData> Employees {
            get {
                return new List<TestCaseData>() {

                };
            }
        }

        public static List<TestCaseData> Patients {
            get {
                return new List<TestCaseData>() {

                };
            }
        }

        public static List<TestCaseData> Procedures {
            get {
                return new List<TestCaseData>() {

                };
            }
        }
    }
}
