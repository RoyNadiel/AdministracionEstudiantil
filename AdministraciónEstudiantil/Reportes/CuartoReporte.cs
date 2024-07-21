using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdministraciónEstudiantil.Reportes
{
    public partial class CuartoReporte : Form
    {
        DataGridView dgvDepartamentos = new DataGridView();
        public CuartoReporte(DataGridView dgvMaterias)
        {
            InitializeComponent();
            RecibirMaterias(dgvMaterias);
            MostrarDepartamentosCBX(dgvNuevo, 3, cbxDepartamentos);
            MostrarSemestresCBX(dgvNuevo, 0, cbxSemestre);
        }        
        private void RecibirMaterias(DataGridView dataGridView)
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

        private void MostrarDepartamentosCBX(DataGridView dataGridView, int columnIndex, ComboBox comboBox)
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
        private void MostrarSemestresCBX(DataGridView dataGridView, int columnIndex, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            HashSet<string> itemsSet = new HashSet<string>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow && row.Cells[columnIndex].Value != null)
                {
                    string item = row.Cells[columnIndex].Value.ToString();
                    string itemReal = item[item.Length - 2].ToString();
                    if (!itemsSet.Contains(itemReal))
                    {                       
                        itemsSet.Add(itemReal);
                    }
                }
            }
            List<string> Semestres = itemsSet.ToList();
            Semestres.Sort();

            foreach (var dato in Semestres)
            {
                comboBox.Items.Add(dato);
            }
        }
        private void FiltrarDataGridView()
        {
            if (cbxDepartamentos.Text != "" && cbxSemestre.Text != "")
            {
                string departamento = cbxDepartamentos.SelectedItem.ToString();
                string semestre = cbxSemestre.SelectedItem.ToString();
                foreach (DataGridViewRow fila in dgvNuevo.Rows)
                {
                    if (fila.Cells[3].Value != null && fila.Cells[0].Value != null && fila.Cells[3].Value.ToString() == departamento && fila.Cells[0].Value.ToString().Substring(fila.Cells[0].Value.ToString().Length - 2, 1) == semestre)
                    {
                        fila.Visible = true;
                    }
                    else
                    {
                        fila.Visible = false;
                    }
                }
            }
        }

        private void cbxDepartamentos_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            FiltrarDataGridView();
        }

        private void cbxSemestre_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            FiltrarDataGridView();
        }
    }

}