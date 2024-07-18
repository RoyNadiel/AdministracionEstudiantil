using AdministraciónEstudiantil.Reportes;
using System;
using System.Linq;
using System.Text.RegularExpressions;
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
            //Lista.AgregarDepartamento(PrecargasDepartamentos1());
            //Lista.AgregarDepartamento(PrecargasDepartamentos2());
            //Lista.AgregarDepartamento(PrecargasDepartamentos3());
            //Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosMAT);
            //Lista.AgregarMateria("Informatica", PrecargasMaterias1());
            //Lista.AgregarMateria("Cursos Basicos", PrecargasMaterias2());
            //Lista.AgregarMateria("Estadistica", PrecargasMaterias3());
            //Lista.AgregarMateriasADataGridView(dgvMaterias);
            //Lista.AgregarEstudiante("Informatica", "Datos II", PrecargasEstudiantes1());
            //Lista.AgregarEstudiante("Informatica", "Datos II", PrecargasEstudiantes2());
            //Lista.AgregarEstudiante("Estadistica", "Computacion I", PrecargasEstudiantes3());
            //Lista.AgregarEstudiante("Estadistica", "Computacion I", PrecargasEstudiantes4());
            //Lista.AgregarEstudiantesADataGridView(dgvEstudiantes);
            //Lista.AgregarDepartamentosADataGridView(dgvDepartamentos);
            //Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosEST);
        }
        private void Administracion_Load(object sender, EventArgs e)
        {
            Lista.AgregarDepartamento(PrecargasDepartamentos1());
            Lista.AgregarDepartamento(PrecargasDepartamentos2());
            Lista.AgregarDepartamento(PrecargasDepartamentos3());
            Lista.AgregarDepartamentosADataGridView(dgvDepartamentos);
            Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosMAT);
            Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosEST);

            Lista.AgregarMateria("Informatica", PrecargasMaterias1());
            Lista.AgregarMateria("Informatica", PrecargasMaterias2());
            Lista.AgregarMateria("Informatica", PrecargasMaterias3());
            Lista.AgregarMateria("Cursos Basicos", PrecargasMaterias4());
            Lista.AgregarMateria("Cursos Basicos", PrecargasMaterias5());
            Lista.AgregarMateria("Cursos Basicos", PrecargasMaterias6());
            Lista.AgregarMateria("Estadistica", PrecargasMaterias7());
            Lista.AgregarMateria("Estadistica", PrecargasMaterias8());
            Lista.AgregarMateria("Estadistica", PrecargasMaterias9());
            Lista.AgregarMateriasADataGridView(dgvMaterias);

            Lista.AgregarEstudiante("Informatica", "Datos II", PrecargasEstudiantes1());
            Lista.AgregarEstudiante("Informatica", "Datos II", PrecargasEstudiantes2());
            Lista.AgregarEstudiante("Informatica", "Datos II", PrecargasEstudiantes3());
            Lista.AgregarEstudiante("Informatica", "Datos II", PrecargasEstudiantes4());
            Lista.AgregarEstudiante("Estadistica", "Computacion I", PrecargasEstudiantes5());
            Lista.AgregarEstudiante("Estadistica", "Computacion I", PrecargasEstudiantes6());
            Lista.AgregarEstudiante("Estadistica", "Computacion I", PrecargasEstudiantes7());
            Lista.AgregarEstudiante("Estadistica", "Computacion I", PrecargasEstudiantes8());
            Lista.AgregarEstudiante("Estadistica", "Matematicas III", PrecargasEstudiantes9());
            Lista.AgregarEstudiante("Estadistica", "Matematicas III", PrecargasEstudiantes10());
            Lista.AgregarEstudiante("Estadistica", "Matematicas III", PrecargasEstudiantes11());
            Lista.AgregarEstudiante("Informatica", "Fundamentos de Electricidad", PrecargasEstudiantes12());
            Lista.AgregarEstudiante("Informatica", "Fundamentos de Electricidad", PrecargasEstudiantes13());
            Lista.AgregarEstudiante("Informatica", "Fundamentos de Electricidad", PrecargasEstudiantes14());
            Lista.AgregarEstudiante("Informatica", "Fundamentos de Electricidad", PrecargasEstudiantes15());
            Lista.AgregarEstudiantesADataGridView(dgvEstudiantes);
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
                if (txtCodigoDEP.Text != "")
                {
                    if (txtNombreDEP.Text != "")
                    {
                        if (txtDescripcionDEP.Text != "")
                        {
                            Lista.AgregarDepartamento(ObtenerDatosDepartamentos());
                            Lista.AgregarDepartamentosADataGridView(dgvDepartamentos);
                            Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosMAT);
                            Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosEST);
                            LimpiarDepartamentos();
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar una descricion.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un codigo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El codigo del departamento ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
        DataGridViewRow rowDEP;
        private void dgvDepartamentos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string[] rowSelected = new string[3];
            if (e.RowIndex >= 0)
            {
                rowDEP = dgvDepartamentos.Rows[e.RowIndex];
                DepartamentoSeleccionado[0] = rowDEP.Cells[1].Value.ToString();
            }
            if (rowDEP != null)
            {
                for (int x = 0; x < rowDEP.Cells.Count; x++)
                {
                    rowSelected[x] = rowDEP.Cells[x].Value.ToString();
                }
            }
            txtCodigoDEP.Text = rowSelected[0];
            txtNombreDEP.Text = rowSelected[1];
            txtDescripcionDEP.Text = rowSelected[2];
            btnAgregarDEP.Enabled = false;
            btnModificarDEP.Enabled = true;
            btnEliminarDEP.Enabled = true;
        }
        private void Modificar(object sender, EventArgs e)
        {
            if (dgvDepartamentos.RowCount > 0)
            {
                if (txtCodigoDEP.Text != "")
                {
                    if (txtNombreDEP.Text != "")
                    {
                        if (txtDescripcionDEP.Text != "")
                        {
                            Lista.ModificarDepartamentos(DepartamentoSeleccionado[0], DatosAModificar());
                            Lista.AgregarDepartamentosADataGridView(dgvDepartamentos);
                            Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosMAT);
                            Lista.MostrarDepartamentosEnComboBox(cbxDepartamentosEST);
                            Lista.AgregarMateriasADataGridView(dgvMaterias);
                            Lista.AgregarEstudiantesADataGridView(dgvEstudiantes);
                            LimpiarDepartamentos();
                            btnAgregarDEP.Enabled = true;
                            btnModificarDEP.Enabled = false;
                            btnEliminarDEP.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar una descricion.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un codigo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

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
                Lista.AgregarMateriasADataGridView(dgvMaterias);
                Lista.AgregarEstudiantesADataGridView(dgvEstudiantes);
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
            LimpiarDepartamentos();
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
            datos.Creditos = int.Parse(txtCodigoMAT.Text.Last().ToString());
            datos.Semestre = txtCodigoMAT.Text[txtCodigoMAT.Text.Length - 2];
            return datos;
        }
        private MateriaNode PrecargasMaterias1()
        {
            MateriaNode datos = new MateriaNode();
            datos.Codigo = "2301324";
            datos.Nombre = "Datos II";
            datos.Descripcion = "Estructuras de Datos";
            datos.Departamento = "Informatica";
            datos.Creditos = 4;
            datos.Semestre = 2;
            return datos;
        }
        private MateriaNode PrecargasMaterias2()
        {
            MateriaNode datos = new MateriaNode();
            datos.Codigo = "2301723";
            datos.Nombre = "Org & Sistemas";
            datos.Descripcion = "Cuestiones de Empresas";
            datos.Departamento = "Informatica";
            datos.Creditos = 3;
            datos.Semestre = 2;
            return datos;
        }
        private MateriaNode PrecargasMaterias3()
        {
            MateriaNode datos = new MateriaNode();
            datos.Codigo = "2302534";
            datos.Nombre = "Fundamentos de Electricidad";
            datos.Descripcion = "Física";
            datos.Departamento = "Informatica";
            datos.Creditos = 4;
            datos.Semestre = 3;
            return datos;
        }
        private MateriaNode PrecargasMaterias4()
        {
            MateriaNode datos = new MateriaNode();
            datos.Codigo = "0081214";
            datos.Nombre = "Matematicas I";
            datos.Descripcion = "Calculo Basico";
            datos.Departamento = "Cursos Basicos";
            datos.Creditos = 4;
            datos.Semestre = 1;
            return datos;
        }
        private MateriaNode PrecargasMaterias5()
        {
            MateriaNode datos = new MateriaNode();
            datos.Codigo = "0082413";
            datos.Nombre = "Linguistica";
            datos.Descripcion = "Elementos de Castellano";
            datos.Departamento = "Cursos Basicos";
            datos.Creditos = 3;
            datos.Semestre = 1;
            return datos;
        }
        private MateriaNode PrecargasMaterias6()
        {
            MateriaNode datos = new MateriaNode();
            datos.Codigo = "0083314";
            datos.Nombre = "Deporte";
            datos.Descripcion = "Actividad Deportiva ";
            datos.Departamento = "Cursos Basicos";
            datos.Creditos = 4;
            datos.Semestre = 1;
            return datos;
        }
        private MateriaNode PrecargasMaterias7()
        {
            MateriaNode datos = new MateriaNode();
            datos.Codigo = "2201213";
            datos.Nombre = "Computacion I";
            datos.Descripcion = "Principios de computación";
            datos.Departamento = "Estadistica";
            datos.Creditos = 3;
            datos.Semestre = 1;
            return datos;
        }
        private MateriaNode PrecargasMaterias8()
        {
            MateriaNode datos = new MateriaNode();
            datos.Codigo = "2202134";
            datos.Nombre = "Matematicas III";
            datos.Descripcion = "Calculo Multivariable";
            datos.Departamento = "Estadistica";
            datos.Creditos = 4;
            datos.Semestre = 3;
            return datos;
        }
        private MateriaNode PrecargasMaterias9()
        {
            MateriaNode datos = new MateriaNode();
            datos.Codigo = "2203463";
            datos.Nombre = "Muestreo II";
            datos.Descripcion = "Técnicas de recolección";
            datos.Departamento = "Estadistica";
            datos.Creditos = 3;
            datos.Semestre = 6;
            return datos;
        }
        private void AgregarMateria(object sender, EventArgs e)
        {
            if (ValidarRepeticionMAT() == true)
            {
                if (cbxDepartamentosMAT.Text != "")
                {
                    if (txtCodigoMAT.Text != "")
                    {
                        if (txtNombreMAT.Text != "")
                        {
                            if (txtDescripcionMAT.Text != "")
                            {
                                if (txtCodigoMAT.Text.Length == 7)
                                {
                                    Lista.AgregarMateria(cbxDepartamentosMAT.Text, ObtenerDatosMaterias());
                                    Lista.AgregarMateriasADataGridView(dgvMaterias);
                                    LimpiarMaterias();
                                }
                                else
                                {
                                    MessageBox.Show("Debe ingresar al menos 7 caracteres para el codigo de la Materia.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe ingresar una descricion.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un codigo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un departamento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void cbxDepartamentosMAT_TextChanged(object sender, EventArgs e)
        {
            Lista.AsignarCodigo(cbxDepartamentosMAT, txtCodigoMAT);
        }
        private bool ValidarRepeticionMAT()
        {
            string nuevoCodigo = txtCodigoMAT.Text;
            string nuevoNombre = txtNombreMAT.Text;

            foreach (DataGridViewRow row in dgvMaterias.Rows)
            {
                string codigoExistente = row.Cells[CODIGOMAT.Index].Value?.ToString();
                string nombreExistente = row.Cells[NOMBREMAT.Index].Value?.ToString();

                if (nuevoCodigo == codigoExistente)
                {
                    if (nuevoNombre != nombreExistente)
                    {
                        MessageBox.Show("La materia que intenta ingresar ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                if (nuevoCodigo == codigoExistente && nuevoNombre == nombreExistente)
                {
                    txtDescripcionMAT.Text = row.Cells[DESCRIPCIONMAT.Index].Value.ToString();
                }
            }
            return true;
        }

        string[] MateriaSeleccionada = new string[2];
        DataGridViewRow rowMAT;
        private void SeleccionarFila(object sender, DataGridViewCellMouseEventArgs e)
        {
            string[] selectedRow = new string[4];
            if (e.RowIndex >= 0)
            {
                rowMAT = dgvMaterias.Rows[e.RowIndex];
                MateriaSeleccionada[0] = rowMAT.Cells[1].Value.ToString();
                MateriaSeleccionada[1] = rowMAT.Cells[3].Value.ToString();
            }
            if (rowMAT != null)
            {
                for (int x = 0; x < rowMAT.Cells.Count; x++)
                {
                    selectedRow[x] = rowMAT.Cells[x].Value.ToString();
                }
            }
            txtCodigoMAT.Text = selectedRow[0];
            txtNombreMAT.Text = selectedRow[1];
            txtDescripcionMAT.Text = selectedRow[2];
            btnAgregarMAT.Enabled = false;
            btnModificarMAT.Enabled = true;
            btnEliminarMAT.Enabled = true;
        }
        private void ModificarMateria(object sender, EventArgs e)
        {
            if (txtCodigoMAT.Text != "")
            {
                if (txtNombreMAT.Text != "")
                {
                    if (txtDescripcionMAT.Text != "")
                    {
                        Lista.ModificarMateria(MateriaSeleccionada[1], MateriaSeleccionada[0], ObtenerDatosMaterias());
                        Lista.AgregarMateriasADataGridView(dgvMaterias);
                        Lista.AgregarEstudiantesADataGridView(dgvEstudiantes);
                        LimpiarMaterias();
                        btnAgregarMAT.Enabled = true;
                        btnModificarMAT.Enabled = false;
                        btnEliminarMAT.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar una descricion.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un codigo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void EliminarMateria(object sender, EventArgs e)
        {
            Lista.EliminarMateria(MateriaSeleccionada[1], MateriaSeleccionada[0]);
            Lista.AgregarMateriasADataGridView(dgvMaterias);
            Lista.AgregarEstudiantesADataGridView(dgvEstudiantes);
            btnAgregarMAT.Enabled = true;
            btnModificarMAT.Enabled = false;
            btnEliminarMAT.Enabled = false;
        }
        private void btnCancelarMAT_Click(object sender, EventArgs e)
        {
            btnAgregarMAT.Enabled = true;
            btnModificarMAT.Enabled = false;
            btnEliminarMAT.Enabled = false;
            LimpiarMaterias();
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
            datos.Materia = "Datos II";
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
            datos.Materia = "Datos II";
            datos.Departamento = "Informatica";
            datos.Nota = 0;
            return datos;
        }
        private EstudianteNode PrecargasEstudiantes3()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = "16043166";
            datos.Nombre = "Eric";
            datos.Apellido = "Rondon";
            datos.Seccion = "0621";
            datos.Periodo = "II-2022";
            datos.Materia = "Datos II";
            datos.Departamento = "Informatica";
            datos.Nota = 0;
            return datos;
        }
        private EstudianteNode PrecargasEstudiantes4()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = "16081090";
            datos.Nombre = "Jesus";
            datos.Apellido = "Salazar";
            datos.Seccion = "0621";
            datos.Periodo = "II-2022";
            datos.Materia = "Datos II";
            datos.Departamento = "Informatica";
            datos.Nota = 0;
            return datos;
        }
        private EstudianteNode PrecargasEstudiantes5()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = "1616662";
            datos.Nombre = "Cristhian";
            datos.Apellido = "Gonzales";
            datos.Seccion = "0820";
            datos.Periodo = "II-2023";
            datos.Materia = "Computacion I";
            datos.Departamento = "Estadistica";
            datos.Nota = 0;
            return datos;
        }
        private EstudianteNode PrecargasEstudiantes6()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = "14202614";
            datos.Nombre = "Francisco";
            datos.Apellido = "Gonzales";
            datos.Seccion = "0820";
            datos.Periodo = "II-2023";
            datos.Materia = "Computacion I";
            datos.Departamento = "Estadistica";
            datos.Nota = 0;
            return datos;
        }
        private EstudianteNode PrecargasEstudiantes7()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = "14202614";
            datos.Nombre = "Valeria";
            datos.Apellido = "Gonzales";
            datos.Seccion = "0821";
            datos.Periodo = "II-2022";
            datos.Materia = "Computacion I";
            datos.Departamento = "Estadistica";
            datos.Nota = 0;
            return datos;
        }
        private EstudianteNode PrecargasEstudiantes8()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = "14218088";
            datos.Nombre = "Jesus";
            datos.Apellido = "Lopez";
            datos.Seccion = "0821";
            datos.Periodo = "II-2022";
            datos.Materia = "Computacion I";
            datos.Departamento = "Estadistica";
            datos.Nota = 0;
            return datos;
        }
        private EstudianteNode PrecargasEstudiantes9()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = "14820148";
            datos.Nombre = "Prieto";
            datos.Apellido = "Diego";
            datos.Seccion = "0520";
            datos.Periodo = "II-2023";
            datos.Materia = "Matematicas III";
            datos.Departamento = "Estadistica";
            datos.Nota = 0;
            return datos;
        }
        private EstudianteNode PrecargasEstudiantes10()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = "14688162";
            datos.Nombre = "Quijada";
            datos.Apellido = "Jorge";
            datos.Seccion = "0520";
            datos.Periodo = "II-2023";
            datos.Materia = "Matematicas III";
            datos.Departamento = "Estadistica";
            datos.Nota = 0;
            return datos;
        }
        private EstudianteNode PrecargasEstudiantes11()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = "14688649";
            datos.Nombre = "Suarez";
            datos.Apellido = "Karlismar";
            datos.Seccion = "0521";
            datos.Periodo = "II-2022";
            datos.Materia = "Matematicas III";
            datos.Departamento = "Estadistica";
            datos.Nota = 0;
            return datos;
        }
        private EstudianteNode PrecargasEstudiantes12()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = "14168103";
            datos.Nombre = "Joscar";
            datos.Apellido = "Gomez";
            datos.Seccion = "0520";
            datos.Periodo = "II-2023";
            datos.Materia = "Fundamentos de Electricidad";
            datos.Departamento = "Informatica";
            datos.Nota = 0;
            return datos;
        }
        private EstudianteNode PrecargasEstudiantes13()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = "18169493";
            datos.Nombre = "Yudeimis";
            datos.Apellido = "Guerra";
            datos.Seccion = "0520";
            datos.Periodo = "II-2023";
            datos.Materia = "Fundamentos de Electricidad";
            datos.Departamento = "Informatica";
            datos.Nota = 0;
            return datos;
        }
        private EstudianteNode PrecargasEstudiantes14()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = "16820222";
            datos.Nombre = "Jade";
            datos.Apellido = "Hajjar";
            datos.Seccion = "0521";
            datos.Periodo = "II-2022";
            datos.Materia = "Fundamentos de Electricidad";
            datos.Departamento = "Informatica";
            datos.Nota = 0;
            return datos;
        }
        private EstudianteNode PrecargasEstudiantes15()
        {
            EstudianteNode datos = new EstudianteNode();
            datos.Cedula = "16248093";
            datos.Nombre = "Maria";
            datos.Apellido = "Henriquez";
            datos.Seccion = "0521";
            datos.Periodo = "II-2022";
            datos.Materia = "Fundamentos de Electricidad";
            datos.Departamento = "Informatica";
            datos.Nota = 0;
            return datos;
        }

        private bool ValidarEstudianteRepetido()
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

            //if (ValidarRepeticionEST() == true)
            //{


            //}
            //else
            //{
            //    MessageBox.Show("Este estudiante ya existe en el Sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
        private void AgregarEstudiante(object sender, EventArgs e)
        {
            if (txtCedulaEST.Text != "")
            {
                if (txtNombreEST.Text != "")
                {
                    if (txtApellidoEST.Text != "")
                    {
                        if (txtSeccionEST.Text != "")
                        {
                            if (ValidarPeriodoSemestral(txtPeriodoEST.Text) == true)
                            {
                                if (cbxDepartamentosEST.Text != "")
                                {
                                    if (cbxMateriasEST.Text != "")
                                    {
                                        Lista.AgregarEstudiante(cbxDepartamentosEST.Text, cbxMateriasEST.Text, ObtenerDatosEstudiantes());
                                        Lista.AgregarEstudiantesADataGridView(dgvEstudiantes);
                                        LimpiarEstudiantes();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe seleccionar una materia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Seleccione un departamento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe ingresar el periodo semestral de  manera correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar una seccion.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un apellido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una cedula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cbxDepartamentosEST_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lista.MostrarMateriasAComboBox(cbxDepartamentosEST.Text, cbxMateriasEST, cbxDepartamentosEST);
        }
        string[] EstudianteSeleccionado = new string[4];
        DataGridViewRow rowEST;
        private void SeleccionarEstudiante(object sender, DataGridViewCellMouseEventArgs e)
        {
            string[] rowSelected = new string[8];
            if (e.RowIndex >= 0)
            {
                rowEST = dgvEstudiantes.Rows[e.RowIndex];
                EstudianteSeleccionado[0] = rowEST.Cells[1].Value.ToString(); //NOMBRE
                EstudianteSeleccionado[1] = rowEST.Cells[5].Value.ToString(); //MATEIRA
                EstudianteSeleccionado[2] = rowEST.Cells[6].Value.ToString(); //DEPARTAMENTO               
            }
            if (rowEST != null)
            {
                for (int x = 0; x < rowEST.Cells.Count; x++)
                {
                    rowSelected[x] = rowEST.Cells[x].Value.ToString();
                }
            }
            txtCedulaEST.Text = rowSelected[0];
            txtNombreEST.Text = rowSelected[1];
            txtApellidoEST.Text = rowSelected[2];
            txtSeccionEST.Text = rowSelected[3];
            txtPeriodoEST.Text = rowSelected[4];
            txtNotaEST.Text = rowSelected[7];
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
            LimpiarEstudiantes();
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
        #endregion
        public DataGridView CopiarDataGridViewEstudiantes()
        {
            DataGridView dgvNuevo = new DataGridView();

            foreach (DataGridViewColumn col in dgvEstudiantes.Columns)
            {
                dgvNuevo.Columns.Add(col.Clone() as DataGridViewColumn);
            }

            foreach (DataGridViewRow row in dgvEstudiantes.Rows)
            {
                DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    newRow.Cells[i].Value = row.Cells[i].Value;
                }
                dgvNuevo.Rows.Add(newRow);
            }
            return dgvNuevo;
        }
        public DataGridView CopiarDataGridViewMaterias()
        {
            DataGridView dgvNuevo = new DataGridView();

            foreach (DataGridViewColumn col in dgvMaterias.Columns)
            {
                dgvNuevo.Columns.Add(col.Clone() as DataGridViewColumn);
            }

            foreach (DataGridViewRow row in dgvMaterias.Rows)
            {
                DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    newRow.Cells[i].Value = row.Cells[i].Value;
                }
                dgvNuevo.Rows.Add(newRow);
            }
            return dgvNuevo;
        }
        private void btnLateral1_Click_1(object sender, EventArgs e)
        {
            PrimerReporte ventana = new PrimerReporte(CopiarDataGridViewEstudiantes(), CopiarDataGridViewMaterias());
            ventana.ShowDialog();
        }

        private void btnLateral2_Click(object sender, EventArgs e)
        {
            SegundoReporte ventana = new SegundoReporte(CopiarDataGridViewEstudiantes(), CopiarDataGridViewMaterias());
            ventana.ShowDialog();
        }

        private void btnLateral3_Click(object sender, EventArgs e)
        {
            TercerReporte ventana = new TercerReporte(Lista.MostrarCreditos1());
            ventana.ShowDialog();
        }

        private void btnLateral4_Click(object sender, EventArgs e)
        {

        }
    }
}