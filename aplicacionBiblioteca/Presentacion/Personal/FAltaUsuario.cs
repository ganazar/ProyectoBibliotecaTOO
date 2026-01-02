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
using LogicaNegocio.InterfacesLN;

namespace Presentacion.Personal
{
    public partial class FAltaUsuario : Form
    {
        private LNPersonal _logica;
        public FAltaUsuario()
        {
            InitializeComponent();
            _logica = new LNPersonal();
        }

        private void FAltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
            //Formato del DNI
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if()
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
