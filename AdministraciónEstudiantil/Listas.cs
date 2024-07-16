using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministraciónEstudiantil
{
    public class Listas
    {   /////////////////////////////    METODOS PARA LOS DEPARTAMENTOS    ///////////////////////////// 
        #region Departamento
        public Departamento inicio;
        public Departamento final;

        public void AgregarDepartamento(Departamento Datos)
        {
            Departamento nuevoDepartamento = Datos;
            if (inicio == null)
            {
                inicio = nuevoDepartamento;
                inicio.Next = null;
                inicio.Previous = null;
                final = inicio;
            }
            else
            {
                final.Next = nuevoDepartamento;
                nuevoDepartamento.Next = null;
                nuevoDepartamento.Previous = final;
                final = nuevoDepartamento;
            }
        }
        public Departamento ObtenerDepartamento(string nombre)
        {
            Departamento temp = inicio;
            while (temp != null)
            {
                if (temp.Nombre == nombre)
                {
                    return temp;
                }
                temp = temp.Next;
            }
            return null;
        }
        public void ModificarDepartamentos(string nombreDepartamento, Departamento datos)
        {
            Departamento departamento = ObtenerDepartamento(nombreDepartamento);
            if (departamento != null)
            {
                while (departamento != null)
                {
                    if (departamento.Nombre == nombreDepartamento)
                    {
                        departamento.Nombre = datos.Nombre;
                        departamento.Codigo = datos.Codigo;
                        departamento.Descripcion = datos.Descripcion;
                        return;                        
                    }
                    departamento = departamento.Next;                    
                }
            }
        }
        public void MostrarDepartamentosEnComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            Departamento currentDepartamento = inicio;
            while (currentDepartamento != null)
            {
                comboBox.Items.Add(currentDepartamento.Nombre);
                currentDepartamento = currentDepartamento.Next;
            }
        }
        public void AsignarCodigo(ComboBox cbx, TextBox txt)
        {
            Departamento departamento = inicio;
            while (departamento != null)
            {
                if (cbx.Text == departamento.Nombre)
                {
                    txt.Text = departamento.Codigo;
                }
                departamento = departamento.Next;
            }
        }
        public void EliminarDepartamento(string nombreDepartamento)
        {
            Departamento departamentoAnterior = null;
            Departamento departamentoActual = inicio;

            while (departamentoActual != null)
            {
                if (departamentoActual.Nombre == nombreDepartamento)
                {
                    if (departamentoAnterior == null)
                    {
                        inicio = departamentoActual.Next;
                    }
                    else
                    {
                        departamentoAnterior.Next = departamentoActual.Next;
                    }
                }
                departamentoAnterior = departamentoActual;
                departamentoActual = departamentoActual.Next;
            }            
        }
        public DataTable ConvertirADatatable()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("CODIGO", typeof(string));
            dataTable.Columns.Add("NOMBRE", typeof(string));
            dataTable.Columns.Add("DESCRIPCION", typeof(string));

            Departamento departamento = inicio;

            while (departamento != null)
            {
                dataTable.Rows.Add(departamento.Codigo, departamento.Nombre, departamento.Descripcion);
                departamento = departamento.Next;
            }
            return dataTable;
        }
        public void AgregarDepartamentosADataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            Departamento Departamento = inicio;
            while (Departamento != null)
            {
                dataGridView.Rows.Add(Departamento.Codigo, Departamento.Nombre, Departamento.Descripcion);
                Departamento = Departamento.Next;
            }
        }
        #endregion
        /////////////////////////////    METODOS PARA LAS MATERIAS    ////////////////////////////// 
        #region Materias
        public void AgregarMateria(string nombreDepartamento, MateriaNode Datos)
        {
            Departamento departamento = ObtenerDepartamento(nombreDepartamento);
            if (departamento != null)
            {
                MateriaNode nuevaMateria = Datos;
                if (departamento.Materias == null)
                {
                    departamento.Materias = nuevaMateria;
                }
                else
                {
                    MateriaNode temp = departamento.Materias;
                    while (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = nuevaMateria;
                }
            }
            else
            {
                MessageBox.Show("No se encontro el departamento");
            }            
        }
        public void MostrarCreditos()
        {
            Departamento departamento = inicio;
            string[] materias = new string[10];
            int[] creditos = new int[10];
            int contador = 0;

            while (departamento != null)
            {
                MateriaNode materia = departamento.Materias;
                while (materia != null)
                {
                    creditos[contador] = materia.Creditos;
                    materias[contador] = materia.Nombre;
                    materia = materia.Next;
                    contador++;
                }
                departamento = departamento.Next;
            }
            MessageBox.Show(
                $"La materia {materias[0]} tiene {creditos[0]} creditos\n\n" +
                $"La materia {materias[1]} tiene {creditos[1]} creditos\n\n" +
                $"La materia {materias[2]} tiene {creditos[2]} creditos\n\n",
                "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }
        public void MostrarCreditosReal()
        {
            Departamento departamento = inicio;

            while (departamento != null)
            {
                MateriaNode materia = departamento.Materias;
                while (materia != null)
                {
                    MessageBox.Show($"La materia {materia.Nombre} cuenta con {materia.Creditos} Creditos", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    materia = materia.Next;
                }
                departamento = departamento.Next;
            }
        }
        public void AgregarMateriasADataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            Departamento departamento = inicio;
            
            while (departamento != null)
            {
                MateriaNode Materia = departamento.Materias;
                while (Materia != null)
                {
                   dataGridView.Rows.Add(Materia.Codigo, Materia.Nombre, Materia.Descripcion, Materia.Departamento);
                    Materia = Materia.Next;
                }
                departamento = departamento.Next;
            }
        }
        public void ModificarMateria(string nombreDepartamento, string nombreMateria, MateriaNode Datos)
        {
            Departamento Departamento = inicio;
            while (Departamento != null)
            {
                if (Departamento.Nombre == nombreDepartamento)
                {
                    MateriaNode Materia = Departamento.Materias;
                    while (Materia != null)
                    {
                        if (Materia.Nombre == nombreMateria)
                        {
                            // Actualizar la materia con los nuevos datos
                            Materia.Codigo = Datos.Codigo;
                            Materia.Nombre = Datos.Nombre;
                            Materia.Descripcion = Datos.Descripcion;
                            break;
                        }
                        Materia = Materia.Next;
                    }
                    break;
                }
                Departamento = Departamento.Next;
            }
        }
        public void EliminarMateria(string nombreDepartamento, string nombreMateria)
        {
            Departamento Departamento = inicio;
            while (Departamento != null)
            {
                if (Departamento.Nombre == nombreDepartamento)
                {
                    MateriaNode previousMateria = null;
                    MateriaNode Materia = Departamento.Materias;
                    while (Materia != null)
                    {
                        if (Materia.Nombre == nombreMateria)
                        {
                            if (previousMateria == null)
                            {
                                Departamento.Materias = Materia.Next;
                            }
                            else
                            {
                                previousMateria.Next = Materia.Next;
                            }
                            break;
                        }
                        previousMateria = Materia;
                        Materia = Materia.Next;
                    }
                    break;
                }
                Departamento = Departamento.Next;
            }
        }
        #endregion
        /////////////////////////////    METODOS PARA LOS ESTUDIANTES    ///////////////////////////// 
        public void AgregarEstudiante(string nombreDepartamento, string nombreMateria, EstudianteNode Datos)
        {
            Departamento Departamento = inicio;
            while (Departamento != null)
            {
                if (Departamento.Nombre == nombreDepartamento)
                {
                    MateriaNode Materia = Departamento.Materias;
                    while (Materia != null)
                    {
                        if (Materia.Nombre == nombreMateria)
                        {
                            EstudianteNode primerEstudiante = Datos;
                            if (Materia.Estudiantes == null)
                            {
                                Materia.Estudiantes = primerEstudiante;
                            }
                            else
                            {
                                EstudianteNode nuevoEstudiante = Materia.Estudiantes;
                                while (nuevoEstudiante.Next != null)
                                {
                                    nuevoEstudiante = nuevoEstudiante.Next;
                                }
                                nuevoEstudiante.Next = primerEstudiante;
                            }
                            break;
                        }
                        Materia = Materia.Next;
                    }
                    break;
                }
                Departamento = Departamento.Next;
            }
        }
        public void AgregarEstudiantesADataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            Departamento departamento = inicio;
            while (departamento != null)
            {
                MateriaNode materia = departamento.Materias;
                while (materia != null)
                {
                    EstudianteNode Estudiante = materia.Estudiantes;
                    while (Estudiante != null)
                    {
                        dataGridView.Rows.Add(Estudiante.Cedula, Estudiante.Nombre, Estudiante.Apellido, Estudiante.Seccion, Estudiante.Periodo, Estudiante.Materia, Estudiante.Departamento, Estudiante.Nota);
                        Estudiante = Estudiante.Next;
                    }
                    materia = materia.Next;
                }
                departamento = departamento.Next;
            }
        }
        public void MostrarMateriasAComboBox(string nombreDepartamento, ComboBox comboBoxMaterias, ComboBox comboBoxDepartamentos)
        {
            comboBoxMaterias.Items.Clear();

            string selectedDepartamento = comboBoxDepartamentos.Text;

            Departamento departamento = inicio;
            while (departamento != null)
            {
                if (departamento.Nombre == selectedDepartamento)
                {
                    MateriaNode materia = departamento.Materias;
                    while (materia != null)
                    {
                        comboBoxMaterias.Items.Add(materia.Nombre);
                        materia = materia.Next;
                    }
                    break;
                }
                departamento = departamento.Next;
            }
        }
        public void ModificarNotaEstudiante(string nombreEstudiante, string materia, string departamento, float nuevaNota)
        {
            Departamento departamentoActual = inicio;
            while (departamentoActual != null)
            {
                if (departamentoActual.Nombre == departamento)
                {
                    MateriaNode materiaActual = departamentoActual.Materias;
                    while (materiaActual != null)
                    {
                        if (materiaActual.Nombre == materia)
                        {
                            EstudianteNode estudiante = materiaActual.Estudiantes;
                            while (estudiante != null)
                            {
                                if (estudiante.Nombre == nombreEstudiante)
                                {
                                    estudiante.Nota = nuevaNota;
                                    return;
                                }
                                estudiante = estudiante.Next;
                            }
                        }
                        materiaActual = materiaActual.Next;
                    }
                }
                departamentoActual = departamentoActual.Next;
            }

            MessageBox.Show("Estudiante no encontrado en la lista.");
        }
        public void EliminarEstudiante(string nombreEstudiante, string departamento, string materia)
        {
            Departamento departamentoActual = inicio;
            while (departamentoActual != null)
            {
                if (departamentoActual.Nombre == departamento)
                {
                    MateriaNode materiaActual = departamentoActual.Materias;
                    while (materiaActual != null)
                    {
                        if (materiaActual.Nombre == materia)
                        {
                            EstudianteNode estudianteAnterior = null;
                            EstudianteNode estudianteActual = materiaActual.Estudiantes;

                            while (estudianteActual != null)
                            {
                                if (estudianteActual.Nombre == nombreEstudiante)
                                {
                                    if (estudianteAnterior == null)
                                    {
                                        materiaActual.Estudiantes = estudianteActual.Next;
                                    }
                                    else
                                    {
                                        estudianteAnterior.Next = estudianteActual.Next;
                                    }
                                    return;
                                }

                                estudianteAnterior = estudianteActual;
                                estudianteActual = estudianteActual.Next;
                            }
                        }
                        materiaActual = materiaActual.Next;
                    }
                }
                departamentoActual = departamentoActual.Next;
            }

            MessageBox.Show("Estudiante no encontrado en la lista.");
        }
    }

    public class Departamento
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public MateriaNode Materias { get; set; }
        public Departamento Next { get; set; }
        public Departamento Previous { get; set; }

        public Departamento() { }
        public Departamento(Departamento Datos)
        {
            Codigo = Datos.Codigo;
            Nombre = Datos.Nombre;
            Descripcion = Datos.Descripcion;
        }
    }
    public class MateriaNode
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Departamento { get; set; }
        public int Creditos { get; set; }
        public EstudianteNode Estudiantes { get; set; }
        public MateriaNode Next { get; set; }
        
        public MateriaNode() { }
        public MateriaNode(MateriaNode Datos)
        {
            Codigo = Datos.Codigo;
            Nombre = Datos.Nombre;
            Descripcion = Datos.Nombre;
        }
    }
    public class EstudianteNode
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Seccion { get; set; }
        public string Periodo { get; set; }
        public float Nota { get; set; }
        public string Materia { get; set; }
        public string Departamento { get; set; }
        public EstudianteNode Next { get; set; }
        public EstudianteNode() { }
        public EstudianteNode(EstudianteNode Datos)
        {
            Cedula = Datos.Cedula;
            Nombre = Datos.Nombre;
            Apellido = Datos.Apellido;
            Seccion = Datos.Seccion;
            Periodo = Datos.Periodo;
            Nota = Datos.Nota;
        }
    }
}