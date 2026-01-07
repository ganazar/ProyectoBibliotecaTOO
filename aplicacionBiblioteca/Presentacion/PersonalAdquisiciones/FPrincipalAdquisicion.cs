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
        protected System.Windows.Forms.ToolStripMenuItem listadoDocumentoToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem recorridoDocumentoToolStripMenuItem;

        protected System.Windows.Forms.ToolStripMenuItem ejemplaresToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem altaEjemplarToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem bajaEjemplarToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem busquedaEjemplarToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem listadoEjemplarToolStripMenuItem;

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
            listadoDocumentoToolStripMenuItem = new ToolStripMenuItem("Listado");
            listadoDocumentoToolStripMenuItem.Click += listadoDocumentoToolStripMenuItem_Clicked;
            documentosToolStripMenuItem.DropDownItems.Add(listadoDocumentoToolStripMenuItem);
            recorridoDocumentoToolStripMenuItem = new ToolStripMenuItem("Recorrido uno a uno");
            recorridoDocumentoToolStripMenuItem.Click += recorridoDocumentoToolStripMenuItem_Clicked;
            documentosToolStripMenuItem.DropDownItems.Add(recorridoDocumentoToolStripMenuItem);

            ejemplaresToolStripMenuItem = new ToolStripMenuItem("Ejemplares");
            menuStrip1.Items.Add(ejemplaresToolStripMenuItem);
            altaEjemplarToolStripMenuItem = new ToolStripMenuItem("Alta");
            altaEjemplarToolStripMenuItem.Click += altaEjemplarToolStripMenuItem_Clicked;
            ejemplaresToolStripMenuItem.DropDownItems.Add(altaEjemplarToolStripMenuItem);
            bajaEjemplarToolStripMenuItem = new ToolStripMenuItem("Baja");
            bajaEjemplarToolStripMenuItem.Click += bajaEjemplarToolStripMenuItem_Clicked;
            ejemplaresToolStripMenuItem.DropDownItems.Add(bajaEjemplarToolStripMenuItem);
            busquedaEjemplarToolStripMenuItem = new ToolStripMenuItem("Busqueda");
            busquedaEjemplarToolStripMenuItem.Click += busquedaEjemplarToolStripMenuItem_Clicked;
            ejemplaresToolStripMenuItem.DropDownItems.Add(busquedaEjemplarToolStripMenuItem);
            listadoEjemplarToolStripMenuItem = new ToolStripMenuItem("Listado");
            listadoEjemplarToolStripMenuItem.Click += listadoEjemplarToolStripMenuItem_Clicked;
            ejemplaresToolStripMenuItem.DropDownItems.Add(listadoEjemplarToolStripMenuItem);
        }
        private void altaDocumentoToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            FIntroducirClave form = new FIntroducirClave("ISBN");
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (IsbnValido(form.Clave))
                {
                    Documento aux = logicaAdq.ConsultarDocumento(new Fisico(form.Clave));
                    if (aux == null)
                    {
                        FGestionDocumento form1 = new FGestionDocumento(form.Clave);
                        dr = form1.ShowDialog();
                        if (dr == DialogResult.OK)
                        {
                            Documento doc = null;
                            if (form1.TipoDocumento.Equals("Fisico"))
                            {
                                doc = new Fisico(form.Clave, form1.Titulo, form1.Autor, form1.Editorial, form1.AnoEdicion);
                            }
                            else if (form1.TipoDocumento.Equals("Audiolibro"))
                            {
                                doc = new Audiolibro(form.Clave, form1.Titulo, form1.Autor, form1.Editorial, form1.AnoEdicion, form1.Duracion, form1.Formato);
                            }
                            logicaAdq.DarAltaDocumento(doc);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Formato ISBN incorrecto Ej: 978-3-16-148410-0");
                }
        }
        }
        private void bajaDocumentoToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            FIntroducirClave form = new FIntroducirClave("ISBN");
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (IsbnValido(form.Clave))
                {

                    Documento aux = logicaAdq.ConsultarDocumento(new Fisico(form.Clave));
                    if (aux != null)
                    {
                        FGestionDocumento form1 = new FGestionDocumento(aux, true);
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
                else
                {
                    MessageBox.Show("Formato ISBN incorrecto Ej: 978-3-16-148410-0");
                }
            }
        }
        private void busquedaDocumentoToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            FIntroducirClave form = new FIntroducirClave("ISBN");
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (IsbnValido(form.Clave))
                {
                    Documento aux = logicaAdq.ConsultarDocumento(new Fisico(form.Clave));
                    if (aux != null)
                    {
                        FGestionDocumento form1 = new FGestionDocumento(aux, false);
                        form1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No existe un documento con ese ISBN");
                    }
                }
                else
                {
                    MessageBox.Show("Formato ISBN incorrecto Ej: 978-3-16-148410-0");
                }
        }
        }
        private void listadoDocumentoToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            FListadoDocumentos form = new FListadoDocumentos(logicaAdq.GetAllDocumentos());
            form.ShowDialog();
        }
        private void recorridoDocumentoToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            FRecorridoDocumentos form = new FRecorridoDocumentos(logicaAdq.GetAllDocumentos());
            form.ShowDialog();
        }

        private void altaEjemplarToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            FAltaEjemplar form1 = new FAltaEjemplar(logicaAdq.GetAllDocumentos());
            DialogResult dr = form1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Ejemplar ejemplar = new Ejemplar(form1.Documento);
                ejemplar.Prestado = form1.Prestado;
                logicaAdq.DarAltaEjemplar(ejemplar);
            }
        }
        private void bajaEjemplarToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            FIntroducirClave form = new FIntroducirClave("Código");
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Ejemplar aux = logicaAdq.ConsultarEjemplar(new Ejemplar(form.Clave));
                if (aux != null)
                {
                    FBajaEjemplar form1 = new FBajaEjemplar(aux);
                    dr = form1.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        logicaAdq.DarBajaEjemplar(aux);
                    }
                }
                else
                {
                    MessageBox.Show("No existe un ejemplar con ese codigo");
                }
            }
        }
        private void busquedaEjemplarToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            FIntroducirClave form = new FIntroducirClave("Código");
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Ejemplar aux = logicaAdq.ConsultarEjemplar(new Ejemplar(form.Clave));
                if (aux != null)
                {
                    FBusquedaEjemplar form1 = new FBusquedaEjemplar(aux);
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No existe un documento con ese código");
                }
            }
        }
        private void listadoEjemplarToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            FListadoEjemplares form = new FListadoEjemplares(logicaAdq.GetAllEjemplares());
            form.ShowDialog();
        }

        private bool IsbnValido(string isbnInput)
        {
            string isbn = isbnInput.Replace("-", "").Replace(" ", "").ToUpper();

            if (isbn.Length == 13)
            {
                if (!long.TryParse(isbn, out _)) return false;

                long suma = 0;
                for (int i = 0; i < 12; i++)
                {
                    int digito = int.Parse(isbn[i].ToString());
                    suma += (i % 2 == 0) ? digito * 1 : digito * 3;
                }

                int resto = (int)(suma % 10);
                int digitoControlCalculado = 10 - resto;
                if (digitoControlCalculado == 10) digitoControlCalculado = 0;

                int digitoControlReal = int.Parse(isbn[12].ToString());

                return digitoControlCalculado == digitoControlReal;
            }
            return false; // Longitud incorrecta
        }
    }
}
