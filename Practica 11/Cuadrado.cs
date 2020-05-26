using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_11
{
    public class Cuadrado:Figura
    {
        public override double Area()
        {
            return (Math.Pow(Valor1, 2));
        }

        public Cuadrado()
        {

        }
    }
}
