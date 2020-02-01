using System;
using FraccMethod;
using FraccEntities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FraccTest
{
    [TestClass]
    public class FraccMethod
    {
        private readonly Method _method;

        public FraccMethod()
        {
            _method = new Method();
        }

        [TestMethod]
        public void EsHomogenea()
        {
            Fraccion f1 = new Fraccion { Numerador = 1, Denominador = 2 };
            Fraccion f2 = new Fraccion { Numerador = 1, Denominador = 2 };
            var result = _method.EsHomogenea(f1,f2);
            Assert.IsTrue(result, "Si tienen los mismo denominadores son homogeneas");
        }

        [TestMethod]
        public void esHeterogenea()
        {
            Fraccion f1 = new Fraccion { Numerador = 1, Denominador = 2 };
            Fraccion f2 = new Fraccion { Numerador = 1, Denominador = 3 };
            var result = _method.EsHomogenea(f1, f2);
            Assert.IsFalse(result, "Si no son iguales no es homogenea por lo tanto es heterogenea");
        }
    }
}
