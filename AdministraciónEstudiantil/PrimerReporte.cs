using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministraciónEstudiantil
{
    public partial class PrimerReporte : Form
    {
        Administracion ventana;
        DataGridView dgvEstudiantes;
        public PrimerReporte(DataGridView dataGridView)
        {            
            InitializeComponent();
            ventana = new Administracion();
            //dgvEstudiantes = dataGridView; ////LIST VIEW 

            RecibiraDGV(dataGridView);

            //for (int i
            //
            //= 0; i < 2; i++)
            //{
            //    string rowString = "";
            //    for (int j = 0; j < 8; j++)
            //    {
            //        rowString += dgvEstudiantes.Rows[i].Cells[j].Value.ToString() + " "; //// LIST VIEW
            //    }
            //    listView1.Items.Add(rowString);
            //}
        }
        private void RecibiraDGV(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                dgvNuevo.Columns.Add(col.Clone() as DataGridViewColumn);
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    newRow.Cells[i].Value = row.Cells[i].Value;
                }
                dgvNuevo.Rows.Add(newRow);
            }
        }
        private void PrimerReporte_FormClosing(object sender, FormClosingEventArgs e)
        {            
        }
    }
}
