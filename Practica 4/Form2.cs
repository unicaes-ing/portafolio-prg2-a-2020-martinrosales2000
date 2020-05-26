using System;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAgregar.Text, out int numero) || numero<=0)
            {
                lstNumeros.Items.Add(numero);
                txtAgregar.Clear();
                txtAgregar.Focus();
            }
            else
            {
                MessageBox.Show("Agregue numeros validos...");
            }
        }
        public static int buscar(int buscarnum, ListBox lista)
        {
            int contador = 0;
            foreach (int n in lista.Items)
            {
                if (n == buscarnum) contador++;
                
            }
            return contador;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(txtNumBuscar.Text);
                int cant = buscar(numero, lstNumeros);
                MessageBox.Show("el numero " + txtNumBuscar.Text + " se encuentra "  + cant + " veces ");
            }
            catch (Exception)
            {

                MessageBox.Show("ingrese in numero a buscar...");
                txtNumBuscar.Clear();
                txtNumBuscar.Focus();
            }
        }
    }
}
