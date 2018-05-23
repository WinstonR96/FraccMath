using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FraccEntities
{
    public class Fraccion
    {
        public int Numerador { get; private set; }
        public int Denominador { get; private set; }

        public Fraccion() { }


        public Fraccion(int numerador, int denominador)
        {
            this.Numerador = numerador;
            this.Denominador = denominador;
        }

        public override string ToString()
        {
            return "Numerador: " + this.Numerador + "\n" + "Denominador: " + this.Denominador;
        }
    }
}
