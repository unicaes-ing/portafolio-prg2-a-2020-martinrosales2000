using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_9
{
    public class Mascota
    {
        private string nombre;
        private string tipo;
        private string sexo;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }

        //public string getNombre()
        //{
        //    return nombre;
        //}

        //public void setNombre(string nombre)
        //{
        //    this.nombre = nombre;
        //}

        //public string getTipo()
        //{
        //    return tipo;
        //}

        //public void setTipo(string tipo)
        //{
        //    this.tipo = tipo;
        //}

        //public string getSexo()
        //{
        //    return sexo;
        //}

        //public void setSexo(string sexo)
        //{
        //    this.sexo = sexo;
        //}

        //public int getEdad()
        //{
        //    return edad;
        //}

        //public void setEdad(int edad)
        //{
        //    this.edad = edad;
        //}
    }
}
