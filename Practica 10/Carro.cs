using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10
{
    public class Carro : Automovil
    {

        private int puerta;

        public int Puerta { get => puerta; set => puerta = value; }

        public Carro(string marca, int millaje, string modelo, double precio, int puerta): base(marca,millaje,modelo,precio)
        {
            this.puerta = puerta;
        }
    }
}
