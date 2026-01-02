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
        private LogicaNegocio.InterfacesLN.ILNPersonal _logica;
        private string DNI;
        public FAltaUsuario(string dni, LogicaNegocio.InterfacesLN.ILNPersonal logica)
        {
            InitializeComponent();
            _logica = logica;
            DNI = dni;
            tbDNI.Text = DNI;
            tbDNI.Enabled = false;
        }

        private void FAltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                MessageBox.Show("Debes introducir un nombre para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (_logica.DarAltaUsuario(new modeloDominio.Usuario(DNI, tbNombre.Text))){
                    MessageBox.Show("Usuario añadido correctamente", "", MessageBoxButtons.OK);
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
