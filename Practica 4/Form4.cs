using System;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static int Factorial(int n1, int n2, int n3)
        {
            int numero1, numero2, numero3;
            numero1 = n1;
            numero2 = n2;
            numero3 = n3;
            if (numero1 > numero2 && numero1 > numero3)
            {
                return numero1;
            }
            else if (numero2>numero1&&numero2>numero3)
            {
                return numero2;
            }
            else
            {
                return numero3;
            }
        }
        private void btnMayor_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, mayor;
            n1 = Convert.ToInt32(txtNum1.Text);
            n2 = Convert.ToInt32(txtNum2.Text);
            n3 = Convert.ToInt32(txtNum3.Text);
            mayor = Factorial(n1,n2,n3);
            lblMayor.Text = string.Format("{0}", mayor);
        }
    }
}
