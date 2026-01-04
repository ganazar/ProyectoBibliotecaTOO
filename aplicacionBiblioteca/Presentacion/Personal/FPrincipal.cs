using LogicaNegocio;
using modeloDominio;
using Persistencia;
using Presentacion.Personal;
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
    public partial class FPrincipal : Form
    {
        protected LogicaNegocio.InterfacesLN.ILNPersonal _logica;

        protected FPrincipal()
        {
            InitializeComponent();
        }
        protected FPrincipal(string nombre, LogicaNegocio.InterfacesLN.ILNPersonal logica) : this()
        {
            this.Text = nombre + "Gestión de biblioteca";
            _logica = logica;
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FIntroducirClave f = new FIntroducirClave("DNI");
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                if (_logica.ConsultarUsuarioPorDni(f.Clave) == null)
                {
                    FAltaUsuario fAlta = new FAltaUsuario(f.Clave, _logica);
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres introducir otro?", "Ya existe un usuario con este DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        f.ShowDialog();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            } 
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FIntroducirClave f = new FIntroducirClave("DNI");
            f.ShowDialog();
            if(f.DialogResult == DialogResult.OK)
            {
                if (_logica.ConsultarUsuarioPorDni(f.Clave) != null)
                {
                    FBusquedaUsuario fBusqueda = new FBusquedaUsuario(f.Clave, _logica);
                    fBusqueda.ShowDialog();
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres introducir otro?", "No existe un usuario con este DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        f.ShowDialog();
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
        }
    }
}

