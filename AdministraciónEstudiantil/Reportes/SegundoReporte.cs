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
    public partial class SegundoReporte : Form
    {
        DataGridView dgvMateria = new DataGridView();
        public SegundoReporte(DataGridView dgvEstudiantes, DataGridView dgvMaterias)
        {
            InitializeComponent();
            RecibirEstudiantes(dgvEstudiantes);
            RecibirMaterias(dgvMaterias);
            MostrarPeriodosCBX(dgvEstudiantes, 4, cbxPeriodos);
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
        private void RecibirMaterias(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                dgvMateria.Columns.Add(col.Clone() as DataGridViewColumn);
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    newRow.Cells[i].Value = row.Cells[i].Value;
                }
                dgvMateria.Rows.Add(newRow);
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            List<string> listaDevuelta = ObtenerMateriasMasRepetidas(dgvNuevo);

            if (listaDevuelta != null)
            {
                string[] materias = new string[listaDevuelta.Count];
                int contador = 0;
                foreach (string materia in listaDevuelta)
                {
                    if (materia != null)
                    {
                        materias[contador] = materia;
                        contador++;
                    }
                }
                MiniSR ventana = new MiniSR(materias, conteoMaterias);
                ventana.Show();
            }
        }
        Dictionary<string, int> conteoMaterias = new Dictionary<string, int>();
        public List<string> ObtenerMateriasMasRepetidas(DataGridView dataGridView)
        {
            string periodo = "";
            conteoMaterias.Clear();

            // Calcular conteo de materias por período  
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (cbxPeriodos.Text != null)
                {
                    periodo = cbxPeriodos.Text.ToUpper();
                    if (row.Cells[4].Value != null && row.Cells[4].Value.ToString() == periodo)
                    {
                        string nombreMateria = row.Cells[5].Value.ToString();

                        if (conteoMaterias.ContainsKey(nombreMateria))
                        {
                            conteoMaterias[nombreMateria]++;
                        }
                        else
                        {
                            conteoMaterias.Add(nombreMateria, 1);
                        }
                    } 
                }
                else
                {
                    MessageBox.Show("Seleccione el periodo en cuestion.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
            }
            // Obtener la cantidad máxima de repeticiones
            int maxRepeticiones = conteoMaterias.Max(x => x.Value);


            // Obtener la materia más repetida  
            string materiaMasRepetida = conteoMaterias.FirstOrDefault(x => x.Value == maxRepeticiones).Key;

            if (conteoMaterias.Select(x => x.Value).Distinct().Count() == 1)
            {
                // Mostrar mensaje en el ComboBox  
                MessageBox.Show($"Existe la misma cantidad de estudiantes en las materias del periodo {periodo}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            // Comprobar si hay una materia que se repite más que las demás
            else if (conteoMaterias.Count(x => x.Value == maxRepeticiones) > 1)
            {
                // Si hay materias con la misma cantidad máxima de repeticiones, devolverlas  
                List<string> materiasMasRepetidas = conteoMaterias.Where(x => x.Value == maxRepeticiones)
                                                                   .Select(x => x.Key)
                                                                   .ToList();
                return materiasMasRepetidas;
            }
            else
            {
                // Si hay una materia que se repite más que las demás, devolverla  
                List<string> materiasMasRepetidas = new List<string>();
                materiasMasRepetidas.Add(materiaMasRepetida);

                return materiasMasRepetidas;
            }
        }

        private void cbxPeriodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPeriodos.SelectedItem != null)
            {
                btnCalcular.Enabled = true;
            }
        }
    }
}
