using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AdministraciónEstudiantil.Reportes
{
    public partial class MiniPR : Form
    {
        public MiniPR(DataTable Datos)
        {
            InitializeComponent();
            ImprimirEstudiantes(Datos);
            //RellenarListView(Datos);
        }
        private void ImprimirEstudiantes(DataTable Datos)
        {
            int horizontal = 0;
            int vertical = 0;
            if (Datos != null)
            {
                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    DataRow row = Datos.Rows[i];
                    for (int x = 0; x < Datos.Columns.Count; x++)
                    {
                        Label lbl = new Label();
                        lbl.Text = row[x].ToString();
                        lbl.Location = new Point(30 + horizontal, 79 + vertical);
                        lbl.Font = new Font("Sitka Small", 9);
                        this.Controls.Add(lbl);
                        horizontal += 130;
                    }
                    horizontal = 0;
                    vertical += 30;
                    this.Size = new Size(1017, 120 + vertical);
                }
            }
            else
            {
                MessageBox.Show("No hay estudiantes en esta materia", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
