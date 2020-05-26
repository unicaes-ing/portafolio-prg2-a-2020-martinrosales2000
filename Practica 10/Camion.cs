using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10
{
    public class Camion : Automovil
    {
        private int capacidadCarga;
        private int tanqueCombustible;

        public int CapacidadCarga { get => capacidadCarga; set => capacidadCarga = value; }
        public int TanqueCombustible { get => tanqueCombustible; set => tanqueCombustible = value; }

        public Camion (string marca, int millaje, string modelo, double precio, int capacidadCarga, int tanqueCombustible): base(marca, millaje, modelo, precio)
        {
            this.capacidadCarga = capacidadCarga;
            this.tanqueCombustible = tanqueCombustible;
        }
    }
}
