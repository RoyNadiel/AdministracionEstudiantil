using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministraciónEstudiantil
{
    public partial class Administracion : Form
    {
        Listas Lista = new Listas();
        public Administracion()
        {
            InitializeComponent();
            Lista = new Listas();
            Lista.AgregarDepartamento(PrecargasDepartamentos1());
            Lista.AgregarDepartamento(PrecargasDepartamentos2());
            Lista.AgregarDepartamento(PrecargasDepartamentos3());
            Lista.AgregarMateria("Informatica", PrecargasMaterias1());
            Lista.AgregarMateria("Cursos Basicos", PrecargasMaterias2());
            Lista.AgregarMateriasADataGridView(dgvMaterias);
            Lista.AgregarEstudiante("Informatica", "ALG & Datos II", PrecargasEstudiantes1());
            Lista.AgregarEstudiante("Informatica", "ALG & Datos II", PrecargasEstudiantes2());
            Lista.AgregarEstudiantesADataGridView(dgvEstudiantes);
            Lista.AgregarDepartamentosADataGridView(dgvDepartamentos);
            Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosMAT);
            Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosEST);
            sidePanel1.Visible = false;
        }
        private void GestionDEP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #region Departamentos
        private Departamento ObtenerDatosDepartamentos()
        {
            Departamento datos = new Departamento();
            datos.Codigo = txtCodigoDEP.Text;
            datos.Nombre = txtNombreDEP.Text;
            datos.Descripcion = txtDescripcionDEP.Text;
            return datos;
        }
        private Departamento PrecargasDepartamentos1()
        {
            Departamento datos = new Departamento();
            datos.Codigo = "230";
            datos.Nombre = "Informatica";
            datos.Descripcion = "Departamento de EICA";            
            return datos;
        }
        private Departamento PrecargasDepartamentos2()
        {
            Departamento datos = new Departamento();
            datos.Codigo = "008";
            datos.Nombre = "Cursos Basicos";
            datos.Descripcion = "Materias Basicas";
            return datos;
        }
        private Departamento PrecargasDepartamentos3()
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
            datos.Codigo = txtCodigoDEP.Text;
            datos.Nombre = txtNombreDEP.Text;
            datos.Descripcion = txtDescripcionDEP.Text;
            return datos;
        }
        private void Agregar(object sender, EventArgs e)
        {
            if (ValidarRepeticionDEP() == true)
            {
                Lista.AgregarDepartamento(ObtenerDatosDepartamentos());
                Lista.AgregarDepartamentosADataGridView(dgvDepartamentos);
                Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosMAT);
                Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosEST);                
            }
            else
            {
                MessageBox.Show("El codigo del departamento ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LimpiarDepartamentos();
        }
        private bool ValidarRepeticionDEP()
        {
            string nuevoDato = txtCodigoDEP.Text;

            foreach (DataGridViewRow row in dgvDepartamentos.Rows)
            {
                string valorFilaActual = row.Cells[CODIGO.Index].Value?.ToString();

                if (nuevoDato == valorFilaActual)
                {
                    return false;
                }                
            }
            return true;
        }        
        string[] DepartamentoSeleccionado = new string[1];
        private void dgvDepartamentos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDepartamentos.Rows[e.RowIndex];
                DepartamentoSeleccionado[0] = row.Cells[1].Value.ToString();
            }
            //txtCodigoDEP.Text = row.Cells[0].Value.ToString();
            //txtNombreDEP.Text = row.Cells[1].Value.ToString();
            //txtDescripcionDEP.Text = row.Cells[2].Value.ToString();
            btnAgregarDEP.Enabled = false;
            btnModificarDEP.Enabled = true;
            btnEliminarDEP.Enabled = true;
        }
        private void Modificar(object sender, EventArgs e)
        {
            if (dgvDepartamentos.RowCount > 0)
            {
                Lista.ModificarDepartamentos(DepartamentoSeleccionado[0], DatosAModificar());
                Lista.AgregarDepartamentosADataGridView(dgvDepartamentos);
                Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosMAT);
                Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosEST);
                LimpiarDepartamentos();
                btnAgregarDEP.Enabled = true;
                btnModificarDEP.Enabled = false;
                btnEliminarDEP.Enabled = false;
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
                Lista.EliminarDepartamento(DepartamentoSeleccionado[0]);                
                Lista.AgregarDepartamentosADataGridView(dgvDepartamentos);
                Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosMAT);
                Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosEST);
                LimpiarDepartamentos();
                btnAgregarDEP.Enabled = true;
                btnModificarDEP.Enabled = false;
                btnEliminarDEP.Enabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione el Departamento a ELIMINAR", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }
        private void Cancelar(object sender, EventArgs e)
        {
            btnAgregarDEP.Enabled = true;
            btnModificarDEP.Enabled = false;
            btnEliminarDEP.Enabled = false;
        }
        private void LimpiarDepartamentos()
        {
            txtCodigoDEP.Clear();
            txtNombreDEP.Clear();
            txtDescripcionDEP.Clear();
        }        
        private void cbxDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminarDEP.Enabled = true;
        }
        #endregion
        #region Materias
        private MateriaNode ObtenerDatosMaterias()
        {
            MateriaNode datos = new MateriaNode();
            datos.Codigo = txtCodigoMAT.Text;
            datos.Nombre = txtNombreMAT.Text;
            datos.Descripcion = txtDescripcionMAT.Text;
            datos.Departamento = cbxDepartamentosMAT.Text;
            return datos;
        }
        private MateriaNode PrecargasMaterias1()
        {
            MateriaNode datos = new MateriaNode();
            datos.Codigo = "2301324";
            datos.Nombre = "ALG & Datos II";
            datos.Descripcion = "Estructuras de datos";
            datos.Departamento = "Informatica";
            return datos;
        }
        private MateriaNode PrecargasMaterias2()
        {
            MateriaNode datos = new MateriaNode();
            datos.Codigo = "0081214";
            datos.Nombre = "Matemáticas I";
            datos.Descripcion = "Cálculo Cásico";
            datos.Departamento = "Cursos Basicos";
            return datos;
        }
        private void AgregarMateria(object sender, EventArgs e)
        {
            if (ValidarRepeticionMAT() == true)
            {
                Lista.AgregarMateria(cbxDepartamentosMAT.Text, ObtenerDatosMaterias());
                Lista.AgregarMateriasADataGridView(dgvMaterias);
                LimpiarMaterias();                
            }
            else
            {
                MessageBox.Show("El codigo de la materia ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool ValidarRepeticionMAT()
        {
            string nuevoCodigo = txtCodigoMAT.Text;
            string nuevoNombre = txtNombreMAT.Text;

            // Verificar si el nuevo dato ya existe en la columna deseada
            foreach (DataGridViewRow row in dgvMaterias.Rows)
            {
                string codigoExistente = row.Cells[CODIGO.Index].Value?.ToString();
                string nombreExistente = row.Cells[NOMBRE.Index].Value?.ToString();

                if (nuevoCodigo == codigoExistente && nuevoNombre == nombreExistente)
                {
                    return false;
                }
            }
            return true;
        }
        string[] MateriaSeleccionada = new string[2];
        private void SeleccionarFila(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMaterias.Rows[e.RowIndex];
                MateriaSeleccionada[0] = row.Cells[1].Value.ToString();
                MateriaSeleccionada[1] = row.Cells[3].Value.ToString();
            }
            btnAgregarMAT.Enabled = false;
            btnModificarMAT.Enabled = true;
            btnEliminarMAT.Enabled = true;
        }
        private void ModificarMateria(object sender, EventArgs e)
        {
            Lista.ModificarMateria(cbxDepartamentosMAT.Text, MateriaSeleccionada[0], ObtenerDatosMaterias());
            Lista.AgregarMateriasADataGridView(dgvMaterias);
            btnAgregarMAT.Enabled = true;
            btnModificarMAT.Enabled = false;
            btnEliminarMAT.Enabled = false;
        }
        private void EliminarMateria(object sender, EventArgs e)
        {
            Lista.EliminarMateria(MateriaSeleccionada[1], MateriaSeleccionada[0]);
            Lista.AgregarMateriasADataGridView(dgvMaterias);
            btnAgregarMAT.Enabled = true;
            btnModificarMAT.Enabled = false;
            btnEliminarMAT.Enabled = false;
        }
        private void btnCancelarMAT_Click(object sender, EventArgs e)
        {
            btnAgregarMAT.Enabled = true;
            btnModificarMAT.Enabled = false;
            btnEliminarMAT.Enabled = false;
        }
        private void LimpiarMaterias()
        {
            txtCodigoMAT.Clear();
            txtNombreMAT.Clear();
            txtDescripcionMAT.Clear();
            cbxDepartamentosMAT.SelectedItem = null;
        }
        #endregion
        #region Estudiantes
        private EstudianteNode ObtenerDatosEstudiantes()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = txtCedulaEST.Text;
            datos.Nombre = txtNombreEST.Text;
            datos.Apellido = txtApellidoEST.Text;
            datos.Seccion = txtSeccionEST.Text;
            datos.Periodo = txtPeriodoEST.Text.ToUpper();     
            datos.Materia = cbxMateriasEST.Text;
            datos.Departamento = cbxDepartamentosEST.Text;
            datos.Nota = float.Parse(txtNotaEST.Text);
            return datos;
        }
        private EstudianteNode PrecargasEstudiantes1()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = "16803161";
            datos.Nombre = "Alan";
            datos.Apellido = "Rivas";
            datos.Seccion = "0620";
            datos.Periodo = "II-2023";
            datos.Materia = "ALG & Datos II";
            datos.Departamento = "Informatica";
            datos.Nota = 0;
            return datos;
        }
        private EstudianteNode PrecargasEstudiantes2()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = "16823162";
            datos.Nombre = "Diego";
            datos.Apellido = "Rodriguez";
            datos.Seccion = "0620";
            datos.Periodo = "II-2023";
            datos.Materia = "ALG & Datos II";
            datos.Departamento = "Informatica";
            datos.Nota = 0;
            return datos;
        }
        private bool ValidarRepeticionEST()
        {
            string nuevoDato = txtCedulaEST.Text;

            // Verificar si el nuevo dato ya existe en la columna deseada
            foreach (DataGridViewRow row in dgvEstudiantes.Rows)
            {
                string valorFilaActual = row.Cells[CEDULA.Index].Value?.ToString();

                if (nuevoDato == valorFilaActual)
                {
                    return false;
                }
            }
            return true;
        }
        private void AgregarEstudiante(object sender, EventArgs e)
        {
            if (cbxDepartamentosEST.Text != "")
            {
                if (cbxMateriasEST.Text != "")
                {
                    if (ValidarPeriodoSemestral(txtPeriodoEST.Text) == true)
                    {
                        if (ValidarRepeticionEST() == true)
                        {
                            Lista.AgregarEstudiante(cbxDepartamentosEST.Text, cbxMateriasEST.Text, ObtenerDatosEstudiantes());
                            Lista.AgregarEstudiantesADataGridView(dgvEstudiantes);
                            LimpiarEstudiantes();                            
                        }
                        else
                        {
                            MessageBox.Show("Este estudiante ya existe en el Sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar el periodo semestral de  manera correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un departamento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cbxDepartamentosEST_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lista.MostrarMateriasAComboBox(cbxDepartamentosEST.Text, cbxMateriasEST, cbxDepartamentosEST);
        }
        string[] EstudianteSeleccionado = new string[4];
        DataGridViewRow row;
        private void SeleccionarEstudiante(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = dgvEstudiantes.Rows[e.RowIndex];
                EstudianteSeleccionado[0] = row.Cells[1].Value.ToString(); //NOMBRE
                EstudianteSeleccionado[1] = row.Cells[5].Value.ToString(); //MATEIRA
                EstudianteSeleccionado[2] = row.Cells[6].Value.ToString(); //DEPARTAMENTO               
            }
            btnAgregarEST.Enabled = false;
            btnModificarEST.Enabled = true;
            btnEliminarEST.Enabled = true;
        }
        private void btnModificarEST_Click(object sender, EventArgs e)
        {
            Lista.ModificarNotaEstudiante(EstudianteSeleccionado[0], EstudianteSeleccionado[1], EstudianteSeleccionado[2], float.Parse(txtNotaEST.Text));
            Lista.AgregarEstudiantesADataGridView(dgvEstudiantes);
            LimpiarEstudiantes();
            btnAgregarEST.Enabled = true;
            btnModificarEST.Enabled = false;
            btnEliminarEST.Enabled = false;
        }
        private void btnEliminarEST_Click(object sender, EventArgs e)
        {
            Lista.EliminarEstudiante(EstudianteSeleccionado[0], EstudianteSeleccionado[2], EstudianteSeleccionado[1]);
            Lista.AgregarEstudiantesADataGridView(dgvEstudiantes);
            btnAgregarEST.Enabled = true;
            btnModificarEST.Enabled = false;
            btnEliminarEST.Enabled = false;
        }
        private void btnCancelarEST_Click(object sender, EventArgs e)
        {
            btnAgregarEST.Enabled = true;
            btnModificarEST.Enabled = false;
            btnEliminarEST.Enabled = false;
        }
        private void LimpiarEstudiantes()
        {
            txtCedulaEST.Clear();
            txtNombreEST.Clear();
            txtApellidoEST.Clear();
            txtSeccionEST.Clear();
            txtPeriodoEST.Clear();
            txtNotaEST.Text = "0";
            cbxMateriasEST.SelectedItem = null;
            cbxDepartamentosEST.SelectedItem = null;
        }
        private static bool ValidarPeriodoSemestral(string periodo)
        {
            string patron = @"^[IVXLCDMivxlcmd]{1,3}-\d{4}$";

            if (Regex.IsMatch(periodo, patron))
            {
                return true;
            }
            else
            {                
                return false;             
            }
        }
        private void txtCodigoDEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCodigoMAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCedulaEST_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSeccionEST_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnLateral1_Click_1(object sender, EventArgs e)
        {            
            PrimerReporte ventana = new PrimerReporte(CopiarDataGridView());
            ventana.ShowDialog();
        }
        public DataGridView CopiarDataGridView()
        {
            string periodo = txtPeriodoEST.Text.ToUpper();
            string materia = cbxMateriasEST.Text;
            DataGridView dgvNuevo = new DataGridView();

            foreach (DataGridViewColumn col in dgvEstudiantes.Columns)
            {
                dgvNuevo.Columns.Add(col.Clone() as DataGridViewColumn);
            }

            foreach (DataGridViewRow row in dgvEstudiantes.Rows)
            {
                if (row.Cells[5].Value.ToString() == materia)
                {
                    if (row.Cells[4].Value.ToString() == periodo)
                    {
                        DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            newRow.Cells[i].Value = row.Cells[i].Value;
                        }
                        dgvNuevo.Rows.Add(newRow);
                    }
                }
            }            
            return dgvNuevo;
        }
        public DataTable Estudiantes()
        {
            DataGridView dataGridView = dgvEstudiantes;

            DataTable dataTable = new DataTable();

            // Agregar columnas a la DataTable
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }

            // Agregar filas a la DataTable
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value != null ? cell.Value.ToString() : "";
                }
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }
        public DataGridView dgv()
        {
            DataGridView dgv = dgvEstudiantes;
            return dgv;
        }

        #endregion

        private void tabDepartamentos_MouseMove(object sender, MouseEventArgs e)
        {
            // Convertimos las coordenadas del cursor a coordenadas locales del SidePanel  
            Point point = sidePanel1.PointToClient(MousePosition);

            // Verificamos si el cursor se encuentra dentro del área del SidePanel  
            if (sidePanel1.ClientRectangle.Contains(point))
            {
                sidePanel1.Visible = true; // Mostramos el SidePanel si el cursor está dentro de su área  
            }
            else
            {
                sidePanel1.Visible = false; // Ocultamos el SidePanel si el cursor está fuera de su área  
            }            
        } //SLIDE PANEL

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}