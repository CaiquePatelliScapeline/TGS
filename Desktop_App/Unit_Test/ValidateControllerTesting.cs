using NUnit.Framework;
using System.Collections.Generic;
using TGS.Controllers.Main;

namespace Unit_Test {
    [TestFixture]
    public class ValidateControllerTesting {
        ValidateController validateController = new ValidateController();
        
        [Test, TestCaseSource(typeof(Cases), "CPFs")]
        public bool CpfTest(string cpf) => validateController.CPF(cpf);

    }

    public class Cases {
        public static List<TestCaseData> CPFs {
            get {
                return new List<TestCaseData>() {
                    new TestCaseData("123.123.123-12").Returns(true).SetCategory("CPF Válido"),
                    new TestCaseData("12312312312").Returns(false).SetCategory("CPF Inválido"),
                    new TestCaseData("123.123.123.12").Returns(false).SetCategory("CPF Inválido"),
                    new TestCaseData("123.123.123-1").Returns(false).SetCategory("CPF Inválido"),
                    new TestCaseData("123.123.123-123").Returns(false).SetCategory("CPF Inválido"),
                    new TestCaseData("123.123.123-AA").Returns(false).SetCategory("CPF Inválido"),
                    new TestCaseData("123.123.123-**").Returns(false).SetCategory("CPF Inválido")
                };
            }
        }
    }
}