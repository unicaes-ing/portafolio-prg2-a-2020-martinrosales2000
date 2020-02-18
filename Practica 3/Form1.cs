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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNum.Text,out int n))
            {
                for (int i = 1; i <=10; i++)
                {
                    lstTabla.Items.Add(n + "*" + i + "=" + n * i);
                }
            }
            else
            {
                MessageBox.Show("ingrese numeros enteros positivos...");
            }
        }
    }
}
