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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int libro1, libro2, libro3, libro4, libro5, libro6;
            libro1 = 25;
            libro2 = 30;
            libro3 = 20;
            libro4 = 25;
            libro5 = 27;
            libro6 = 30;
            if (cboTitulo.SelectedItem.Equals("Codificadores en acción: Reflexiones sobre el arte de la programación."))
            {

                txtPrecio.Text = libro1.ToString();
            }
            else if(cboTitulo.SelectedItem.Equals("Código completo: Un manual práctico de construcción de software."))
            {
                txtPrecio.Text = libro2.ToString();
            }
            else if (cboTitulo.SelectedItem.Equals("El programador pragmático: De hombre de viaje a maestro."))
            {
                txtPrecio.Text = libro3.ToString();
            }
            else if (cboTitulo.SelectedItem.Equals("Código Limpio: Un Manual de Artesanía de Software Ágil."))
            {
                txtPrecio.Text = libro4.ToString();
            }
            else if (cboTitulo.SelectedItem.Equals("Programación de perlas."))
            {
                txtPrecio.Text = libro5.ToString();
            }
            else if (cboTitulo.SelectedItem.Equals("Rompiendo la Entrevista de Codificación: 150 Preguntas y soluciones sobre programación."))
            {
                txtPrecio.Text = libro6.ToString();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidad;
            double subtotal, impuesto, total_a_pagar;
            if (cboTitulo.SelectedItem.Equals("Codificadores en acción: Reflexiones sobre el arte de la programación."))
            {
                cantidad = Convert.ToInt32(txtCantidad.Text);
                subtotal = Convert.ToInt32(txtPrecio.Text) * cantidad;
                txtSubtotal.Text = subtotal.ToString();
                impuesto = (subtotal * 1.13) - subtotal;
                txtImpuesto.Text = impuesto.ToString();
                total_a_pagar = subtotal + impuesto;
                txtPagar.Text = total_a_pagar.ToString();
            }
            else if (cboTitulo.SelectedItem.Equals("Código completo: Un manual práctico de construcción de software."))
            {
                cantidad = Convert.ToInt32(txtCantidad.Text);
                subtotal = Convert.ToInt32(txtPrecio.Text) * cantidad;
                txtSubtotal.Text = subtotal.ToString();
                impuesto = (subtotal * 1.13) - subtotal;
                txtImpuesto.Text = impuesto.ToString();
                total_a_pagar = subtotal + impuesto;
                txtPagar.Text = total_a_pagar.ToString();
            }
            else if (cboTitulo.SelectedItem.Equals("El programador pragmático: De hombre de viaje a maestro."))
            {
                cantidad = Convert.ToInt32(txtCantidad.Text);
                subtotal = Convert.ToInt32(txtPrecio.Text) * cantidad;
                txtSubtotal.Text = subtotal.ToString();
                impuesto = (subtotal * 1.13) - subtotal;
                txtImpuesto.Text = impuesto.ToString();
                total_a_pagar = subtotal + impuesto;
                txtPagar.Text = total_a_pagar.ToString();
            }
            else if (cboTitulo.SelectedItem.Equals("Código Limpio: Un Manual de Artesanía de Software Ágil."))
            {
                cantidad = Convert.ToInt32(txtCantidad.Text);
                subtotal = Convert.ToInt32(txtPrecio.Text) * cantidad;
                txtSubtotal.Text = subtotal.ToString();
                impuesto = (subtotal * 1.13) - subtotal;
                txtImpuesto.Text = impuesto.ToString();
                total_a_pagar = subtotal + impuesto;
                txtPagar.Text = total_a_pagar.ToString();
            }
            else if (cboTitulo.SelectedItem.Equals("Programación de perlas."))
            {
                cantidad = Convert.ToInt32(txtCantidad.Text);
                subtotal = Convert.ToInt32(txtPrecio.Text) * cantidad;
                txtSubtotal.Text = subtotal.ToString();
                impuesto = (subtotal * 1.13) - subtotal;
                txtImpuesto.Text = impuesto.ToString();
                total_a_pagar = subtotal + impuesto;
                txtPagar.Text = total_a_pagar.ToString();
            }
            else if (cboTitulo.SelectedItem.Equals("Rompiendo la Entrevista de Codificación: 150 Preguntas y soluciones sobre programación."))
            {
                cantidad = Convert.ToInt32(txtCantidad.Text);
                subtotal = Convert.ToInt32(txtPrecio.Text) * cantidad;
                txtSubtotal.Text = subtotal.ToString();
                impuesto = (subtotal * 1.13) - subtotal;
                txtImpuesto.Text = impuesto.ToString();
                total_a_pagar = subtotal + impuesto;
                txtPagar.Text = total_a_pagar.ToString();
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtImpuesto.Clear();
            txtPagar.Clear();
            txtPrecio.Clear();
            txtSubtotal.Clear();
        }
    }
}
