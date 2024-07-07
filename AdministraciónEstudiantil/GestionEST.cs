using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministraciónEstudiantil
{
    public partial class GestionEST : Form
    {
        GestionGeneral ventana;
        public GestionEST()
        {
            InitializeComponent();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventana.Visible = true;
        }
        public void RecibirVentanaGestionGeneral(GestionGeneral ventanaGeneral)
        {
            ventana = ventanaGeneral;
        }

        private void GestionEST_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
