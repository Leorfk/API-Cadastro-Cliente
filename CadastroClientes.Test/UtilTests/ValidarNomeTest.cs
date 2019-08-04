using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CadastroClientes.Util.Validacoes;
namespace CadastroClientes.Test.UtilTests
{
    [TestClass]
    public class ValidarNomeTest
    {
        [TestMethod]
        public void DeveVerificarExistemNumerosNome()
        {
            var Result = ValidarNome.IsNome("Leonardo");
            Assert.IsTrue(Result);
        }
    }
}
