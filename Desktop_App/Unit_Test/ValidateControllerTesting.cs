using NUnit.Framework;
using System.Collections.Generic;
using TGS.Controllers.Main;

namespace Unit_Test {
    [TestFixture]
    public class ValidateControllerTesting {
        ValidateController validateController = new ValidateController();

        [Test, TestCaseSource(typeof(ValidateCases), "Dates")]
        public bool DateTest(string date) => validateController.Date(date);

        [Test, TestCaseSource(typeof(ValidateCases), "Times")]
        public bool TimeTest(string time) => validateController.Time(time);

        [Test, TestCaseSource(typeof(ValidateCases), "Emails")]
        public bool EmailTest(string email) => validateController.Email(email);

        [Test, TestCaseSource(typeof(ValidateCases), "RGs")]
        public bool RgTest(string rg) => validateController.RG(rg);

        [Test, TestCaseSource(typeof(ValidateCases), "CPFs")]
        public bool CpfTest(string cpf) => validateController.CPF(cpf);

        [Test, TestCaseSource(typeof(ValidateCases), "CROs")]
        public bool CroTest(string cro) => validateController.CRO(cro);

        [Test, TestCaseSource(typeof(ValidateCases), "CEPs")]
        public bool CepTest(string cep) => validateController.CEP(cep);

        [Test, TestCaseSource(typeof(ValidateCases), "Telephones")]
        public bool TelephoneTest(string telephone) => validateController.Telephone(telephone);

        [Test, TestCaseSource(typeof(ValidateCases), "Cellphones")]
        public bool CellphoneTest(string cellphone) => validateController.Cellphone(cellphone);
    }

    public class ValidateCases {
        public static List<TestCaseData> Dates {
            get {
                return new List<TestCaseData>() {
                    
                };
            }
        }

        public static List<TestCaseData> Times {
            get {
                return new List<TestCaseData>() {

                };
            }
        }

        public static List<TestCaseData> Emails {
            get {
                return new List<TestCaseData>() {

                };
            }
        }

        public static List<TestCaseData> RGs {
            get {
                return new List<TestCaseData>() {

                };
            }
        }

        public static List<TestCaseData> CPFs {
            get {
                return new List<TestCaseData>() {
                    new TestCaseData("123.123.123-12").Returns(true).SetCategory("CPF Válido"),
                    new TestCaseData("").Returns(false).SetCategory("CPF Inválido"),
                    new TestCaseData("12312312312").Returns(false).SetCategory("CPF Inválido"),
                    new TestCaseData("123.123.123.12").Returns(false).SetCategory("CPF Inválido"),
                    new TestCaseData("123.123.123-1").Returns(false).SetCategory("CPF Inválido"),
                    new TestCaseData("123.123.123-123").Returns(false).SetCategory("CPF Inválido"),
                    new TestCaseData("123.123.123-AA").Returns(false).SetCategory("CPF Inválido"),
                    new TestCaseData("123.123.123-**").Returns(false).SetCategory("CPF Inválido")
                };
            }
        }

        public static List<TestCaseData> CROs {
            get {
                return new List<TestCaseData>() {

                };
            }
        }

        public static List<TestCaseData> CEPs {
            get {
                return new List<TestCaseData>() {

                };
            }
        }

        public static List<TestCaseData> Telephone {
            get {
                return new List<TestCaseData>() {

                };
            }
        }

        public static List<TestCaseData> Cellphone {
            get {
                return new List<TestCaseData>() {

                };
            }
        }
    }
}