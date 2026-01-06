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
    public enum TipoForm
    {
        Alta,       
        Baja,       
        Busqueda    
    }

    public partial class FUsuarios : Form
    {
        private TipoForm tipo;
        public string Dni { get { return tDNI.Text; } }
        public string Nombre { get { return tNombre.Text; } }
        public FUsuarios()
        {
            InitializeComponent();
        }

        public FUsuarios(string dni, string nombre, TipoForm t)
        {
            InitializeComponent();
            tipo = t;

            tDNI.Text = dni;
            tNombre.Text = nombre;

            ConfigurarPantalla();
        }

        private void ConfigurarPantalla()
        {
            switch (tipo)
            {
                case TipoForm.Alta:
                    this.Text = "Alta de Usuario";
                    tDNI.ReadOnly = true;     
                    tNombre.ReadOnly = false; 
                    break;

                case TipoForm.Baja:
                    this.Text = "Baja de Usuario";
                    tDNI.ReadOnly = true;
                    tNombre.ReadOnly = true;  
                    break;

                case TipoForm.Busqueda:
                    this.Text = "Consulta de Usuario";
                    tDNI.ReadOnly = true;
                    tNombre.ReadOnly = true;
                    btCancelar.Visible = false;
                    btAceptar.Text = "Cerrar";
                    break;
            }
        }
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (tipo == TipoForm.Alta && string.IsNullOrWhiteSpace(tNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            if (tipo == TipoForm.Baja)
            {
                if (MessageBox.Show("¿Está seguro que quiere dar de baja al usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}