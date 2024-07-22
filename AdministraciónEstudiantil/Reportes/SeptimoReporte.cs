using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdministraciónEstudiantil.Reportes
{
    public partial class SeptimoReporte : Form
    {
        public SeptimoReporte(DataGridView Estudiantes)
        {
            InitializeComponent();
            RecibirEstudiantes(Estudiantes);
            MostrarPeriodosCBX(dgvNuevo, 4, cbxPeriodos);
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
        private void DepartamentoConMasEstudiantes(string periodo)
        {
            Dictionary<string, int> departamentos = new Dictionary<string, int>();

            foreach (DataGridViewRow row in dgvNuevo.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[6].Value != null && row.Cells[4].Value != null)
                    {
                        if (row.Cells[4].Value.ToString() == periodo)
                        {
                            string depart = row.Cells[6].Value.ToString();

                            if (departamentos.ContainsKey(depart))
                            {
                                departamentos[depart] += 1;
                            }
                            else
                            {
                                departamentos.Add(depart, +1);
                            }
                        }
                    }
                }
            }

            string mayorDep = string.Empty;

            int mayor = 0;
            foreach (KeyValuePair<string, int> valor in departamentos)
            {
                if (valor.Value > mayor)
                {
                    mayor = valor.Value;
                    mayorDep = valor.Key;
                }
                else if (valor.Value == mayor)
                {
                    MessageBox.Show($"Los departamentos tienen la misma cantidad de estudiantes", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            MessageBox.Show($"El departamento con mas estudiantes es {mayorDep}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbxPeriodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPeriodos.Text != null)
            {
                btnCalcular.Enabled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DepartamentoConMasEstudiantes(cbxPeriodos.Text);
        }
    }
}
