using System;
using System.Windows.Forms;

namespace AdministraciónEstudiantil
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Presentacion ventana = new Presentacion();
            //ventana.ShowDialog();
            Application.Run(new Administracion());
        }
    }
}