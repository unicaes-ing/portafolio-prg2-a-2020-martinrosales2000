using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Practica_9
{
    public partial class rvVehiculo : Form
    {
        public rvVehiculo()
        {
            InitializeComponent();
        }

        private void rvVehiculo_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        public List<Vehiculo> listaVehiculo = new List<Vehiculo>();
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DisplayName = "Reporte de Vehiculo";
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", listaVehiculo));
            this.reportViewer1.RefreshReport();
        }
    }
}
