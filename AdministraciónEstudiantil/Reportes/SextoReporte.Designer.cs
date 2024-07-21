
namespace AdministraciónEstudiantil.Reportes
{
    partial class SextoReporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvNuevo = new System.Windows.Forms.DataGridView();
            this.CEDULAGEST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREGEST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTAGEST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCedula = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevo)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "LISTA DE ESTUDIANTES";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Small", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNuevo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNuevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNuevo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CEDULAGEST,
            this.NOMBREGEST,
            this.NOTAGEST});
            this.dgvNuevo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNuevo.EnableHeadersVisualStyles = false;
            this.dgvNuevo.Location = new System.Drawing.Point(0, 102);
            this.dgvNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.dgvNuevo.Name = "dgvNuevo";
            this.dgvNuevo.ReadOnly = true;
            this.dgvNuevo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNuevo.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sitka Small", 9F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvNuevo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNuevo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNuevo.Size = new System.Drawing.Size(891, 236);
            this.dgvNuevo.TabIndex = 25;
            // 
            // CEDULAGEST
            // 
            this.CEDULAGEST.HeaderText = "CEDULA";
            this.CEDULAGEST.Name = "CEDULAGEST";
            this.CEDULAGEST.ReadOnly = true;
            // 
            // NOMBREGEST
            // 
            this.NOMBREGEST.HeaderText = "NOMBRE";
            this.NOMBREGEST.Name = "NOMBREGEST";
            this.NOMBREGEST.ReadOnly = true;
            // 
            // NOTAGEST
            // 
            this.NOTAGEST.HeaderText = "NOTA";
            this.NOTAGEST.Name = "NOTAGEST";
            this.NOTAGEST.ReadOnly = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(191, 73);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(85, 26);
            this.btnCalcular.TabIndex = 29;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "CEDULA DEL ESTUDIANTE:";
            // 
            // cbxCedula
            // 
            this.cbxCedula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCedula.FormattingEnabled = true;
            this.cbxCedula.Location = new System.Drawing.Point(12, 73);
            this.cbxCedula.Name = "cbxCedula";
            this.cbxCedula.Size = new System.Drawing.Size(173, 26);
            this.cbxCedula.TabIndex = 27;
            this.cbxCedula.SelectedIndexChanged += new System.EventHandler(this.cbxCedula_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(627, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "MOSTRAR NOTA MAYOR DE UN ESTUDIANTE DADA SU CEDULA";
            // 
            // SextoReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(891, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvNuevo);
            this.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SextoReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SextoReporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvNuevo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULAGEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREGEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTAGEST;
        private System.Windows.Forms.Label label3;
    }
}