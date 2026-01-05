using LogicaNegocio.InterfacesLN;
using modeloDominio;
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

namespace Presentacion.PersonalAdquisiciones
{
    public partial class FPrincipalAdquisicion : Personal.FPrincipal
    {
        protected ILNPersonalAdquisiciones logicaAdq;
        protected System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem altaDocumentoToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem bajaDocumentoToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem busquedaDocumentoToolStripMenuItem;
        public FPrincipalAdquisicion()
        {
            InitializeComponent();
        }

        public FPrincipalAdquisicion(string nombre, ILNPersonalAdquisiciones _logicaAdq) : base(nombre, _logicaAdq)
        {
            logicaAdq = _logicaAdq;
            InitializeComponent();
            Inicializar();
        }
        private void Inicializar()
        {
            documentosToolStripMenuItem = new ToolStripMenuItem("Documentos");
            menuStrip1.Items.Add(documentosToolStripMenuItem);
            altaDocumentoToolStripMenuItem = new ToolStripMenuItem("Alta");
            altaDocumentoToolStripMenuItem.Click += altaDocumentoToolStripMenuItem_Clicked;
            documentosToolStripMenuItem.DropDownItems.Add(altaDocumentoToolStripMenuItem);
            bajaDocumentoToolStripMenuItem = new ToolStripMenuItem("Baja");
            bajaDocumentoToolStripMenuItem.Click += bajaDocumentoToolStripMenuItem_Clicked;
            documentosToolStripMenuItem.DropDownItems.Add(bajaDocumentoToolStripMenuItem);
            busquedaDocumentoToolStripMenuItem = new ToolStripMenuItem("Busqueda");
            busquedaDocumentoToolStripMenuItem.Click += busquedaDocumentoToolStripMenuItem_Clicked;
            documentosToolStripMenuItem.DropDownItems.Add(busquedaDocumentoToolStripMenuItem);
        }
        private void altaDocumentoToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            FIntroducirClave form = new FIntroducirClave("ISBN");
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Documento aux = logicaAdq.ConsultarDocumento();
                if (aux == null)
                {
                    FAltaDocumento form1 = new FAltaDocumento(form.Clave);
                    dr = form1.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        Documento doc = null;
                        if (form1.TipoDocumento.Equals("Fisico"))
                        {
                            doc = new Fisico(form.Clave, form1.Titulo, form1.Autor, form1.Editorial, form1.AnoEdicion);
                        }else if (form1.TipoDocumento.Equals("Audiolibro"))
                        {
                            doc = new Audiolibro(form.Clave, form1.Titulo, form1.Autor, form1.Editorial, form1.AnoEdicion, form1.Duracion, form1.Formato);
                        }
                        logicaAdq.DarAltaDocumento(doc);
                    }
                }
            }
        }
        public void bajaDocumentoToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            FIntroducirClave form = new FIntroducirClave("ISBN");
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Documento aux = logicaAdq.ConsultarDocumento();
                if (aux != null)
                {
                    FBajaDocumento form1 = new FBajaDocumento(aux);
                    dr = form1.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        logicaAdq.DarBajaDocumento(aux);
                    }
                }
                else
                {
                    MessageBox.Show("No existe un documento con ese ISBN");
                }
            }
        }
        private void busquedaDocumentoToolStripMenuItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}
