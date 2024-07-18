using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AdministraciónEstudiantil.Reportes
{
    public partial class TercerReporte : Form
    {
        public TercerReporte(Dictionary<string, int> Datos)
        {
            InitializeComponent();
            MostrarCreditos(Datos);
        }
        private void MostrarCreditos(Dictionary<string, int> Datos)
        {
            int vertical = 40;
            int crecimiento = 0;
            foreach (KeyValuePair<string, int> dato in Datos)
            {
                Label materia = new Label();
                Label credito = new Label();

                materia.Text = dato.Key;
                credito.Text = dato.Value.ToString();
                materia.Location = new Point(20, vertical);
                credito.Location = new Point(350, vertical);
                materia.AutoSize = true;
                credito.AutoSize = true;
                this.Controls.Add(materia);
                this.Controls.Add(credito);
                vertical += 20;
                crecimiento += 20;
                this.Size = new Size(408, 121 + crecimiento);
            }
        }
    }
}
