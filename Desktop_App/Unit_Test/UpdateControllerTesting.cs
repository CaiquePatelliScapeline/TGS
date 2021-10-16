using NUnit.Framework;
using System.Collections.Generic;
using TGS.Controllers.Update;

namespace Unit_Test {
    [TestFixture]
    public class UpdateControllerTesting {
        ScheduleUpdate consultUpdate = new ScheduleUpdate();
        DentistUpdate dentistUpdate = new DentistUpdate();
        EmployeeUpdate employeeUpdate = new EmployeeUpdate();
        PatientUpdate patientUpdate = new PatientUpdate();
        ProcedureUpdate procedureUpdate = new ProcedureUpdate();

        [Test, TestCaseSource(typeof(RegisterCases), "Consults")]
        public bool ConsultTest(string cpfPatient, string date, string time, int oldId, string procedureTitle) => consultUpdate.ScheduleUpdating(cpfPatient, date, time, oldId, procedureTitle, true);

        [Test, TestCaseSource(typeof(RegisterCases), "Dentists")]
        public bool DentistTest(string id, string cro, string name, string lastName, string expertise) => dentistUpdate.Dentist(id, cro, name, lastName, expertise, true);

        [Test, TestCaseSource(typeof(RegisterCases), "Employees")]
        public bool EmployeeTest(string id, string cpf, string name, string lastName, string email, string telephone, string cellphone) => employeeUpdate.Employee(id, cpf, name, lastName, email, telephone, cellphone, true);

        [Test, TestCaseSource(typeof(RegisterCases), "Patients")]
        public bool PatientTest(string id, string cpf, string rg, string name, string lastName, string nickname, string birthDate, string height, string weight, string email, string telephone, string cellphone, string street, string neighborhood, string city, string district, string cep, string complement, int number) => patientUpdate.Patient(id, cpf, rg, name, lastName, nickname, birthDate, height, weight, email, telephone, cellphone, street, neighborhood, city, district, cep, complement, number, true);

        [Test, TestCaseSource(typeof(RegisterCases), "Procedures")]
        public bool ProcedureTest(int id, string title) => procedureUpdate.Procedure(id, title, true);

    }

    public class UpdateCases {
        public static List<TestCaseData> Consults {
            get {
                return new List<TestCaseData>() {

                };
            }
        }

        public static List<TestCaseData> Dentists {
            get {
                return new List<TestCaseData>() {

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