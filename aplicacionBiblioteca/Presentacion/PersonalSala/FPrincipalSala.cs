using LogicaNegocio.InterfacesLN;
using modeloDominio;
using Presentacion.Personal;
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

namespace Presentacion.PersonalSala
{

    public partial class FPrincipalSala : Personal.FPrincipal

    {
        protected System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem altaPrestamoToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem bajaPrestamoToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem busquedaPrestamoToolStripMenuItem;
        protected System.Windows.Forms.ToolStripMenuItem listadoPrestamosToolStripMenuItem;

        protected ILNPersonalSala logicaSala;
        public FPrincipalSala()
        {
            InitializeComponent();
        }

        public FPrincipalSala(string nombre, ILNPersonalSala _logicaSala) : base(nombre, _logicaSala) 
        {
            logicaSala = _logicaSala;
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            prestamosToolStripMenuItem = new ToolStripMenuItem("Prestamos");
            menuStrip1.Items.Add(prestamosToolStripMenuItem);
            altaPrestamoToolStripMenuItem = new ToolStripMenuItem("Alta");
            altaPrestamoToolStripMenuItem.Click += altaPrestamoToolStripMenuItem_Clicked;
            prestamosToolStripMenuItem.DropDownItems.Add(altaPrestamoToolStripMenuItem);
            bajaPrestamoToolStripMenuItem = new ToolStripMenuItem("Baja");
            bajaPrestamoToolStripMenuItem.Click += bajaPrestamoToolStripMenuItem_Clicked;
            prestamosToolStripMenuItem.DropDownItems.Add(bajaPrestamoToolStripMenuItem);
            busquedaPrestamoToolStripMenuItem = new ToolStripMenuItem("Busqueda");
            busquedaPrestamoToolStripMenuItem.Click += busquedaPrestamoToolStripMenuItem_Clicked;
            prestamosToolStripMenuItem.DropDownItems.Add(busquedaPrestamoToolStripMenuItem);

            listadoPrestamosToolStripMenuItem = new ToolStripMenuItem("Listado");
            listadoPrestamosToolStripMenuItem.Click += listadoPrestamosToolStripMenuItem_Clicked;
            prestamosToolStripMenuItem.DropDownItems.Add(listadoPrestamosToolStripMenuItem);
        }
        private void altaPrestamoToolStripMenuItem_Clicked(object sender, EventArgs e)
        {/*
            FIntroducirClave form = new FIntroducirClave("ISBN");
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Documento aux = logicaAdq.ConsultarDocumento(new Fisico(form.Clave));
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
                        }
                        else if (form1.TipoDocumento.Equals("Audiolibro"))
                        {
                            doc = new Audiolibro(form.Clave, form1.Titulo, form1.Autor, form1.Editorial, form1.AnoEdicion, form1.Duracion, form1.Formato);
                        }
                        logicaAdq.DarAltaDocumento(doc);
                    }
                }
            }*/
        }
        private void bajaPrestamoToolStripMenuItem_Clicked(object sender, EventArgs e)
        {/*
            FIntroducirClave form = new FIntroducirClave("ISBN");
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Documento aux = logicaAdq.ConsultarDocumento(new Fisico(form.Clave));
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
            }*/
        }
        private void busquedaPrestamoToolStripMenuItem_Clicked(object sender, EventArgs e)
        {/*
            FIntroducirClave form = new FIntroducirClave("ISBN");
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Documento aux = logicaSala.ConsultarDocumento(new Fisico(form.Clave));
                if (aux != null)
                {
                    FBusquedaDocumento form1 = new FBusquedaDocumento(aux);
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No existe un documento con ese ISBN");
                }
            }*/
        }
        private void listadoPrestamosToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            //FListadoPrestamo form = new FListadoPrestamo(logicaSala.GetAllPrestamos());
            //form.ShowDialog();
        }
    }
}
