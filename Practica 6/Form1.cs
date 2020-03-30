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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> Empleados = new List<string>();

        private void txtEmpleado_Validating(object sender, CancelEventArgs e)
        {
            string patronNombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";

            if (!Regex.IsMatch(txtEmpleado.Text, patronNombre))
            {
                e.Cancel = true;
                txtEmpleado.SelectAll();
                errorProvider1.SetError(txtEmpleado, "Ingrese un nombre de usuario válido.");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void txtEmpleado_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();
            if (rdoAgregar.Checked)
            {
                if (txtEmpleado.Text!="")
                {
                    Empleados.Add(txtEmpleado.Text);
                    foreach (string emplead in Empleados)
                    {
                        lstLista.Items.Add(emplead);
                    }
                    txtEmpleado.Clear();
                    txtEmpleado.Focus();
                }
                else
                {
                    MessageBox.Show("Debe ingresar un nommbre de empleado para agregar...");
                    txtEmpleado.Focus();
                }
            }
            else if (rdoBuscar.Checked)
            {
                if (txtEmpleado.Text!="")
                {
                    foreach (string emplead in Empleados)
                    {
                        lstLista.Items.Add(emplead);
                        if (txtEmpleado.Text==emplead)
                        {
                            lstLista.SelectedItem = emplead;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Ese empleado no existe..."); 
                    txtEmpleado.Focus();
                }
            }
            else if (rdoInsertar.Checked)
            {
                if (txtEmpleado.Text != "")
                {
                    lstLista.Items.Insert(lstLista.SelectedIndex, txtEmpleado.Text);

                    Empleados.Insert(lstLista.SelectedIndex, txtEmpleado.Text);
                }
            }
        }


    }
}
