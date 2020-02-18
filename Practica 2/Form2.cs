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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoDescuento1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total, descuento, subtotal;
            if (rdoDescuento1.Checked)
            {
                subtotal = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                descuento = subtotal * 0.00;
                txtDescuento.Text = descuento.ToString();
                total = subtotal - descuento;
                txtTotal.Text = total.ToString();
            }
            else if (rdoDescuento2.Checked)
            {
                subtotal = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                descuento = subtotal * 0.05;
                txtDescuento.Text = descuento.ToString();
                total = subtotal - descuento;
                txtTotal.Text = total.ToString();
            }
            else if (rdoDescuento3.Checked)
            {
                subtotal = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                descuento = subtotal * 0.10;
                txtDescuento.Text = descuento.ToString();
                total = subtotal - descuento;
                txtTotal.Text = total.ToString();
            }
            else if (rdoDescuento4.Checked)
            {
                subtotal = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                descuento = subtotal * 0.15;
                txtDescuento.Text = descuento.ToString();
                total = subtotal - descuento;
                txtTotal.Text = total.ToString();
            }
            else if (rdoDescuento5.Checked)
            {
                subtotal = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                descuento = subtotal * 0.20;
                txtDescuento.Text = descuento.ToString();
                total = subtotal - descuento;
                txtTotal.Text = total.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtDescuento.Clear();
            txtTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
