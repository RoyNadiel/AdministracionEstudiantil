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
    public partial class GestionGeneral : Form
    {
        public GestionGeneral()
        {
            InitializeComponent();
        }
        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            GestionDEP deps = new GestionDEP();
            deps.Visible = true;
            deps.RecibirVentanaGestionGeneral(this);
            this.Visible = false;
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            GestionMAT mats = new GestionMAT();
            mats.Visible = true;
            mats.RecibirVentanaGestionGeneral(this);
            this.Visible = false;
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            GestionEST est = new GestionEST();
            est.Visible = true;
            est.RecibirVentanaGestionGeneral(this);
            this.Visible = false;
        }
    }
}