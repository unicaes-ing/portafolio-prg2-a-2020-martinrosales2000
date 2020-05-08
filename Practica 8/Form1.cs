using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Practica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string PatronNombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{1,})(\s)?)*[^\s]$";
        Mascota NuevaMascota = new Mascota();
        string NombreM, TipoM, SexoM;
        int EdadM;

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)||char.IsWhiteSpace(e.KeyChar)||char.IsPunctuation(e.KeyChar)||char.IsSeparator(e.KeyChar)||char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (txtNombre.Text=="")
            {
                MessageBox.Show("El nombre de la mascota es un campo obligatorio");
                txtNombre.Focus();
            }
            else if (!Regex.IsMatch(txtNombre.Text, PatronNombre))
            {
                MessageBox.Show("Debe ingresar un nombre valido");
                txtNombre.SelectAll();
                txtNombre.Focus();
            }
            else if (cboTipo.SelectedIndex==-1)
            {
                MessageBox.Show("El tipo de mascota es un campo obligatorio\nElija una opcion de tipo de mascota para continuar");
            }
            else if (txtEdad.Text=="")
            {
                MessageBox.Show("La edad es un campo obligatorio");
                txtEdad.Focus();
            }
            else if (Convert.ToInt32(txtEdad.Text)==0)
            {
                MessageBox.Show("La edad de la mascota no puede ser igual a 0");
                txtEdad.SelectAll();
                txtEdad.Focus();
            }
            else
            {

                NuevaMascota.setNombre(txtNombre.Text);
                NuevaMascota.setTipo(cboTipo.Text) ;
                if (rdoMacho.Checked)
                {
                    NuevaMascota.setSexo (rdoMacho.Text);
                }
                else
                {
                    NuevaMascota.setSexo (rdoHembra.Text);
                }
                NuevaMascota.setEdad( Convert.ToInt32(txtEdad.Text));
                NombreM = NuevaMascota.getNombre();
                TipoM = NuevaMascota.getTipo();
                SexoM = NuevaMascota.getSexo();
                EdadM = NuevaMascota.getEdad();
                dataGridView1.Rows.Add(NombreM,TipoM, SexoM,EdadM);
                MessageBox.Show("Los datos han sido agregados de forma correcta");
                txtNombre.Clear();
                cboTipo.SelectedIndex = -1;
                txtEdad.Clear();
                rdoMacho.Checked = true;
            }
        }
    }
}
