using System;
using System.Collections.Generic;
using System.Text;
using CadastroClientes.Util.Validacoes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CadastroClientes.Test.UtilTests
{
    [TestClass]
    public class ValidarCnpjTest
    {
        [TestMethod]
        public void DeveVerificarCnpjValido()
        {
            var result = ValidarCnpj.IsCnpj("74.737.238/0001-30");

            Assert.IsTrue(result);
        }
    }
}
