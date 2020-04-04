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

namespace Practica_6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public struct RegistroEmpleado
        {
            public string Nit;
            public string Nombre;
            public double Sueldo;
        }
       
        Dictionary<string, RegistroEmpleado> Registro = new Dictionary<string, RegistroEmpleado>();

        string patronNombre2 = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtNombre.Text, patronNombre2))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un nombre valido...\nEl nombre debe iniciar con mayusculas");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && !txtSueldo.Text.Contains("."))
            {
                e.Handled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || !Regex.IsMatch(txtNombre.Text, patronNombre2))
            {
                MessageBox.Show("El nombre es un campo obligatorio...\nIngrese el nombre...");
                txtNombre.Focus();
            }
            else if (mtxNit.Text == "" || !mtxNit.MaskFull)
            {
                MessageBox.Show("El NIT es un campo obligatorio...\nIngrese el NIT...");
                mtxNit.Focus();
            }
            else if (txtSueldo.Text == "")
            {
                MessageBox.Show("El sueldo es un campo obligatorio...\nIngrese el sueldo...");
                txtSueldo.Focus();
            }
            else if (Registro.ContainsKey(mtxNit.Text))
            {
                MessageBox.Show("Este número de NIT ya existe en el registo, no pueden existir dos números de NIT iguales...\nIngrese un numero de NIT nuevo...");
            }
            else
            {
                RegistroEmpleado Empleado = new RegistroEmpleado();
               Empleado.Nit = mtxNit.Text;
                Empleado.Nombre = txtNombre.Text;
                Empleado.Sueldo = Convert.ToDouble(txtSueldo.Text);
                
                Registro.Add(Empleado.Nit, Empleado);


                dataGridView1.Rows.Add(Empleado.Nit, Empleado.Nombre, Empleado.Sueldo);
                dataGridView1.ClearSelection();
                double t=0.0;
                for (int m = 0; m < dataGridView1.Rows.Count; m++)
                {
                    t = t + Convert.ToDouble(dataGridView1.Rows[m].Cells[2].Value);
                }
                lblTotal.Text = t.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (mtxNitb.Text == ""||!mtxNitb.MaskFull)
            {
                MessageBox.Show("Ingrese un codigo para buscar...");
                mtxNitb.Focus();
            }
            else if (Registro.ContainsKey(mtxNitb.Text))
            {
                for (int M = 0; M < dataGridView1.Rows.Count; M++)
                {
                    dataGridView1.Rows[M].DefaultCellStyle.BackColor = Color.White;
                    if (dataGridView1.Rows[M].Cells[0].Value.Equals(mtxNitb.Text))
                    {
                        dataGridView1.Rows[M].DefaultCellStyle.BackColor = Color.Blue;
                    }
                }
                MessageBox.Show("El NIT si existe...");
            }
            else
            {
                MessageBox.Show("El NIT que desea buscar no existe...");
            }
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (mtxNitb.Text == ""||!mtxNitb.MaskFull)
            {
                MessageBox.Show("Ingrese un codigo para eliminar...");
                mtxNitb.Focus();
            }
            else if (Registro.ContainsKey(mtxNitb.Text))
            {
                for (int M = 0; M < dataGridView1.Rows.Count; M++)
                {

                    if (dataGridView1.Rows[M].Cells[0].Value.Equals(mtxNitb.Text))
                    {
                        dataGridView1.Rows.RemoveAt(M);
                        Registro.Remove(mtxNitb.Text);
                    }
                }
                double t = 0.0;
                for (int m = 0; m < dataGridView1.Rows.Count; m++)
                {
                    t = Convert.ToDouble(dataGridView1.Rows[m].Cells[2].Value)-t;
                }
                lblTotal.Text = t.ToString();
            }
            else
            {
                MessageBox.Show("El codigo de paciente que desea eliminar no existe...");
            }
           
        }
    }
}
