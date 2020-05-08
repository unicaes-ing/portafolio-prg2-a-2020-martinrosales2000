using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Vehiculo vehiculo;
        List<string> listaVehiculos = new List<string>();
        Archivo archivo = new Archivo("Vehiculos.dat");
        Dictionary<string, Vehiculo> Diccionario = new Dictionary<string, Vehiculo>();

        private void ActualizarGrid(ref DataGridView grid)
        {
            grid.Rows.Clear();
            foreach (Vehiculo vehiculo in Diccionario.Values)
            {
                dataGridView1.Rows.Add(vehiculo.Matricula, vehiculo.Marca, vehiculo.Modelo, vehiculo.Color, vehiculo.Año, vehiculo.Pasajeros);
            }
            dataGridView1.ClearSelection();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Diccionario = (Dictionary<string, Vehiculo>)archivo.LeerArchivo();
            //listaVehiculos = (List<Vehiculo>)archivo.LeerArchivo();
            if (Diccionario != null)
            {
                ActualizarGrid(ref dataGridView1);
            }
            else
            {
                Diccionario = new Dictionary<string, Vehiculo>();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            vehiculo = null;
            listaVehiculos = Diccionario.Select(Matriculas => Matriculas.Key).ToList();
            frmNuevo f3 = new frmNuevo(null, listaVehiculos);
            if (f3.ShowDialog() == DialogResult.OK)
            {
                if (f3.ShowDialog(this) == DialogResult.OK)
                {
                    vehiculo = f3.getVehiculo();
                    if (vehiculo != null)
                    {
                        Diccionario.Add(vehiculo.Matricula, vehiculo);
                        archivo.GuardarArchivo(Diccionario);
                        ActualizarGrid(ref dataGridView1);
                        MessageBox.Show("El nuevo vehículo fue almacenado", "Biblioteca",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
