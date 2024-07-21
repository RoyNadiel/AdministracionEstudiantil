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
    public partial class QuintoReporte : Form
    {
        public QuintoReporte(DataGridView Materias)
        {
            InitializeComponent();            
            RecibirEstudiantes(Materias);
            MostrarPeriodosCBX(Materias, 3, cbxPeriodos);
        }
        private void RecibirEstudiantes(DataGridView dataGridView)
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
        private void MostrarPeriodosCBX(DataGridView dataGridView, int columnIndex, ComboBox comboBox)
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
        public void CalcularPromedios(DataGridView dataGridView1)
        {
            string periodo = cbxPeriodos.Text.ToUpper();

            // Suponiendo que el DataGridView se llama dataGridView1  
            Dictionary<string, (double sumaNotas, int contador)> materias = new Dictionary<string, (double sumaNotas, int contador)>();

            // Recorrer las filas del DataGridView  
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (!fila.IsNewRow)
                {
                    if (fila.Cells["PERIODO"].Value != null && fila.Cells["PERIODO"].Value.ToString() == periodo)
                    {
                        if (fila.Cells[0].Value != null && fila.Cells[4].Value != null)
                        {
                            string materia = fila.Cells[0].Value.ToString();
                            double nota = Convert.ToDouble(fila.Cells[4].Value);

                            // Si la materia ya está en el diccionario, actualizar la suma y el contador  
                            if (materias.ContainsKey(materia))
                            {
                                materias[materia] = (materias[materia].sumaNotas + nota, materias[materia].contador + 1);
                            }
                            else // Si no, agregarla al diccionario  
                            {
                                materias[materia] = (nota, 1);
                            }
                        }
                    }
                }
            }

            // Calcular el promedio y determinar la materia con el mayor promedio  
            string materiaConMayorPromedio = null;
            double mayorPromedio = 0;

            foreach (var entry in materias)
            {
                double promedio = entry.Value.sumaNotas / entry.Value.contador;

                // Comparar y encontrar la materia con el mayor promedio  
                if (promedio > mayorPromedio)
                {
                    mayorPromedio = promedio;
                    materiaConMayorPromedio = entry.Key;
                }
            }

            // Mostrar resultados  
            if (materiaConMayorPromedio != null)
            {
                MessageBox.Show($"La materia con el promedio más alto es: {materiaConMayorPromedio} con un promedio de {mayorPromedio:F2}");
            }
            else if (mayorPromedio == 0)
            {
                MessageBox.Show("Aun no se asignan notas.");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularPromedios(dgvNuevo);
        }

        private void cbxPeriodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPeriodos.Text != null)
            {
                btnCalcular.Enabled = true;
            }
        }
    }
}
