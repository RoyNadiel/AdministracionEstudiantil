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
        GestionDEP deps = new GestionDEP();
        GestionMAT mats = new GestionMAT();
        GestionEST est = new GestionEST();
        public GestionGeneral()
        {
            InitializeComponent();
        }
        private void btnDepartamentos_Click(object sender, EventArgs e)
        {            
            deps.Visible = true;
            deps.RecibirVentanaGestionGeneral(this);
            this.Visible = false;
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {           
            mats.Visible = true;
            mats.RecibirVentanaGestionGeneral(this);
            this.Visible = false;
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {            
            est.Visible = true;
            est.RecibirVentanaGestionGeneral(this);
            this.Visible = false;
        }
    }
}