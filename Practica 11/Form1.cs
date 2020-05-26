using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoCirculo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCirculo.Checked)
            {
                label2.Visible = true;
                txtValor1.Visible = true;
                label3.Visible = false;
                txtValor2.Visible = false;
                txtValor1.Focus();
                txtRespuesta.Clear();
            }
        }

        private void rdoCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCuadrado.Checked)
            {
                label2.Visible = true;
                txtValor1.Visible = true;
                label3.Visible = false;
                txtValor2.Visible = false;
                txtValor1.Focus();
                txtRespuesta.Clear();
            }
        }

        private void rdoTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTriangulo.Checked)
            {
                label2.Visible = true;
                txtValor1.Visible = true;
                label3.Visible = true;
                txtValor2.Visible = true;
                txtValor1.Focus();
                txtRespuesta.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtValor1.Visible = false;
            label3.Visible = false;
            txtValor2.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!rdoCirculo.Checked && !rdoCuadrado.Checked && !rdoTriangulo.Checked)
            {
                MessageBox.Show("Debe elegir una figura para poder continuar");
            }
            else if (rdoCirculo.Checked)
            {
                
                if (txtValor1.Text==string.Empty)
                {
                    MessageBox.Show("Debe ingresar un valor con el cual poder calcular");
                    txtValor1.Focus();
                }
                else
                {
                    
                    Circulo circulo= new Circulo();
                    circulo.Valor1 = Convert.ToDouble(txtValor1.Text);
                    txtRespuesta.Text=circulo.Area().ToString("N2");
                    txtValor1.Clear();


                }
            }
            else if (rdoCuadrado.Checked)
            {
                
                if (txtValor1.Text==string.Empty)
                {
                    MessageBox.Show("Debe ingresar un valor con el cual poder calcular");
                    txtValor1.Focus();
                }
                else
                {
                    
                    Cuadrado cuadrado = new Cuadrado();
                    cuadrado.Valor1= Convert.ToDouble(txtValor1.Text);
                    txtRespuesta.Text = cuadrado.Area().ToString("N2");
                    txtValor1.Clear();

                }
            }
            else
            {
                
                if (txtValor1.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el valor1 con el cual poder calcular");
                    txtValor1.Focus();
                }
                else if (txtValor2.Text==string.Empty)
                {
                    MessageBox.Show("Debe ingresar el valor2 con el cual poder calcular");
                    txtValor2.Focus();
                }
                else
                {
                    
                    Triangulo triangulo = new Triangulo();
                    triangulo.Valor1 = Convert.ToDouble(txtValor1.Text);
                    triangulo.Valor2= Convert.ToDouble(txtValor2.Text);
                    txtRespuesta.Text = triangulo.Area().ToString("N2");
                    txtValor1.Clear();
                    txtValor2.Clear();

                }
            }
        }

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)|| char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
