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

namespace Practica_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string patronNombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{1,})(\s)?)*[^\s]$";
        Mascota nuevaMasc = new Mascota();
        string nombre, tipo, sexo;
        int edad;

       

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0 && cboTipo.SelectedIndex == -1 && txtEdad.Text.Length == 0)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                txtNombre.Focus();
            }
            else if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("El nombre es un campo obligatorio.");
                txtNombre.SelectAll();
                txtNombre.Focus();
            }
            else if (!Regex.IsMatch(txtNombre.Text, patronNombre))
            {
                MessageBox.Show("Ingrese un nombre con inicial mayúscula.");
                txtNombre.SelectAll();
                txtNombre.Focus();
            }
            else if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir una opción para continuar.");
            }
            else if (txtEdad.Text.Length == 0)
            {
                MessageBox.Show("La edad es un campo obligatorio.");
                txtEdad.Focus();
                txtEdad.SelectAll();
            }
            else if (Convert.ToInt32(txtEdad.Text) == 0)
            {
                MessageBox.Show("La edad debe ser mayor que cero.");
                txtEdad.Focus();
                txtEdad.SelectAll();
            }
            else
            {
                nuevaMasc.Nombre = txtNombre.Text;
                nuevaMasc.Tipo=cboTipo.Text;

                if (rdoM.Checked)
                {
                    nuevaMasc.Sexo=rdoM.Text;
                }
                else
                {
                    nuevaMasc.Sexo=rdoH.Text;
                }

                nuevaMasc.Edad=Convert.ToInt32(txtEdad.Text);


                nombre = nuevaMasc.Nombre;
                tipo = nuevaMasc.Tipo;
                sexo = nuevaMasc.Sexo;
                edad = nuevaMasc.Edad;

                MessageBox.Show("Todos los datos han sido almacenados.");
                dataGridView1.Rows.Add(nombre, tipo, sexo, edad);

                dataGridView1.ClearSelection();
                txtNombre.Clear();
                cboTipo.SelectedIndex = -1;
                rdoM.Checked = true;
                txtEdad.Clear();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count<=0)
            {
                MessageBox.Show("Debe ingresar los datos de almenos una mascota para imprimir");
            }
            else
            {
                try
                {
                    rvMascota reporte = new rvMascota();
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        Mascota mascota = new Mascota
                        {
                            Nombre = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                            Tipo = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                            Sexo = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                            Edad = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)

                        };
                        reporte.listaMascotas.Add(mascota);
                    }

                    reporte.ShowDialog(this);
                }
                catch (Exception)
                {
                    MessageBox.Show("Existe un problema con el reporte de empleados", "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }
    }
}
