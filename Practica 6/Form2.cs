using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Practica_6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Dictionary<string, string> Registro = new Dictionary<string, string>();
        string patronTel = @"^([2|6|7][0-9]{3})-([0-9]{4})$";
        string patronNombre2 = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{2,})(\s)?)*[^\s]$";

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtTelefono.Text, patronTel))
            {
                errorProvider1.SetError(txtTelefono,"Ingrese un número de telefono valido...\nEl numero debe iniciar con(2-6-7)");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text==""|| !Regex.IsMatch(txtNombre.Text, patronNombre2))
            {
                MessageBox.Show("El nombre es un campo obligatorio...\nIngrese el nombre...");
                txtNombre.Focus();
            }
            else if (txtTelefono.Text==""|| !Regex.IsMatch(txtTelefono.Text, patronTel))
            {
                MessageBox.Show("Ingrese un número de telefono valido...\nEl numero debe iniciar con(2-6-7)");
                txtTelefono.Focus();
            }
            else if (Registro.ContainsKey(txtTelefono.Text))
            {
                MessageBox.Show("Este número telefonico ya existe en el registo, no pueden existir dos números iguales...\nIngrese un numero nuevo...");
            }
            else
            {
                Registro.Add(txtTelefono.Text,txtNombre.Text);
                ListViewItem lista = new ListViewItem(txtTelefono.Text);
                lista.SubItems.Add(txtNombre.Text);
                lvwClientes.Items.Add(lista);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtTelefono.Text=="")
            {
                MessageBox.Show("Debe ingresar un número telefonico para realizar la busqueda...");
            }
            else
            {
                if (txtTelefono.TextLength > 0)
                {
                    if (!Registro.ContainsKey(txtTelefono.Text))
                    {
                        MessageBox.Show("El número que desea agregar no exite...");
                        txtNombre.Clear();
                        txtTelefono.Focus();
                        txtTelefono.SelectAll();
                    }
                    else
                    {
                        MessageBox.Show("El cliente al que pertenece el número es: " +Registro[txtTelefono.Text]);
                        
                    }
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (Registro.Count==0)
            {
                MessageBox.Show("No se puede realizar la operación...\nNo existen datos para eliminar...");
            }
            else if (lvwClientes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un elemento para eliminar...");
            }
            else
            {
                Registro.Remove(txtTelefono.Text);
                foreach (ListViewItem lista in lvwClientes.SelectedItems)
                {
                    lista.Remove();

                }
            }
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
