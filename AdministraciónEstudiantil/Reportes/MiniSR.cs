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
    public partial class MiniSR : Form
    {
        public MiniSR()
        {
            InitializeComponent();
        }
        public MiniSR(string [] materias)
        {
            InitializeComponent();
            MostrarMaterias(materias);       
        }

        private void MostrarMaterias(string[] materias)
        {
            int vertical = 40;
            int crecimiento = 0;
            
            
            for (int x = 0; x < materias.Length; x++)
            {
                Label label = new Label();
                label.Text = "— " + materias[x].ToUpper();
                label.Location = new Point(20, vertical);
                label.AutoSize = true;
                this.Controls.Add(label);
                vertical += 20;
                crecimiento += 20;
                this.Size = new Size (316, 105 + crecimiento);
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
