
namespace AdministraciónEstudiantil
{
    partial class GestionEST
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestion
            // 
            this.btnGestion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGestion.Location = new System.Drawing.Point(537, 440);
            this.btnGestion.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(135, 69);
            this.btnGestion.TabIndex = 4;
            this.btnGestion.Text = "Gestion";
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // GestionEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 519);
            this.Controls.Add(this.btnGestion);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionEST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionEST";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionEST_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestion;
    }
}