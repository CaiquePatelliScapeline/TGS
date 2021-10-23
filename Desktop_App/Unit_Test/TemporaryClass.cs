using NUnit.Framework;
using System.Text.RegularExpressions;

namespace Unit_Apresentacao {
    [TestFixture]
    class Apresentacao {

        [Test]
        [TestCase("13.295-000", ExpectedResult = true, TestName = "CEP Válido")]
        [TestCase("13.295.000", ExpectedResult = false, TestName = "CEP Inválido")]
        public bool ValidarCEP(string cep) {
            Regex cepValidate = new Regex(@"^(\d{2})\.(\d{3})-(\d{3})$");
            return cepValidate.IsMatch(cep);
        }
    }
}