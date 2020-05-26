using System;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static int fibonacci(int n)
        {
            if (n < 2)
            
                return n;
            
            else
            
                return fibonacci(n - 1) + fibonacci(n - 2);
            
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumero.Text);
            int fibonac = fibonacci(num);
            txtFibonacci.Text = string.Format("{0}",fibonac);
        }
    }
}
