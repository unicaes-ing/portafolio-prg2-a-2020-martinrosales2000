using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double I1, I2, I3, Total,inv1, inv2, inv3;
            I1 = Convert.ToDouble(txtInvercionista1.Text);
            I2 = Convert.ToDouble(txtInvercionista2.Text);
            I3 = Convert.ToDouble(txtInvercionista3.Text);
            Total = (I1 + I2 + I3);
            inv1 = (I1 / Total)*100.0;
            inv2 = (I2 / Total) * 100.0;
            inv3 = (I3 / Total) * 100.0;
            txtTotal.Text = Total.ToString();
            txtPorcentaje1.Text = inv1.ToString();
            txtPorcentaje2.Text = inv2.ToString();
            txtPorcentaje3.Text = inv3.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInvercionista1.Clear();
            txtInvercionista2.Clear();
            txtInvercionista3.Clear();
            txtPorcentaje1.Clear();
            txtPorcentaje2.Clear();
            txtPorcentaje3.Clear();
            txtTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
