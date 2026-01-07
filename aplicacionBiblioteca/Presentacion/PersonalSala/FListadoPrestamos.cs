using modeloDominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.PersonalSala
{
    public partial class FListadoPrestamos : Form
    {
        public FListadoPrestamos(List<Prestamo> prestamos)
        {
            InitializeComponent();

            BindingSource binding = new BindingSource();
            binding.DataSource = prestamos;
            dataGridView1.DataSource = binding;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Usuario",
                HeaderText = "Usuario (DNI)",
                ReadOnly = true,
                Width = 100
            });

            // Columna para la Fecha
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaPrestamo",
                HeaderText = "Fecha de Inicio",
                ReadOnly = true,
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });

            // Columna para el Estado
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado Actual",
                ReadOnly = true
            });

            // Columna para ver cuántos ejemplares hay en ese préstamo
            // Asumiendo que Ejemplares es una List, podemos mostrar el conteo
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CantidadEjemplares",
                HeaderText = "Nº Ejemplares",
                ReadOnly = true
            });
        }
    }
}