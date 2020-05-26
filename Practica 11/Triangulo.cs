using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_11
{
    class Triangulo: Figura
    {
        private double valor2;

        public double Valor2 { get => valor2; set => valor2 = value; }

        public override double Area()
        {
            return (Valor1*Valor2)/2;
        }
        public Triangulo()
        {

        }
    }
}
