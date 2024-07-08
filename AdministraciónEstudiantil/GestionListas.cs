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
    public class GestionListas
    {
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
            //dataGridView.ColumnCount = 3;
            //dataGridView.Columns[0].Name = "CODIGO";
            //dataGridView.Columns[1].Name = "NOMBRE";
            //dataGridView.Columns[2].Name = "DESCRIPCION";
            //dataGridView.Columns["CODIGO"].Width = 100;
            //dataGridView.Columns["NOMBRE"].Width = 100;
            //dataGridView.Columns["DESCRIPCION"].Width = 300;

            Departamento Departamento = inicio;
            while (Departamento != null)
            {
                dataGridView.Rows.Add(Departamento.Codigo, Departamento.Nombre, Departamento.Descripcion);
                Departamento = Departamento.Next;
            }
        }
        #endregion

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
        public EstudianteNode Estudiantes { get; set; }
        public MateriaNode Next { get; set; }
        
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
        public EstudianteNode Next { get; set; }
    }
}
