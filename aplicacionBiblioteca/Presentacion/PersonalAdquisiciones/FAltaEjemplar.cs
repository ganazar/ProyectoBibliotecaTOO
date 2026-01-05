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
    public partial class FAltaEjemplar : Form
    {
        private Documento doc = null;
        private bool prestado;
        public Documento Documento { get { return doc; } }
        public bool Prestado { get { return prestado; } }
        public FAltaEjemplar(List<Documento> docs)
        {
            InitializeComponent();
            tbCodigo.ReadOnly = true;

            BindingSource b = new BindingSource();
            b.DataSource = docs;

            cbDocumentos.DataSource = b;
            cbDocumentos.DisplayMember = "ISBN";
        }
        private void cbDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDocumentos.SelectedValue != null)
            {
                Documento d = cbDocumentos.SelectedValue as Documento;
                tbCodigo.Text = d.Titulo + d.CantEjemplares;
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FAltaEjemplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cbDocumentos.SelectedValue != null)
            {
                doc = cbDocumentos.SelectedValue as Documento;
            }
            prestado = rbPrestado.Checked;
        }
    }
}
