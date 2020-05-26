using System;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double cantidad = 00;
            try
            {
                if (lbsDe.SelectedItem.Equals("Pulgadas") && lbsA.SelectedItem.Equals("Pies"))
                {
                    cantidad = Convert.ToDouble(txtCant.Text) / 12;
                    txtLongF.Text = cantidad.ToString("N2");
                }
                else if (lbsDe.SelectedItem.Equals("Pulgadas") && lbsA.SelectedItem.Equals("Yardas"))
                {
                    cantidad = Convert.ToDouble(txtCant.Text) / 36;
                    txtLongF.Text = cantidad.ToString("N2");
                }
                else if (lbsDe.SelectedItem.Equals("Pies") && lbsA.SelectedItem.Equals("Pulgadas"))
                {
                    cantidad = Convert.ToDouble(txtCant.Text) * 12;
                    txtLongF.Text = cantidad.ToString("N2");
                }
                else if (lbsDe.SelectedItem.Equals("Pies") && lbsA.SelectedItem.Equals("Yardas"))
                {
                    cantidad = Convert.ToDouble(txtCant.Text) / 3;
                    txtLongF.Text = cantidad.ToString("N2");
                }
                else if (lbsDe.SelectedItem.Equals("Yardas") && lbsA.SelectedItem.Equals("Pulgadas"))
                {
                    cantidad = Convert.ToDouble(txtCant.Text) * 36;
                    txtLongF.Text = cantidad.ToString("N2");
                }
                else if (lbsDe.SelectedItem.Equals("Yardas") && lbsA.SelectedItem.Equals("Pies"))
                {
                    cantidad = Convert.ToDouble(txtCant.Text) * 3;
                    txtLongF.Text = cantidad.ToString("N2");
                }
                else
                {
                    MessageBox.Show("asegurese de no hacer converciones de unidades de madidas similares...");
                }
            }
            catch (Exception)
            {
                
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
