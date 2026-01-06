using LogicaNegocio;
using LogicaNegocio.InterfacesLN;
using Persistencia;
using Persistencia.Interfaces;
using Presentacion.PersonalSala;
using Presentacion.PersonalAdquisiciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia.Repositorios;
using LogicaNegocio.ClasesLN;

namespace Presentacion
{
    public partial class Login : Form
    {
        private readonly IPersistenciaPersonal persistencia;

        public Login( IPersistenciaPersonal _persistencia)
        {
            InitializeComponent();
            persistencia = _persistencia;
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbContraseña.Text))
            {
                MessageBox.Show("Debe introducir un usuario y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNombre.Text = string.Empty;
                tbContraseña.Text = string.Empty;
                tbNombre.Focus();
            } else
            {
                string nombre = tbNombre.Text;
                if (rbPersonalSala.Checked)
                {
                    ILNPersonalSala logica =  new LNPersonalSala(new PersistenciaSala());
                    FPrincipalSala form = new FPrincipalSala(nombre, logica);
                    form.Show();
                }
                else if (rbPersonalAdquisicion.Checked)
                {
                    ILNPersonalAdquisiciones logica = new LNPersonalAdquisiciones(new PersistenciaAdquisiciones());
                    FPrincipalAdquisicion form = new FPrincipalAdquisicion(nombre, logica);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Seleccione un tipo de empleado.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
