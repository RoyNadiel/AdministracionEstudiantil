using System.Windows.Forms;

namespace AdministraciónEstudiantil.Reportes
{
    public partial class CuartoReporte : Form
    {
        DataGridView dgvMateria = new DataGridView();
        public CuartoReporte(DataGridView dgvEstudiantes, DataGridView dgvMaterias)
        {
            InitializeComponent();

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
    }
}
