using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia;
using LogicaNegocio;

namespace Presentacion.Personal
{
    public partial class FAltaUsuario : Form
    {
        public string Dni { get { return tbDNI.Text; } }
        public string Nombre { get { return tbNombre.Text; } }
        public FAltaUsuario(string dni)
        {
            InitializeComponent();
            tbDNI.Text = dni;
            tbDNI.Enabled = false;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                MessageBox.Show("Debes introducir un nombre para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
