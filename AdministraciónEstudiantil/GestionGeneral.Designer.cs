
namespace AdministraciónEstudiantil
{
    partial class GestionGeneral
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionGeneral));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnDepartamentos = new System.Windows.Forms.Button();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnMaterias
            // 
            this.btnMaterias.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnMaterias, "btnMaterias");
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.UseVisualStyleBackColor = true;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnDepartamentos, "btnDepartamentos");
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.UseVisualStyleBackColor = true;
            this.btnDepartamentos.Click += new System.EventHandler(this.btnDepartamentos_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnEstudiantes, "btnEstudiantes");
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // GestionGeneral
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEstudiantes);
            this.Controls.Add(this.btnDepartamentos);
            this.Controls.Add(this.btnMaterias);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionGeneral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnDepartamentos;
        private System.Windows.Forms.Button btnEstudiantes;
    }
}

