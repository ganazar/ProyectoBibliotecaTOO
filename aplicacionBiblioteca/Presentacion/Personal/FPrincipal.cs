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
            this.Text = nombre + " - Gestión de biblioteca";
            _logica = logica;
        }
        private Dictionary<string, string> ListadoADiccionario(List<Usuario> lista)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (Usuario u in lista)
            {
                dic.Add(u.DNI, u.Nombre);
            }
            return dic;
        }
        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FIntroducirClave f = new FIntroducirClave("DNI");
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                if (_logica.ConsultarUsuarioPorDni(f.Clave) == null)
                {
                    FAltaUsuario fAlta = new FAltaUsuario(f.Clave);
                    if (fAlta.DialogResult == DialogResult.OK)
                    {
                        Usuario u = new Usuario(fAlta.Dni, fAlta.Nombre);
                        if (_logica.DarAltaUsuario(u))
                        {
                            MessageBox.Show("Usuario registrado con éxito");
                        } else
                        {
                            MessageBox.Show("Error al registrar el usuario");
                        }
                    }
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
                        return;
                    }
                }
            } 
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FIntroducirClave f = new FIntroducirClave("DNI");
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                Usuario u = _logica.ConsultarUsuarioPorDni(f.Clave);
                if (u != null)
                {
                    FBajaUsuario fBaja = new FBajaUsuario(u);
                    /*
                    fBaja.Dni = u.DNI;
                    fBaja.Nombre = u.Nombre;
                    */
                    DialogResult result = fBaja.ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        if (_logica.DarBajaUsuario(u))
                        {
                            MessageBox.Show("Usuario eliminado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el usuario");
                        }
                    }
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
                        return;
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
                Usuario u = _logica.ConsultarUsuarioPorDni(f.Clave);
                if (u !=null)
                {
                    FBusquedaUsuario fBusqueda = new FBusquedaUsuario();
                    fBusqueda.Dni = u.DNI;
                    fBusqueda.Nombre = u.Nombre;
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
                        return;
                    }
                }

            }
        }
        private void búsquedaPorDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Usuario> listadoUsuarios = _logica.GetAllUsuarios();
            Dictionary<string, string> dicUsuarios = new Dictionary<string, string>();
            foreach (Usuario u in listadoUsuarios)
            {
                dicUsuarios.Add(u.DNI, u.Nombre);
            }

            FBusquedaDni f = new FBusquedaDni(dicUsuarios);
            f.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listadoUsuarios = _logica.GetAllUsuarios();
            Dictionary<string, string> dicUsuarios = ListadoADiccionario(listadoUsuarios);
            
            if (listadoUsuarios.Count == 0)
            {
                MessageBox.Show("No hay datos para mostar");
            }
            else
            {
                FListado f = new FListado(dicUsuarios);
                f.ShowDialog();
            }
        }

        private void recorridoUnoAUnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listadoUsuarios = _logica.GetAllUsuarios();
            Dictionary<string, string> dicUsuarios = ListadoADiccionario(listadoUsuarios);
            
            FRecorrido f = new FRecorrido(dicUsuarios);
            f.Show();
        }
    }
}

