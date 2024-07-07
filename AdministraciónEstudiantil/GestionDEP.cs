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
    public partial class GestionDEP : Form
    {
        GestionGeneral ventana;
        GestionListas listaDepartamentos = new GestionListas();
        public GestionDEP()
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
        private void GestionDEP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private Departamento ObtenerDatos()
        {
            Departamento datos = new Departamento();
            datos.Codigo = textBox1.Text;
            datos.Nombre = textBox2.Text;
            datos.Descripcion = textBox3.Text;
            return datos;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            listaDepartamentos.AgregarDepartamento(ObtenerDatos());
            listaDepartamentos.MostrarDepartamentosIF();
            listaDepartamentos.EliminarDepartamento("Informatica");      
            listaDepartamentos.MostrarDepartamentosIF();
        }
    }
}