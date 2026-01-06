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

namespace Presentacion.PersonalAdquisiciones
{
    public partial class FBusquedaEjemplar : Form
    {
        public FBusquedaEjemplar(Ejemplar ejemplar)
        {
            InitializeComponent();
            tbCodigo.Text = ejemplar.CodEjemplar;
            tbCodigo.ReadOnly = true;
            tbISBN.Text = ejemplar.Doc.ISBN;
            tbISBN.ReadOnly = true;
            rbPrestado.Checked = ejemplar.Prestado;
            rbPrestado.Enabled = false;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
