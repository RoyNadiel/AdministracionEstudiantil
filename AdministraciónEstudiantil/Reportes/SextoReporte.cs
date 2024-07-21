using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministraciónEstudiantil.Reportes
{
    public partial class SextoReporte : Form
    {
        public SextoReporte(DataGridView Estudiantes)
        {
            InitializeComponent();
            List<string> columnasAConservar = new List<string> { "CEDULAGEST", "NOMBREGEST", "NOTAGEST" };
            CopiarFilasConColumnasEspecificas(Estudiantes, dgvNuevo, columnasAConservar);
            MostrarCedulasCBX(dgvNuevo, 0, cbxCedula);
        }

        private void CopiarFilasConColumnasEspecificas(DataGridView source, DataGridView destination, List<string> columnasAConservar)
        { 
            destination.Rows.Clear();

            // Iterar sobre cada fila en el DataGridView de origen  
            foreach (DataGridViewRow fila in source.Rows)
            {
                if (fila.IsNewRow) continue; // Ignorar las filas nuevas  

                // Crear una nueva fila en el DataGridView de destino  
                int newRowIndex = destination.Rows.Add();

                // Iterar sobre las columnas especificadas para conservar  
                foreach (string columna in columnasAConservar)
                {
                    // Verificar si la columna existe en el DataGridView de origen  
                    if (source.Columns.Contains(columna))
                    {
                        // Copiar el valor a la nueva fila usando Cells  
                        destination.Rows[newRowIndex].Cells[columna].Value = fila.Cells[columna].Value;
                    }
                }
            }
        }
        private void MostrarCedulasCBX(DataGridView dataGridView, int columnIndex, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            HashSet<string> itemsSet = new HashSet<string>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow && row.Cells[columnIndex].Value != null)
                {
                    string item = row.Cells[columnIndex].Value.ToString();
                    if (!itemsSet.Contains(item))
                    {
                        comboBox.Items.Add(item);
                        itemsSet.Add(item);
                    }
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularNotaEstudiante(cbxCedula.Text);
        }
        private void CalcularNotaEstudiante(string cedula)
        {
            double nota = 0;
            int contador = 0;
            string nombre = string.Empty;
            foreach (DataGridViewRow row in dgvNuevo.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[2].Value != null)
                {
                    if (row.Cells[0].Value.ToString() == cedula)
                    {
                        nombre = row.Cells[1].Value.ToString();
                        double notas = Convert.ToDouble(row.Cells[2].Value);
                        nota += notas;
                        contador++;
                    }
                }
            }
            double notaFinal = nota / contador;

            MessageBox.Show($"Promedio del estudiante {nombre}: {notaFinal:F2} PTS", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cbxCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCedula.Text != null)
            {
                btnCalcular.Enabled = true;
            }
        }
    }
}
