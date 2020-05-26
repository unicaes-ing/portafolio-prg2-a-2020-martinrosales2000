using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Archivo archivo = new Archivo("Vehiculos.dat");
        Vehiculo vehiculo = new Vehiculo();
        List<string> listaVehiculos;
        Dictionary<string, Vehiculo> diccionarioVehiculo = new Dictionary<string, Vehiculo>();
        private void ActualizarGrid(ref DataGridView grid)
        {
            grid.Rows.Clear();
            foreach (Vehiculo vehiculo in diccionarioVehiculo.Values)
            {
                grid.Rows.Add(vehiculo.Matricula, vehiculo.Marca, vehiculo.Modelo, vehiculo.Color, vehiculo.Year, vehiculo.NumPasajeros, "Eliminar");
            }
            grid.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            vehiculo = null;
            listaVehiculos = diccionarioVehiculo.Select(Matriculas => Matriculas.Key).ToList();
            Form3 f3 = new Form3(null, listaVehiculos);
            if (f3.ShowDialog() == DialogResult.OK)
            {
                Vehiculo vehiculo = f3.getVehiculo();
                if (vehiculo != null)
                {
                    if (!diccionarioVehiculo.ContainsKey(vehiculo.Matricula))
                    {
                        diccionarioVehiculo.Add(vehiculo.Matricula, vehiculo);
                        archivo.GuardarArchivo(diccionarioVehiculo);

                        ActualizarGrid(ref dataGridView1);
                        MessageBox.Show("El nuevo vehículo fue almacenado");
                    }
                    else
                    {
                        MessageBox.Show("Esta matrícula ya fue almacenada.");
                    }

                }
            }
            f3.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string matricula = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este vehículo?", "Vehículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    diccionarioVehiculo.Remove(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    archivo.GuardarArchivo(diccionarioVehiculo);
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    dataGridView1.ClearSelection();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            diccionarioVehiculo = (Dictionary<string, Vehiculo>)archivo.LeerArchivo();
            if (diccionarioVehiculo != null)
            {
                ActualizarGrid(ref dataGridView1);
            }
            else
            {
                diccionarioVehiculo = new Dictionary<string, Vehiculo>();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("Debe ingresar los datos de almenos un vehiculo para imprimir");
            }
            else
            {
                try
                {
                    rvVehiculo reporte = new rvVehiculo();
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        Vehiculo vehiculo = new Vehiculo
                        {
                            Matricula = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                            Marca = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                            Modelo = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                            Color = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                            Year= Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value),
                            NumPasajeros= Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value)
                        };
                        reporte.listaVehiculo.Add(vehiculo);
                    }

                    reporte.ShowDialog(this);
                }
                catch (Exception)
                {
                    MessageBox.Show("Existe un problema con el reporte de Vehiculo", "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
