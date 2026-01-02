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

namespace Presentacion
{
    public abstract partial class FPrincipal : Form
    {
        private LogicaNegocio.InterfacesLN.ILNPersonal _logica;
        public FPrincipal(Usuario u)
        {
            InitializeComponent();
            this.Text = u.Nombre + "Gestión de biblioteca";
            IPersistenciaPersonal persistencia = new Persistencia.Repositorios.PersistenciaPersonal();
            _logica = new LNPersonal(persistencia);
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FIntroducirDNI f = new FIntroducirDNI();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                if (_logica.ConsultarUsuarioPorDni(f.Dni) == null)
                {
                    FAltaUsuario fAlta = new FAltaUsuario(f.Dni, _logica);
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
            FIntroducirDNI f = new FIntroducirDNI();
            f.ShowDialog();
            if(f.DialogResult == DialogResult.OK)
            {
                if (_logica.ConsultarUsuarioPorDni(f.Dni) != null)
                {
                    FBusquedaUsuario fBusqueda = new FBusquedaUsuario(f.Dni, _logica);
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

