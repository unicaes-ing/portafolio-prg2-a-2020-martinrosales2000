using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoCarro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCarro.Checked)
            {
                txtPuertas.Visible = true;
                lblPuertas.Visible = true;
            }
            else
            {
                txtPuertas.Visible = false;
                lblPuertas.Visible = false;
            }
        }

        private void rdoCamion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCamion.Checked)
            {
                txtCapacidadCarga.Visible = true;
                lblCapacidadCarga.Visible = true;
                lblKilos.Visible = true;
                txtTanqueCombustible.Visible = true;
                lblTanqueCombustible.Visible = true;
                lblGalones.Visible = true;
            }
            else
            {
                txtCapacidadCarga.Visible = false;
                lblCapacidadCarga.Visible = false;
                lblKilos.Visible = false;
                txtTanqueCombustible.Visible = false;
                lblTanqueCombustible.Visible = false;
                lblGalones.Visible = false;
            }
        }

        private void rdoMicrobus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMicrobus.Checked)
            {
                txtPasajeros.Visible = true;
                lblPasajeros.Visible = true;

            }
            else
            {
                txtPasajeros.Visible = false;
                lblPasajeros.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPuertas.Visible = false;
            lblPuertas.Visible = false;
            txtCapacidadCarga.Visible = false;
            lblCapacidadCarga.Visible = false;
            lblKilos.Visible = false;
            txtTanqueCombustible.Visible = false;
            lblTanqueCombustible.Visible = false;
            lblGalones.Visible = false;
            txtPasajeros.Visible = false;
            lblPasajeros.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text==string.Empty && txtModelo.Text==string.Empty && nudPrecio.Value==0)
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
            if (txtMarca.Text==string.Empty)
            {
                MessageBox.Show("La marca es un campo obligatorio");
                txtMarca.Focus();
            }
            else if (txtModelo.Text==string.Empty)
            {
                MessageBox.Show("El modelo es un campo obligatorio");
                txtModelo.Focus();
            }
            else if (nudPrecio.Value==0)
            {
                MessageBox.Show("El precio es un campo obligatorio");
                nudPrecio.Focus();
            }
            else if (!rdoCarro.Checked && !rdoCamion.Checked && !rdoMicrobus.Checked)
            {
                MessageBox.Show("Debe elegir un tipo de automovil");
            }
            else if (rdoCarro.Checked)
            {

                if (txtPuertas.Text==string.Empty)
                {
                    MessageBox.Show("La cantidad de puertas es un campo obligatorio");
                    txtPuertas.Focus();
                }
                else
                {
                    Carro carro = new Carro(txtMarca.Text,Convert.ToInt32(nudMillaje.Value), txtModelo.Text, Convert.ToInt32(nudPrecio.Value),Convert.ToInt32(txtPuertas.Text));
                    dataGridView1.Rows.Add(carro.Marca, carro.Modelo, carro.Millaje, carro.Precio,"Carro",carro.Puerta);
                    dataGridView1.ClearSelection();
                    txtMarca.Clear();
                    txtModelo.Clear();
                    nudMillaje.Value = 0;
                    nudPrecio.Value = 0;
                    txtPuertas.Clear();
                    txtMarca.Focus();
                }
            }
            else if (rdoCamion.Checked)
            {
                if (txtCapacidadCarga.Text==string.Empty)
                {
                    MessageBox.Show("La capacidad de carga es un campo obligatorio");
                    txtCapacidadCarga.Focus();
                }
                else if (txtTanqueCombustible.Text==string.Empty)
                {
                    MessageBox.Show("La capacidad del tanque de combustible es un campo obligatorio");
                    txtTanqueCombustible.Focus();
                }
                else
                {
                    Camion camion = new Camion(txtMarca.Text, Convert.ToInt32(nudMillaje.Value), txtModelo.Text, Convert.ToInt32(nudPrecio.Value), Convert.ToInt32(txtCapacidadCarga.Text), Convert.ToInt32(txtTanqueCombustible.Text));
                    dataGridView1.Rows.Add(camion.Marca,camion.Modelo, camion.Millaje,camion.Precio, "Camion","", camion.CapacidadCarga, camion.TanqueCombustible);
                    dataGridView1.ClearSelection();
                    txtMarca.Clear();
                    txtModelo.Clear();
                    nudMillaje.Value = 0;
                    nudPrecio.Value = 0;
                    txtCapacidadCarga.Clear();
                    txtTanqueCombustible.Clear();
                    txtMarca.Focus();
                }
            }
            else if (rdoMicrobus.Checked)
            {
                if (txtPasajeros.Text==string.Empty)
                {
                    MessageBox.Show("La cantidad de pasajeros es un campo obligatorio");
                    txtPasajeros.Focus();
                }
                else
                {
                    Microbus microbus = new Microbus(txtMarca.Text, Convert.ToInt32(nudMillaje.Value), txtModelo.Text, Convert.ToInt32(nudPrecio.Value), Convert.ToInt32(txtPasajeros.Text));
                    dataGridView1.Rows.Add(microbus.Marca,microbus.Modelo,microbus.Millaje,microbus.Precio,"Microbus","","","",microbus.Pasajeros);
                    dataGridView1.ClearSelection();
                    txtMarca.Clear();
                    txtModelo.Clear();
                    nudMillaje.Value = 0;
                    nudPrecio.Value = 0;
                    txtPasajeros.Clear();
                    txtMarca.Focus();
                }
            }
        }
    }
}
