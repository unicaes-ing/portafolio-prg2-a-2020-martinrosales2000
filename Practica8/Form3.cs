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

namespace Practica8
{
    public partial class Form3 : Form
    {
        public Form3(Vehiculo vehiculo, List<string> Matriculas)
        {
            InitializeComponent();
            if (vehiculo != null)
            {
                mtxMatricula.Text = vehiculo.Matricula;
                txtMarca.Text = vehiculo.Marca;
                txtModelo.Text = vehiculo.Modelo;
                cboColor.Text = vehiculo.Color;
                nudYear.Value = vehiculo.Year;
                nudPasajeros.Value = vehiculo.NumPasajeros;
            }
            listaMatriculas = Matriculas;
        }

        private Vehiculo nuevoVehiculo = new Vehiculo();
        private List<string> listaMatriculas = new List<string>();
        public Vehiculo getVehiculo()
        {
            return nuevoVehiculo;
        }

        string Patron = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{1,})(\s)?)[^\s]$";

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (mtxMatricula.Text.Length == 0 && txtMarca.Text.Length == 0 && txtModelo.Text.Length == 0 && cboColor.SelectedIndex == -1 && nudPasajeros.Value == 0)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                mtxMatricula.Focus();
            }
            else if (mtxMatricula.Text.Length == 0)
            {
                MessageBox.Show("La matrícula es un campo obligatorio.");
                mtxMatricula.Focus();
                mtxMatricula.SelectAll();
            }
            else if (!mtxMatricula.MaskFull)
            {
                MessageBox.Show("La matrícula debe estar completa.");
                mtxMatricula.Focus();
                mtxMatricula.SelectAll();
            }
            else if (txtMarca.Text.Length == 0)
            {
                MessageBox.Show("La marca es un campo obligatorio.");
                txtMarca.Focus();
                txtMarca.SelectAll();
            }
            else if (!Regex.IsMatch(txtMarca.Text, Patron))
            {
                MessageBox.Show("Debe ingresar la marca con la primera letra mayúscula.");
                txtMarca.Focus();
                txtMarca.SelectAll();
            }
            else if (txtModelo.Text.Length == 0)
            {
                MessageBox.Show("El modelo es un campo obligatorio.");
                txtModelo.Focus();
                txtModelo.SelectAll();
            }
            else if (!Regex.IsMatch(txtModelo.Text, Patron))
            {
                MessageBox.Show("Debe ingresar el modelo con la primera letra mayúscula");
                txtModelo.Focus();
                txtModelo.SelectAll();
            }
            else if (cboColor.SelectedIndex == -1)
            {
                MessageBox.Show("El color es un campo obligatorio.");
            }
            else if (nudPasajeros.Value == 0)
            {
                MessageBox.Show("La cantidad de pasajeros es un campo obligatorio");
            }
            else
            {
                DialogResult = DialogResult.OK;
                nuevoVehiculo.Matricula = mtxMatricula.Text;
                nuevoVehiculo.Marca = txtMarca.Text;
                nuevoVehiculo.Modelo = txtModelo.Text;
                nuevoVehiculo.Color = cboColor.Text;
                nuevoVehiculo.Year = Convert.ToInt32(nudYear.Value);
                nuevoVehiculo.NumPasajeros = Convert.ToInt32(nudPasajeros.Value);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
