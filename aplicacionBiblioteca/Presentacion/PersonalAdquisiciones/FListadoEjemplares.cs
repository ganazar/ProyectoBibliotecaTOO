using modeloDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.PersonalAdquisiciones
{
    public partial class FListadoEjemplares : Form
    {
        public FListadoEjemplares(List<Ejemplar> ejemplares)
        {
            InitializeComponent();

            BindingSource binding = new BindingSource();
            binding.DataSource = ejemplares;
            dataGridView1.DataSource = binding;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CodEjemplar",
                HeaderText = "Código",
                ReadOnly = true
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ISBN",
                HeaderText = "Documento (ISBN)",
                ReadOnly = true
            });
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Prestado",
                HeaderText = "Prestado",
                ReadOnly = true
            });
        }
    }
}
