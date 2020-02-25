using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int sum(int n1=0, int n2=0, int n3=0, int n4=0)
        {
            return n1 + n2 + n3 + n4;
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNum1.Text, out int num1) && int.TryParse(txtNum2.Text, out int num2) && int.TryParse(txtNum3.Text, out int num3) && int.TryParse(txtNum4.Text, out int num4))
            {
                lblSuma.Text = (sum(num1, num2, num3, num4)).ToString();
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum3.Clear();
                txtNum4.Clear();
            }
            else
            {
                MessageBox.Show("ingrese numeros validos...");

            }
        }
    }
}
