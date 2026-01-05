using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Presentacion.Personal
{
    public partial class FIntroducirClave : Form
    {
        private string clave;
        public string Clave { get { return clave; }}
        public FIntroducirClave(string nombre)
        {
            InitializeComponent();
            Text = "Introducir " + nombre;
            lbClave.Text = nombre;
            tbClave.Focus();
        }
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbClave.Text))
            {
                MessageBox.Show("Introduzca un DNI","Error");
                return;
            }

            clave = tbClave.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FIntroducirClave_Load(object sender, EventArgs e)
        {

        }
    }
}
