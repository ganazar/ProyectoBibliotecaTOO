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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Personal
{
    public partial class FPrincipal : Form
    {
        protected LogicaNegocio.InterfacesLN.ILNPersonal _logica;

        public FPrincipal()
        {
            InitializeComponent();
        }
        public FPrincipal(string nombre, LogicaNegocio.InterfacesLN.ILNPersonal logica) : this()
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
                    if (!DniValido(f.Clave))
                    {
                        MessageBox.Show("El formato del DNI no es válido o la letra es incorrecta.\nEjemplo: 12345678Z",
                                        "DNI Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    FUsuarios fAlta = new FUsuarios(f.Clave,"", TipoForm.Alta);
                    fAlta.ShowDialog();
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
                    FUsuarios fBaja = new FUsuarios(u.DNI, u.Nombre, TipoForm.Baja);
                    DialogResult result = fBaja.ShowDialog();
                    if (result == DialogResult.OK)
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
            bool continuar = true;
            do {
                FIntroducirClave f = new FIntroducirClave("DNI");

                if (f.ShowDialog() != DialogResult.OK)
                {
                    continuar = false;
                    break;
                }

                if (!DniValido(f.Clave))
                {
                    MessageBox.Show("El formato del DNI no es válido.\nEjemplo: 12345678Z",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                Usuario u = _logica.ConsultarUsuarioPorDni(f.Clave);

                if (u != null)
                {
                    FUsuarios fBusqueda = new FUsuarios(u.DNI, u.Nombre, TipoForm.Busqueda);
                    fBusqueda.ShowDialog();

                    continuar = false;
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show(
                        "No existe un usuario con este DNI.\n¿Quieres introducir otro?",
                        "Búsqueda fallida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (respuesta == DialogResult.No)
                    {
                        continuar = false;
                    } else
                    {
                        f.Close();
                    }
                }

            } while (continuar);
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

        /// <summary>
        /// Verifica si una cadena de texto cumple con el formato oficial del DNI español.
        /// </summary>
        /// <param name="dni">La cadena que contiene el DNI a validar.</param>
        /// <returns>
        /// <c>true</c> si tiene 8 dígitos seguidos de la letra de control correcta(modulo 23); 
        /// <c>false</c> si el formato es incorrecto o la letra no coincide con el algoritmo matemático.
        /// </returns>
        private bool DniValido(string dni)
        {
            if (!Regex.IsMatch(dni, @"^\d{8}[A-Z]$"))
            {
                return false;
            }

            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            int numero = int.Parse(dni.Substring(0, 8));

            return letras[numero % 23] == dni[8];
        }
    }
}

