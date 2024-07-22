
namespace AdministraciónEstudiantil.Reportes
{
    partial class SegundoReporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvNuevo = new System.Windows.Forms.DataGridView();
            this.cbxPeriodos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(831, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "BUSCAR MATERIA CON MAS ESTUDIANTES INSCRITOS EN UN PERIODO ESPECIFICO";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Enabled = false;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(177, 65);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 26);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "BUSCAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvNuevo
            // 
            this.dgvNuevo.AllowUserToAddRows = false;
            this.dgvNuevo.AllowUserToDeleteRows = false;
            this.dgvNuevo.AllowUserToResizeColumns = false;
            this.dgvNuevo.AllowUserToResizeRows = false;
            this.dgvNuevo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNuevo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNuevo.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvNuevo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNuevo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Small", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNuevo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNuevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNuevo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNuevo.EnableHeadersVisualStyles = false;
            this.dgvNuevo.Location = new System.Drawing.Point(0, 102);
            this.dgvNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.dgvNuevo.Name = "dgvNuevo";
            this.dgvNuevo.ReadOnly = true;
            this.dgvNuevo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNuevo.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Small", 9F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvNuevo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNuevo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNuevo.Size = new System.Drawing.Size(891, 236);
            this.dgvNuevo.TabIndex = 9;
            // 
            // cbxPeriodos
            // 
            this.cbxPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPeriodos.FormattingEnabled = true;
            this.cbxPeriodos.Location = new System.Drawing.Point(18, 65);
            this.cbxPeriodos.Name = "cbxPeriodos";
            this.cbxPeriodos.Size = new System.Drawing.Size(153, 26);
            this.cbxPeriodos.TabIndex = 10;
            this.cbxPeriodos.SelectedIndexChanged += new System.EventHandler(this.cbxPeriodos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "PERIODO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "LISTA DE ESTUDIANTES";
            // 
            // SegundoReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(891, 338);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPeriodos);
            this.Controls.Add(this.dgvNuevo);
            this.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SegundoReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SegundoReporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvNuevo;
        private System.Windows.Forms.ComboBox cbxPeriodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}