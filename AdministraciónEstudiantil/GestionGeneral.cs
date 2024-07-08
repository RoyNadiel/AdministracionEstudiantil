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
            AbrirForm(deps);
        }
        private void AbrirForm(GestionDEP WindowsForm)
        {
            GestionDEP NewForm = WindowsForm;
            NewForm.TopLevel = false;
            NewForm.FormBorderStyle = FormBorderStyle.None; // Opcional para quitar bordes
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(NewForm);
            NewForm.Dock = DockStyle.Fill; // Para rellenar el Panel
            NewForm.Show();
        }
        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            //deps.Visible = true;
            //deps.RecibirVentanaGestionGeneral(this);
            //this.Visible = false;
            AbrirForm(deps);
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            //mats.Visible = true;
            //mats.RecibirVentanaGestionGeneral(this);
            //this.Visible = false;
            //AbrirForm(new GestionMAT());
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            //est.Visible = true;
            //est.RecibirVentanaGestionGeneral(this);
            //this.Visible = false;
            //AbrirForm(new GestionEST());
        }
    }
}