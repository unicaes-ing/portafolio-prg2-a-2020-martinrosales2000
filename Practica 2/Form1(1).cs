using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txtNumero.Text);
                string roman = "";
                if (n >= 1 && n <= 10)
                {
                    if (n == 1)
                    {
                        roman = "I";
                    }
                    else if (n == 2)
                    {
                        roman = "II";
                    }
                    else if (n == 3)
                    {
                        roman = "III";
                    }
                    else if (n == 4)
                    {
                        roman = "IV";
                    }
                    else if (n == 5)
                    {
                        roman = "V";
                    }
                    else if (n == 6)
                    {
                        roman = "VI";
                    }
                    else if (n == 7)
                    {
                        roman = "VII";
                    }
                    else if (n == 8)
                    {
                        roman = "VIII";
                    }
                    else if (n == 9)
                    {
                        roman = "IX";
                    }
                    else
                    {
                        roman = "x";
                    }
                    lblRomano.Text = "Equivale a: " + roman + " en romano.";
                }
                else
                {
                    txtNumero.Focus();
                    txtNumero.SelectAll();
                    lblRomano.Text = "ingrese un numero entre 1-10";
                }
            }
            catch (Exception)
            {
                txtNumero.Focus();
                txtNumero.SelectAll();
                lblRomano.Text = "ingrese solo numero";

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
