using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Segundo_Periodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] vendedores = { "Jorge", "María", "Daniel", "Pedro", "José", "Lucila", "Juana", "Francisca", "Ivan", "Sofia " };
        private void Form1_Load(object sender, EventArgs e)
        {
            lstVendedores.Items.Clear();
            lstVendedores.DataSource=vendedores;

        }

        private void btnOrdenar1_Click(object sender, EventArgs e)
        {
            lstVendedores.DataSource = null;
            Array.Sort(vendedores);
            lstVendedores.DataSource = vendedores;
        }

        private void btnOrdenar2_Click(object sender, EventArgs e)
        {
            lstVendedores.DataSource = null;
            Array.Sort(vendedores);
            Array.Reverse(vendedores);
            lstVendedores.DataSource = vendedores;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            string[] temporal = new string[vendedores.Length];
            //int n = 0;
            //for (int i = 0; i < vendedores.Length; i++)
            //{
            //    if (i != lstVendedores.SelectedIndex)
            //    {
            //        temporal[n] = vendedores[i];
            //        n++;
            //    }
            //}
            //vendedores = temporal;
            //lstVendedores.DataSource = vendedores;
            if (lstVendedores.SelectedIndex>=0)
            {
                List<string> lista = new List<string>(vendedores);
                lista.RemoveAt(lstVendedores.SelectedIndex);
                vendedores = lista.ToArray();
                lstVendedores.DataSource = vendedores;
            }
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.TextLength>0)
            {
                int i = Array.IndexOf(vendedores,txtNombre.Text);
                if (i >= 0)
                {
                    lstVendedores.SelectedIndex = i;
                }
                else
                {
                    MessageBox.Show("El nombre " + txtNombre.Text + " no esta en la lista....");
                }
            }
            else
            {
                MessageBox.Show("Escriba el nombre a buscar");
                txtNombre.Focus();
            }
        }
    }
    }
