﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AdministraciónEstudiantil
{
    public partial class PrimerReporte : Form
    {
        DataGridView dgvMateria = new DataGridView();
        public PrimerReporte(DataGridView dgvEstudiantes, DataGridView dgvMaterias)
        {
            InitializeComponent();
            RecibirEstudiantes(dgvEstudiantes);
            RecibirMaterias(dgvMaterias);

            MostrarMateriasCBX(dgvMateria, 1, cbxMaterias);
            MostrarPeriodosCBX(dgvEstudiantes, 4, cbxPeriodos);
        }
        private void RecibirEstudiantes(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                dgvNuevo.Columns.Add(col.Clone() as DataGridViewColumn);
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    newRow.Cells[i].Value = row.Cells[i].Value;
                }
                dgvNuevo.Rows.Add(newRow);
            }
        }
        private void RecibirMaterias(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                dgvMateria.Columns.Add(col.Clone() as DataGridViewColumn);
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    newRow.Cells[i].Value = row.Cells[i].Value;
                }
                dgvMateria.Rows.Add(newRow);
            }
        }
        private void MostrarMateriasCBX(DataGridView dataGridView, int columnIndex, ComboBox comboBox)
        {
            comboBox.Items.Clear();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow && row.Cells[columnIndex].Value != null)
                {
                    comboBox.Items.Add(row.Cells[columnIndex].Value.ToString());
                }
            }
        }
        private void MostrarPeriodosCBX(DataGridView dataGridView, int columnIndex, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            HashSet<string> itemsSet = new HashSet<string>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow && row.Cells[columnIndex].Value != null)
                {
                    string item = row.Cells[columnIndex].Value.ToString();
                    if (!itemsSet.Contains(item))
                    {
                        comboBox.Items.Add(item);
                        itemsSet.Add(item);
                    }
                }
            }
        }             
        private void cbxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDataGridView();            
        }
        private void FiltrarDataGridView()
        {
            if (cbxPeriodos.Text != "" && cbxMaterias.Text != "")
            {
                string periodo = cbxPeriodos.SelectedItem.ToString();
                string materia = cbxMaterias.SelectedItem.ToString();
                foreach (DataGridViewRow fila in dgvNuevo.Rows)
                {
                    if (fila.Cells[4].Value != null && fila.Cells[5].Value != null && fila.Cells[4].Value.ToString() == periodo && fila.Cells[5].Value.ToString() == materia)
                    {
                        fila.Visible = true;
                    }
                    else
                    {
                        fila.Visible = false;
                    }
                }
            }
        }

        private void cbxPeriodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDataGridView();
        }
    }
}

