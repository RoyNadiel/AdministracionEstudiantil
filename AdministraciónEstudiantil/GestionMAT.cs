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
    public partial class GestionMAT : Form
    {
        GestionGeneral ventana;
        GestionListas listaMaterias = new GestionListas();
        GestionListas listaDepartamentos = new GestionListas();
        public GestionMAT()
        {
            InitializeComponent();
            listaDepartamentos = GestionDEP.EnviarDepartamentos();
            //listaDepartamentos.MostrarDepartamentosEnComboBox(cbxDepartamentos);
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

        private void GestionMAT_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private MateriaNode ObtenerDatos()
        {
            MateriaNode datos = new MateriaNode();
            datos.Codigo = txtCodigo.Text;
            datos.Nombre = txtNombre.Text;
            datos.Descripcion = txtDescripcion.Text;
            return datos;
        }
        private void Agregar(object sender, EventArgs e)
        {
            //listaMaterias.AgregarMateria(cbxDepartamentos.Text, ObtenerDatos());
            //listaMaterias.AgregarMateriasADataGridView(cbxDepartamentos.Text, dgvMaterias);
        }
    }
}
