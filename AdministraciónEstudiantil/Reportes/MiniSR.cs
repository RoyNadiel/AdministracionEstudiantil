using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AdministraciónEstudiantil.Reportes
{
    public partial class MiniSR : Form
    {
        public MiniSR()
        {
            InitializeComponent();
        }
        public MiniSR(string[] materias, Dictionary<string, int> Datos)
        {
            InitializeComponent();
            MostrarMaterias(materias, Datos);
        }

        private void MostrarMaterias(string[] materias, Dictionary<string, int> Datos)
        {
            int vertical = 40;
            int crecimiento = 0;
            List<string> claves = new List<string>(Datos.Keys);

            for (int x = 0; x < materias.Length; x++)
            {
                string clave = claves[x];
                Label label = new Label();
                Label cant = new Label();

                label.Text = "— " + materias[x].ToUpper();
                cant.Text = Datos[clave].ToString();
                label.Location = new Point(20, vertical);
                cant.Location = new Point(380, vertical);
                label.AutoSize = true;
                cant.AutoSize = true;
                this.Controls.Add(label);
                this.Controls.Add(cant);
                vertical += 20;
                crecimiento += 20;
                this.Size = new Size(316, 105 + crecimiento);
            }
            if (materias.Length > 1)
            {
                lbl1.Text = "MATERIAS CON MISMA CANTIDAD DE ESTUDIANTES:";
                lbl1.Location = new Point(25, 9);
                this.Size = new Size(450, 105 + crecimiento);
            }
            else
            {
                lbl1.Text = "MATERIA CON MAS ESTUDIANTES:";
                lbl1.Location = new Point(25, 9);
            }
        }
    }
}
