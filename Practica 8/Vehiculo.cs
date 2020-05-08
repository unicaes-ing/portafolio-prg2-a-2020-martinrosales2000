using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Practica_8
{
    [Serializable]
    class Vehiculo
    {
        private string matricula;
        private string marca;
        private string modelo;
        private string color;
        private int año;
        private int pasajeros;

        public Vehiculo(string matricula, string marca, string modelo, string color, int año, int pasajeros)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.año = año;
            this.pasajeros = pasajeros;
        }

        public Vehiculo()
        {
            Matricula = "";
            Marca = "";
            Modelo = "";
            Color = "";
            Año = 0;
            Pasajeros = 0;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public int Año { get => año; set => año = value; }
        public int Pasajeros { get => pasajeros; set => pasajeros = value; }
    }
}
