using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_11
{
    public class Circulo : Figura
    {
        public override double Area()
        {
            return (Math.PI*Math.Pow(Valor1,2));
        }

        public Circulo()
        {

        }
    }
}
