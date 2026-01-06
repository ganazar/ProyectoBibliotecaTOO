using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FListadoGenerico : Form
    {
        public FListadoGenerico()
        {
            InitializeComponent();
        }
        public FListadoGenerico(object fuenteDatos, string tituloVentana)
        {
            InitializeComponent();
            this.Text = "Listado de " + tituloVentana;

            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;

            dgvDatos.DataSource = fuenteDatos;
            }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
