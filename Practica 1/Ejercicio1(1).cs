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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double E1, E2, E3, promedio;
            E1 = Convert.ToDouble(txtExamen1.Text);
            E2 = Convert.ToDouble(txtExamen2.Text);
            E3 = Convert.ToDouble(txtExamen3.Text);
            promedio = (E1 + E2 + E3) / 3.0;
            txtPromedio.Text = promedio.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtExamen1.Text = "" ;
            txtExamen2.Text = "";
            txtExamen3.Text = "";
            txtPromedio.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
