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
        static GestionListas listaDepartamentos = new GestionListas();
        string[] selectedRow = new string[1];
        public GestionDEP()
        {
            InitializeComponent();
            listaDepartamentos = new GestionListas();
            listaDepartamentos.AgregarDepartamento(Precargas1());
            listaDepartamentos.AgregarDepartamento(Precargas2());
            listaDepartamentos.AgregarDepartamento(Precargas3());
            listaDepartamentos.AgregarDepartamentosADataGridView(dgvDepartamentos);
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
            datos.Codigo = txtCodigo.Text;
            datos.Nombre = txtNombre.Text;
            datos.Descripcion = txtDescripcion.Text;
            return datos;
        }
        private Departamento Precargas1()
        {
            Departamento datos = new Departamento();
            datos.Codigo = "230";
            datos.Nombre = "Informatica";
            datos.Descripcion = "Departamento de EICA";            
            return datos;
        }
        private Departamento Precargas2()
        {
            Departamento datos = new Departamento();
            datos.Codigo = "008";
            datos.Nombre = "CursosBasicos";
            datos.Descripcion = "Materias Basicas";
            return datos;
        }
        private Departamento Precargas3()
        {
            Departamento datos = new Departamento();
            datos.Codigo = "220";
            datos.Nombre = "Estadistica";
            datos.Descripcion = "Ciencias Estadisticas";
            return datos;
        }
        private Departamento DatosAModificar()
        {
            Departamento datos = new Departamento();
            datos.Codigo = txtCodigo.Text;
            datos.Nombre = txtNombre.Text;
            datos.Descripcion = txtDescripcion.Text;
            return datos;
        }
        private void Agregar(object sender, EventArgs e)
        {            
            listaDepartamentos.AgregarDepartamento(ObtenerDatos());
            listaDepartamentos.AgregarDepartamentosADataGridView(dgvDepartamentos);
            Limpiar();
        }
        private void Modificar(object sender, EventArgs e)
        {
            if (dgvDepartamentos.RowCount > 0)
            {
                listaDepartamentos.ModificarDepartamentos(selectedRow[0], DatosAModificar());
                listaDepartamentos.AgregarDepartamentosADataGridView(dgvDepartamentos);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Seleccione el Departamento a Modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Eliminar(object sender, EventArgs e)
        {
            if (dgvDepartamentos.RowCount > 0)
            {
                listaDepartamentos.EliminarDepartamento(selectedRow[0]);
            }
            else
            {
                MessageBox.Show("Seleccione el Departamento a ELIMINAR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            listaDepartamentos.AgregarDepartamentosADataGridView(dgvDepartamentos);
            Limpiar();
        }
        private void Cancelar(object sender, EventArgs e)
        {
            Limpiar();
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            //cbxDepartamentos.Text = "";
        }
        DataGridViewRow row;        
        private void dgvDepartamentos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = dgvDepartamentos.Rows[e.RowIndex];
                selectedRow[0] = row.Cells[1].Value.ToString();                
            }
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void cbxDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }
        public static GestionListas EnviarDepartamentos() => listaDepartamentos;
    }
}