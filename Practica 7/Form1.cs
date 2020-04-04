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
using System.IO;

namespace Practica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Nombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{1,})(\s)?)*[^\s]$";
        string Correo = @"^\S[_a-zA-Z0-9-]+(.[_a-zA-Z0-9-]+)@\S[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{1,4})\S$";
        string Telelefono = @"^([2|6|7][0-9]{3})-([0-9]{4})$";

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtNombre.Text, Nombre))
            {
                errorProvider1.SetError(txtNombre, "El nombre debe iniciar con letra mayúscula...");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtCorreo.Text, Correo))
            {
                errorProvider1.SetError(txtCorreo, "Ingrese un correo valido...");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void mtxTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!Regex.IsMatch(mtxTelefono.Text, Telelefono))
            {
                errorProvider1.SetError(mtxTelefono, "El número debe iniciar con 2, 6 o 7...");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || !Regex.IsMatch(txtNombre.Text, Nombre))
            {
                MessageBox.Show("El nombre es un campo obligatorio...\nIngrese el nombre completo...");
                txtNombre.Focus();
            }
            else if (txtCorreo.Text == "" || !Regex.IsMatch(txtCorreo.Text, Correo)||txtCorreo.Text.Contains(";")|| txtCorreo.Text.Contains(":"))
            {
                MessageBox.Show("El correo es un campo obligatorio...\nIngrese el Correo compelto...");
                txtCorreo.Focus();
            }
            else if (mtxTelefono.Text == ""|| !Regex.IsMatch(mtxTelefono.Text, Telelefono)|| !mtxTelefono.MaskFull)
            {
                MessageBox.Show("El teléfono es un campo obligatorio...\nIngrese el teléfono completo...");
                mtxTelefono.Focus();
            }
            else
            {
                FileStream fs = null;
                BinaryWriter bw = null;
                try
                {
                    fs = new FileStream("Propietarios.dat", FileMode.Append, FileAccess.Write);
                    bw = new BinaryWriter(fs);
                    bw.Write(txtNombre.Text);
                    bw.Write(txtCorreo.Text);
                    bw.Write(mtxTelefono.Text);
                    MessageBox.Show("Los datos han sido almacenados correctamente...");
                    dataGridView1.Rows.Add(txtNombre.Text, txtCorreo.Text, mtxTelefono.Text);
                    dataGridView1.ClearSelection();
                    txtNombre.Clear();
                    txtCorreo.Clear();
                    mtxTelefono.Clear();
                    txtNombre.Focus();
                }
                catch (Exception)
                {

                    MessageBox.Show("Ingrese los datos correctamente...");
                }
                finally
                {
                    if (bw!=null)
                    {
                        bw.Close();
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Nombre, Correo, Telefono;
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                fs = new FileStream("Propietarios.dat", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                dataGridView1.Rows.Clear();
                while (true)
                {
                    Nombre = br.ReadString();
                    Correo = br.ReadString();
                    Telefono = br.ReadString();
                    dataGridView1.Rows.Add(Nombre,Correo,Telefono);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (br!=null)
                {
                    br.Close();
                    dataGridView1.ClearSelection();
                }
            }
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    
    }
}
