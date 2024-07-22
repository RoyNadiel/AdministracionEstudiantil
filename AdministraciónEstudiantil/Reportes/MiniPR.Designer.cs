
namespace AdministraciónEstudiantil.Reportes
{
    partial class MiniPR
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CEDULA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOMBRE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.APELLIDO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SECCION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PERIODO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MATERIA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DEPARTAMENTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 14F);
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTUDIANTES INSCRITOS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 11F);
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "CEDULA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 11F);
            this.label3.Location = new System.Drawing.Point(160, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 11F);
            this.label4.Location = new System.Drawing.Point(290, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "APELLIDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 11F);
            this.label5.Location = new System.Drawing.Point(421, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "SECCION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 11F);
            this.label6.Location = new System.Drawing.Point(550, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "PERIODO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 11F);
            this.label7.Location = new System.Drawing.Point(680, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "MATERIA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 11F);
            this.label8.Location = new System.Drawing.Point(810, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "DEPARTAMENTO";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Azure;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CEDULA,
            this.NOMBRE,
            this.APELLIDO,
            this.SECCION,
            this.PERIODO,
            this.MATERIA,
            this.DEPARTAMENTO});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(123, 169);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(691, 97);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // CEDULA
            // 
            this.CEDULA.Text = "CEDULA";
            this.CEDULA.Width = 86;
            // 
            // NOMBRE
            // 
            this.NOMBRE.Text = "NOMBRE";
            this.NOMBRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NOMBRE.Width = 86;
            // 
            // APELLIDO
            // 
            this.APELLIDO.Text = "APELLIDO";
            this.APELLIDO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.APELLIDO.Width = 92;
            // 
            // SECCION
            // 
            this.SECCION.Text = "SECCION";
            this.SECCION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SECCION.Width = 79;
            // 
            // PERIODO
            // 
            this.PERIODO.Text = "PERIODO";
            this.PERIODO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PERIODO.Width = 80;
            // 
            // MATERIA
            // 
            this.MATERIA.Text = "MATERIA";
            this.MATERIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MATERIA.Width = 127;
            // 
            // DEPARTAMENTO
            // 
            this.DEPARTAMENTO.Text = "DEPARTAMENTO";
            this.DEPARTAMENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DEPARTAMENTO.Width = 137;
            // 
            // MiniPR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(985, 104);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiniPR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniPR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CEDULA;
        private System.Windows.Forms.ColumnHeader NOMBRE;
        private System.Windows.Forms.ColumnHeader APELLIDO;
        private System.Windows.Forms.ColumnHeader SECCION;
        private System.Windows.Forms.ColumnHeader PERIODO;
        private System.Windows.Forms.ColumnHeader MATERIA;
        private System.Windows.Forms.ColumnHeader DEPARTAMENTO;
    }
}