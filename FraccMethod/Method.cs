using FraccEntities;
using System;

namespace FraccMethod
{
    public class Method : IMethod
    {
        int num;
        int den;
        Fraccion res;

        public bool EsHomogenea(Fraccion f, Fraccion f2)
        {
            if (f.Denominador == f2.Denominador)
                return true;
            else
                return false;
        }

        public Fraccion Suma(Fraccion f, Fraccion f2)
        {
            if (EsHomogenea(f, f2))
            {
                num = f.Numerador + f2.Numerador;
                den = f.Denominador;
            }
            else
            {
                num = ((f.Numerador * f2.Denominador) + (f.Denominador * f2.Numerador));
                den = (f.Denominador * f2.Denominador);
            }
            res = new Fraccion { Denominador = den, Numerador = num };
            return res;
        }

        public Fraccion Resta(Fraccion f, Fraccion f2)
        {
            if (EsHomogenea(f, f2))
            {
                num = (f.Numerador - f2.Numerador);
                den = (f.Denominador);
            }
            else
            {
                num = ((f.Numerador * f2.Denominador) - (f.Denominador * f2.Numerador));
                den = (f.Denominador * f2.Denominador);
            }

            res = new Fraccion { Denominador = den, Numerador = num };
            return res;
        }

        public Fraccion Multiplicacion(Fraccion f, Fraccion f2)
        {
            num = (f.Numerador * f2.Numerador);
            den = (f.Denominador * f2.Denominador);
            res = new Fraccion { Denominador = den, Numerador = num };
            return res;
        }

        public Fraccion Division(Fraccion f, Fraccion f2)
        {
            num = (f.Numerador * f2.Denominador);
            den = (f.Denominador * f2.Numerador);
            res = new Fraccion { Denominador = den, Numerador = num };
            return res;
        }

        public double Valor(Fraccion f)
        {
            double n = Convert.ToDouble(f.Numerador);
            double d = Convert.ToDouble(f.Denominador);
            double res = (n / d);
            return res;
        }

    }
}

