using System;
using System.Collections.Generic;
using System.Text;
using CadastroClientes.Util.Validacoes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CadastroClientes.Test.UtilTests
{
    [TestClass]
    public class ValidarCpfTest
    {
        [TestMethod]
        public void DeveVerificarCpfValido()
        {
            var result = ValidarCpf.IsCpf("656.952.310-43");

            Assert.IsTrue(result);
        }
    }
}
