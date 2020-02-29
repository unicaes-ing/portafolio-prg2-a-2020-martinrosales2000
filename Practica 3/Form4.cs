using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(210,220);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.ColumnCount = 10;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Random n = new Random();
            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    dataGridView1.Rows[f].Cells[c].Value = n.Next(10, 100);
                   
                }
               
            }
            dataGridView1.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
