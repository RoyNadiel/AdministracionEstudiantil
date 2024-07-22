using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AdministraciónEstudiantil.Reportes
{
    public partial class TercerReporte : Form
    {
        Dictionary<string, int> datos = new Dictionary<string, int>();
        public TercerReporte(Dictionary<string, int> Datos)
        {
            InitializeComponent();
            MostrarCreditos(Datos);
            datos = Datos;
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
                vertical += 25;
                crecimiento += 25;
                this.Size = new Size(408, 121 + crecimiento);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {            
            int vertical = 39;
            base.OnPaint(e);
            foreach (KeyValuePair<string, int> dato in datos)
            {
                // Crear un lápiz para dibujar  
                using (Pen pen = new Pen(Color.Black, 2)) // Color y grosor de la línea  
                {
                    // Dibujar la línea horizontal  
                    e.Graphics.DrawLine(pen, 0, vertical, this.ClientSize.Width, vertical); // Cambia 50 por la posición deseada en Y  
                }
                vertical += 25;
            }
        }
    }
}
