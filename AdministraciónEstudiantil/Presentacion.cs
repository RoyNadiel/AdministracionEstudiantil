using System;
using System.Windows.Forms;

namespace AdministraciónEstudiantil
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 4000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer timer = sender as Timer;
            timer.Stop();
            timer.Dispose();
            this.Close();
        }
    }
}
