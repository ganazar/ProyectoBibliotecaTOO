using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Personal
{
    public partial class FIntroducirDNI : Form
    {
        private string dni;
        public string Dni { get { return dni; }}
        public FIntroducirDNI()
        {
            InitializeComponent();
            tbDNI.Focus();
        }
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDNI.Text))
            {
                MessageBox.Show("Introduzca un DNI","Error");
            }

            dni = tbDNI.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Cancel;
            this.Close();
        }

        private void FIntroducirDNI_Load(object sender, EventArgs e)
        {

        }
    }
}
