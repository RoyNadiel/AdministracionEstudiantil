using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministraciónEstudiantil
{
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
        public EstudianteNode Estudiantes { get; set; }
        public MateriaNode Next { get; set; }
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
    public class GestionListas
    {
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
        public void ModificarDepartamento(string nombreDepartamento, string nuevoNombre)
        {
            Departamento departamento = ObtenerDepartamento(nombreDepartamento);
            while (departamento != null)
            {
                if (departamento.Nombre == nombreDepartamento)
                {
                    departamento.Nombre = nuevoNombre;
                }
                departamento = departamento.Next;
            }
        }
        public void MostrarDepartamentosIF()
        {
            Departamento departamento = inicio;

            if (departamento == null)
            {
                MessageBox.Show("No existe ningun departamento");
            }
            while (departamento != null)
            {
                MessageBox.Show($"Departamentos disponibles: {departamento.Nombre}");
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
                    MessageBox.Show($"Departamento {nombreDepartamento} eliminado correctamente.");
                }
                departamentoAnterior = departamentoActual;
                departamentoActual = departamentoActual.Next;
            }            
        }
    }
}
