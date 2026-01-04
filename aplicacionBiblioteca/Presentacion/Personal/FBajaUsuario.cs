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

namespace Presentacion.Personal
{
    public partial class FBajaUsuario : Form
    {
        /*
         public string Dni { set { txtDNI.Text = value; } }
         public string Nombre { set { txtNombre.Text = value; } }         
        */
        public FBajaUsuario(Usuario u) //PREGUNTAR SI ES MEJOR PASAR NOMBRE;DNI
        {
            InitializeComponent();
            tbDNI.Text = u.DNI;
            tbDNI.Enabled = false;
            tbNombre.Text = u.Nombre;
            tbNombre.Enabled = false;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que quiere dar de baja al usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.DialogResult = respuesta;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
