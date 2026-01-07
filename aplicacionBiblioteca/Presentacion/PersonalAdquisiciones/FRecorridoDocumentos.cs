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

namespace Presentacion.Personal
{
    public partial class FRecorridoDocumentos : Form
    {
        private BindingSource b = new BindingSource();
        public FRecorridoDocumentos(List<Documento> documentos)
        {
            InitializeComponent();
            b.DataSource = documentos;

            bNavigator.BindingSource = b;

            tbISBN.DataBindings.Add("Text", b, "ISBN");
            tbTitulo.DataBindings.Add("Text", b, "Titulo");
            tbAutor.DataBindings.Add("Text", b, "Autor");
            tbEditorial.DataBindings.Add("Text", b, "Editorial");
            tbAnoEdicion.DataBindings.Add("Text", b, "AñoEdicion");


            b.CurrentChanged += bindingSource_CurrentChanged;
            bindingSource_CurrentChanged(this, EventArgs.Empty);
        }
        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (b.Current is Audiolibro audioLibro)
            {
                tbDuracion.Visible = true;
                tbFormato.Visible = true;
                rbAudiolibro.Checked = true;

                tbDuracion.Text = audioLibro.Duracion.ToString();
                tbFormato.Text = audioLibro.Formato;
            }
            else
            {
                rbLibro.Checked = true;
                tbDuracion.Visible = false;
                tbFormato.Visible = false;


            }
        }
    }
}
