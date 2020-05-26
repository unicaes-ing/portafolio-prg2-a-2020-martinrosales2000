using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_11
{
    public abstract class Figura
    {
        private double valor1;

        public double Valor1 { get => valor1; set => valor1 = value; }

        public abstract double Area();

        public Figura()
        {

        }
    }
}
