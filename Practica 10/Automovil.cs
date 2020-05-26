using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10
{
    public class Automovil
    {
        private string marca;
        private int millaje;
        private string modelo;
        private double precio;

        public string Marca { get => marca; set => marca = value; }
        public int Millaje { get => millaje; set => millaje = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public double Precio { get => precio; set => precio = value; }

        public Automovil(string marca, int millaje, string modelo, double precio)
        {
            this.marca = marca;
            this.millaje = millaje;
            this.modelo = modelo;
            this.precio = precio;
        }
    }
}
