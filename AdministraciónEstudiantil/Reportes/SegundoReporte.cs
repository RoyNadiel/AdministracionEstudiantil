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
        private void CalcularMateriaConMasEstudiantes()
        {
            int materia1 = 0;
            int materia2 = 0;
            int materia3 = 0;
            string periodo = cbxPeriodos.Text.ToUpper();            
            string[] Materias = new string[3];

            for (int x = 0; x < dgvMateria.RowCount; x++)
            {
                if (dgvMateria.Rows[x].Cells[1].Value != null)
                {
                    Materias[x] = dgvMateria.Rows[x].Cells[1].Value.ToString();
                }
            }
            foreach (DataGridViewRow row in dgvNuevo.Rows)
            {
                if (periodo != "")
                {
                    if (row.Cells[4].Value != null && row.Cells[4].Value.ToString() == periodo)
                    {
                        if (row.Cells[5].Value != null)
                        {
                            if (row.Cells[5].Value.ToString() == Materias[0])
                            {
                                materia1++;
                            }
                            if (row.Cells[5].Value.ToString() == Materias[1])
                            {
                                materia2++;
                            }
                            if (row.Cells[5].Value.ToString() == Materias[2])
                            {
                                materia3++;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el periodo de busqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;                    
                }
            }            

            if (materia1 > 0 && materia2 > 0)
            {
                if (materia1 == materia2)
                {
                    MessageBox.Show($"Existe la misma cantidad estudiantes ({materia1}) en las materias del periodo {periodo}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (materia1 > materia2)
                    {
                        MessageBox.Show($"La materia {Materias[0]} en el periodo {periodo} es la materia con mas estudiantes", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"La materia {Materias[1]} en el periodo {periodo} es la materia con mas estudiantes", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (materia1 > 0 && materia3 > 0)
            {
                if (materia1 == materia3)
                {
                    MessageBox.Show($"Existe la misma cantidad estudiantes ({materia1}) en las materias del periodo {periodo}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (materia1 > materia3)
                    {
                        MessageBox.Show($"La materia {Materias[0]} en el periodo {periodo} es la materia con mas estudiantes", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"La materia {Materias[2]} en el periodo {periodo} es la materia con mas estudiantes", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (materia2 > 0 && materia3 > 0)
            {
                if (materia2 == materia3)
                {
                    MessageBox.Show($"Existe la misma cantidad estudiantes ({materia2}) en las materias del periodo {periodo}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (materia2 > materia3)
                    {
                        MessageBox.Show($"La materia {Materias[1]} en el periodo {periodo} es la materia con mas estudiantes", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"La materia {Materias[3]} en el periodo {periodo} es la materia con mas estudiantes", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Solo existe una materia en este periodo", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularMateriaConMasEstudiantes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgvMateria.Rows[1].Cells[1].Value.ToString());                
        }
    }
}
