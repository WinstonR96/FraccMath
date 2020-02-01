using System;
using FraccMethod;
using FraccEntities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpectedObjects;

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
            var result = _method.EsHomogenea(f1, f2);
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

        [TestMethod]
        public void sumaHomogenea()
        {
            Fraccion f1 = new Fraccion { Numerador = 1, Denominador = 2 };
            Fraccion f2 = new Fraccion { Numerador = 1, Denominador = 2 };
            var esperado = new Fraccion { Numerador = 2, Denominador = 2 };
            var result = _method.Suma(f1, f2);
            esperado.ToExpectedObject().ShouldEqual(result);
        }

        [TestMethod]
        public void sumaHeterogenea()
        {
            Fraccion f1 = new Fraccion { Numerador = 1, Denominador = 2 };
            Fraccion f2 = new Fraccion { Numerador = 1, Denominador = 3 };
            var esperado = new Fraccion { Numerador = 5, Denominador = 6 };
            var result = _method.Suma(f1, f2);
            esperado.ToExpectedObject().ShouldEqual(result);
        }

        [TestMethod]
        public void restaHomogenea()
        {
            Fraccion f1 = new Fraccion { Numerador = 1, Denominador = 2 };
            Fraccion f2 = new Fraccion { Numerador = 1, Denominador = 2 };
            var esperado = new Fraccion { Numerador = 0, Denominador = 2 };
            var result = _method.Resta(f1, f2);
            esperado.ToExpectedObject().ShouldEqual(result);
        }

        [TestMethod]
        public void restaHeterogenea()
        {
            Fraccion f1 = new Fraccion { Numerador = 1, Denominador = 2 };
            Fraccion f2 = new Fraccion { Numerador = 1, Denominador = 3 };
            var esperado = new Fraccion { Numerador = 1, Denominador = 6 };
            var result = _method.Resta(f1, f2);
            esperado.ToExpectedObject().ShouldEqual(result);
        }
    }
}
