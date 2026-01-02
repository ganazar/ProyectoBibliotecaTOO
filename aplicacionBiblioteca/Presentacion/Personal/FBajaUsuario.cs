using LogicaNegocio.InterfacesLN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Personal
{
    public partial class FBajaUsuario : Form
    {
        private LogicaNegocio.InterfacesLN.ILNPersonal _logica;
        private string DNI;
        public FBajaUsuario(string dni, ILNPersonal logica)
        {
            InitializeComponent();
            DNI = dni;
            _logica = logica;

            tbDNI.Text = DNI;
            tbDNI.Enabled = false;
            tbNombre.Text = logica.ConsultarUsuarioPorDni(DNI).Nombre;
            tbNombre.Enabled = false;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que quiere dar de baja al usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (_logica.DarBajaUsuario(new modeloDominio.Usuario(DNI)))
                {
                    MessageBox.Show("Usuario correctamente eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
