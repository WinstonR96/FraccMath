using FraccEntities;
using System;

namespace FraccMethod
{
    interface IMethod
    {
        /// <summary>
        /// Operaciones posibles con Fracciones
        /// </summary>
        /// <param Fraccion="f1"></param>
        /// <param Fraccion="f2"></param>
        /// <returns></returns>
        Boolean EsHomogenea(Fraccion f, Fraccion f2);

        Fraccion Suma(Fraccion f, Fraccion f2);

        Fraccion Resta(Fraccion f, Fraccion f2);

        Fraccion Multiplicacion(Fraccion f, Fraccion f2);

        Fraccion Division(Fraccion f, Fraccion f2);

        Double Valor(Fraccion f);
    }
}
