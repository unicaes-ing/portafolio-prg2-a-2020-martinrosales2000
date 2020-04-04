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
using System.Runtime.Serialization.Formatters.Binary;


namespace Practica_7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        [Serializable]

        public struct RegistroMascotas
        {
            public string Codigo;
            public string Nombre;
            public string Propietario;
            public string Especie;
            public string FechaNaciemiento;
            public Double Peso;
            public string Sexo;
        }

        Dictionary<string, RegistroMascotas> Registro = new Dictionary<string, RegistroMascotas>();
        RegistroMascotas Mascota = new RegistroMascotas();


        BinaryFormatter formatter = new BinaryFormatter();
        const string NOMBRE_ARCHIVO = "Mascotas.dat";

        string Nombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{1,})(\s)?)*[^\s]$";

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && !txtPeso.Text.Contains("."))
            {
                e.Handled = false;
            }
        }

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

        private void Form2_Load(object sender, EventArgs e)
        {
            string Nombre, Correo, Telefono;
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                fs = new FileStream("Propietarios.dat", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                cboDueño.Items.Clear();
                while (true)
                {
                    Nombre = br.ReadString();
                    Correo = br.ReadString();
                    Telefono = br.ReadString();
                    cboDueño.Items.Add(Nombre);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (br != null)
                {
                    br.Close();
                }
            }

            if (File.Exists(NOMBRE_ARCHIVO))
            {
                try
                {
                    FileStream ReaderFS = new FileStream(NOMBRE_ARCHIVO, FileMode.Open, FileAccess.Read);
                    Registro = (Dictionary<string, RegistroMascotas>)formatter.Deserialize(ReaderFS);
                    ReaderFS.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("No fue posible leer el archivo...");
                }
                if (Registro.Count > 0)
                {
                    dgvMascotas.Rows.Clear();

                    foreach (RegistroMascotas Mascota in Registro.Values)
                    {
                        dgvMascotas.Rows.Add(Mascota.Codigo, Mascota.Nombre, Mascota.Propietario, Mascota.Especie, Mascota.FechaNaciemiento, Mascota.Peso, Mascota.Sexo);
                    }
                    dgvMascotas.ClearSelection();
                }
                else
                {
                    MessageBox.Show("No Existen datos almacenados en el archivo...");
                }

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (mtxCodigo.Text.Equals("") || !mtxCodigo.MaskFull)
            {
                MessageBox.Show("El Codigo es un campo obligatorio...\nIngrese el Codigo de su mascota...");
                mtxCodigo.Focus();
            }
            else if (txtNombre.Text == "" || !Regex.IsMatch(txtNombre.Text, Nombre))
            {
                MessageBox.Show("El nombre es un campo obligatorio...\nIngrese el nombre de su mascota...");
                txtNombre.Focus();
            }
            else if (cboDueño.SelectedIndex == -1)
            {
                MessageBox.Show("El nombre del propietario es un campo obligatorio...\nElija un nombre de la lista de Propietarios...");
            }
            else if (cboEspecie.SelectedIndex == -1)
            {
                MessageBox.Show("La especie es un campo obligatorio...\nElija la especie de su mascota en la lista de especies....");
            }
            else if (txtPeso.Text == "" || txtPeso.Text.StartsWith("."))
            {
                MessageBox.Show("El peso es un campo obligatorio...\nIngrese el peso de su mascota...");
                txtPeso.Focus();
            }
            else
            {


                Mascota.Codigo = mtxCodigo.Text;
                Mascota.Nombre = txtNombre.Text;
                Mascota.Propietario = cboDueño.Text;
                Mascota.Especie = cboEspecie.Text;
                Mascota.FechaNaciemiento = dtpFechanac.Text;
                Mascota.Peso = Convert.ToDouble(txtPeso.Text);
                if (rdoHembra.Checked)
                {
                    Mascota.Sexo = rdoHembra.Text;
                }
                else
                {
                    Mascota.Sexo = rdoMacho.Text;
                }
                if (Registro.ContainsKey(mtxCodigo.Text))
                {
                    MessageBox.Show("El codigo de mascota ya existe...\nIngrese un codigo nuevo...");
                    mtxCodigo.Focus();
                }
                else
                {
                    Registro.Add(Mascota.Codigo, Mascota);

                    try
                    {
                        FileStream writerFs = new FileStream(NOMBRE_ARCHIVO, FileMode.Create, FileAccess.Write);
                        formatter.Serialize(writerFs, Registro);
                        writerFs.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No fue posible almacenar los datos...");
                    }
                    MessageBox.Show("Los datos han sido almacenados correctamente...");
                    dgvMascotas.Rows.Add(Mascota.Codigo, Mascota.Nombre, Mascota.Propietario, Mascota.Especie, Mascota.FechaNaciemiento, Mascota.Peso, Mascota.Sexo);
                    mtxCodigo.Clear();
                    txtNombre.Clear();
                    cboDueño.SelectedIndex = -1;
                    cboEspecie.SelectedIndex = -1;
                    txtPeso.Clear();

                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
