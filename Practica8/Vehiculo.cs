using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Practica8
{
    [Serializable]
    public class Vehiculo
    {
        private string matricula;
        private string marca;
        private string modelo;
        private string color;
        private int year;
        private int numPasajeros;

        public Vehiculo(string matricula, string marca, string modelo, string color, int year, int numPasajeros)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.year = year;
            this.numPasajeros = numPasajeros;
        }

        public Vehiculo()
        {
            Matricula = "";
            Marca = "";
            Modelo = "";
            Color = "";
            Year = 0;
            NumPasajeros = 0;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }
        public int NumPasajeros { get => numPasajeros; set => numPasajeros = value; }
    }
}
