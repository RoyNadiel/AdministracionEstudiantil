
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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // btnMaterias
            // 
            resources.ApplyResources(this.btnMaterias, "btnMaterias");
            this.btnMaterias.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMaterias.FlatAppearance.BorderSize = 0;
            this.btnMaterias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.UseVisualStyleBackColor = true;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnDepartamentos
            // 
            resources.ApplyResources(this.btnDepartamentos, "btnDepartamentos");
            this.btnDepartamentos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDepartamentos.FlatAppearance.BorderSize = 0;
            this.btnDepartamentos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.UseVisualStyleBackColor = true;
            this.btnDepartamentos.Click += new System.EventHandler(this.btnDepartamentos_Click);
            // 
            // btnEstudiantes
            // 
            resources.ApplyResources(this.btnEstudiantes, "btnEstudiantes");
            this.btnEstudiantes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEstudiantes.FlatAppearance.BorderSize = 0;
            this.btnEstudiantes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelLateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLateral.Controls.Add(this.btnEstudiantes);
            this.panelLateral.Controls.Add(this.btnDepartamentos);
            this.panelLateral.Controls.Add(this.btnMaterias);
            this.panelLateral.Controls.Add(this.panelUsuario);
            resources.ApplyResources(this.panelLateral, "panelLateral");
            this.panelLateral.Name = "panelLateral";
            // 
            // panelUsuario
            // 
            this.panelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsuario.Controls.Add(this.label1);
            resources.ApplyResources(this.panelUsuario, "panelUsuario");
            this.panelUsuario.Name = "panelUsuario";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.DarkBlue;
            resources.ApplyResources(this.panelPrincipal, "panelPrincipal");
            this.panelPrincipal.Name = "panelPrincipal";
            // 
            // GestionGeneral
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionGeneral";
            this.panelLateral.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnDepartamentos;
        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}

