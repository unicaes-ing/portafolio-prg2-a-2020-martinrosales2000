using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Practica_8
{
    public partial class frmNuevo : Form
    {
        public frmNuevo (Vehiculo vehiculo, List<string> Matricula )
        {
            InitializeComponent();
            if (vehiculo != null)
            {
                mtxMatricula.Text = vehiculo.Matricula;
                txtMarca.Text = vehiculo.Marca;
                txtModelo.Text = vehiculo.Modelo;
                cboColor.Text = vehiculo.Color;
                nudAño.Value = vehiculo.Año;
                nudPasajeros.Value = vehiculo.Pasajeros;
            }
            listaVehiculos = Matricula;
        }

        private List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        private Vehiculo nuevoVehiculo = new Vehiculo();
        public Vehiculo getVehiculo()
        {
            return nuevoVehiculo;
        }

        string Patron = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{1,})(\s)?)*[^\s]$";

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (mtxMatricula.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || cboColor.SelectedIndex == -1 || nudPasajeros.Value == 0)
            {
                MessageBox.Show("Debe ingresar datos de vehículos para poder almacenar");
                mtxMatricula.Focus();
            }
            else if (mtxMatricula.Text == "")
            {
                MessageBox.Show("La matrícula es un campo obligatorio");
                mtxMatricula.Focus();
            }
            else if (!mtxMatricula.MaskFull)
            {
                MessageBox.Show("Ingrese la matricula completa");
                mtxMatricula.Focus();
            }
            else if (txtMarca.Text == "")
            {
                MessageBox.Show("La marca es un campo obligatorio");
                txtMarca.Focus();
            }
            else if (!Regex.IsMatch(txtMarca.Text, Patron))
            {
                MessageBox.Show("Debe ingresar la marca con la primera letra mayuscula");
                txtMarca.Focus();
            }
            else if (txtModelo.Text == "")
            {
                MessageBox.Show("El modelo es un campo obligatorio");
                txtModelo.Focus();
            }
            else if (!Regex.IsMatch(txtModelo.Text, Patron))
            {
                MessageBox.Show("Debe ingresar el modelo con la primera letra mayuscula");
                txtModelo.Focus();
            }
            else if (cboColor.SelectedIndex == -1)
            {
                MessageBox.Show("El color es un campo obligatorio\nDebe seleccionar un Color");
            }
            else if (nudPasajeros.Value == 0)
            {
                MessageBox.Show("La cantidad de pasajeros es un campo obligatorio");
                nudPasajeros.Focus();
            }
            else
            {
                nuevoVehiculo.Matricula = mtxMatricula.Text;
                nuevoVehiculo.Marca = txtMarca.Text;
                nuevoVehiculo.Modelo = txtModelo.Text;
                nuevoVehiculo.Color = cboColor.Text;
                nuevoVehiculo.Año = Convert.ToInt32(nudAño.Value);
                nuevoVehiculo.Pasajeros = Convert.ToInt32(nudPasajeros.Value);
                DialogResult=DialogResult.OK;


            }
        }

        private void btnCacelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
