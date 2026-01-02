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
    public partial class FBusquedaUsuario : Form
    {
        private LogicaNegocio.InterfacesLN.ILNPersonal _logica;
        private string DNI;
        public FBusquedaUsuario(string dni, ILNPersonal logica)
        {
            InitializeComponent();
            DNI = dni;
            _logica = logica;
            
            tbDNI.Text = DNI;
            tbDNI.Enabled = false;
            tbNombre.Text = logica.ConsultarUsuarioPorDni(DNI).Nombre;
            tbNombre.Enabled = false;
        }

        private void FBusquedaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
