using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            Random M = new Random();
            const int cant = 5000;
            int numeros = 0, n = 0;
            lstDado.Items.Clear();
            for (int i = 1; i <=5000; i++)
            {
                numeros = M.Next(1, 7);
                if (numeros == 6) n++;
                lstDado.Items.Add(numeros);
            }
            MessageBox.Show("la cantidad de veces que en los lanzamientos se obtubo 6 es: " + n);
        }
    }
}
