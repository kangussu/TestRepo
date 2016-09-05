using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teste1;

namespace UnitTeste1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesteSoma()
        {
            Calc c = new Calc();
            int retorno = c.intSoma(3, 4);
            Assert.AreEqual(7, retorno);
        }
    }
}
