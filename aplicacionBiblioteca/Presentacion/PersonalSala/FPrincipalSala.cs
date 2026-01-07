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
            busquedaPrestamoToolStripMenuItem = new ToolStripMenuItem("Busqueda");
            busquedaPrestamoToolStripMenuItem.Click += busquedaPrestamoToolStripMenuItem_Clicked;
            prestamosToolStripMenuItem.DropDownItems.Add(busquedaPrestamoToolStripMenuItem);

            listadoPrestamosToolStripMenuItem = new ToolStripMenuItem("Listado");
            listadoPrestamosToolStripMenuItem.Click += listadoPrestamosToolStripMenuItem_Clicked;
            prestamosToolStripMenuItem.DropDownItems.Add(listadoPrestamosToolStripMenuItem);
        }
        private void altaPrestamoToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            List<Ejemplar> ejemDisponibles = logicaSala.GetAllEjemplares()
                                           .Where(j => j.Prestado == false)
                                           .ToList();
            if(!(ejemDisponibles.Count == 0))
            {
                FAltaPrestamo form1 = new FAltaPrestamo(ejemDisponibles, logicaSala.GetAllUsuarios());
                DialogResult dr = form1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Prestamo prestamo = form1.Prestamo;
                    bool exito = logicaSala.iniciarPrestamo(prestamo);
                    List<Ejemplar> ejemplares = form1.Ejemplares;
                    foreach(Ejemplar ejAux in ejemplares)
                    {
                        logicaSala.ActualizarEjemplar(ejAux);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay Ejemplares disponibles");
            }
        }
        private void busquedaPrestamoToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            var listaUsuarios = logicaSala.GetAllUsuarios();
            var listaPrestamos = logicaSala.GetAllPrestamos();
            FBusquedaPrestamo formBusqueda = new FBusquedaPrestamo(listaUsuarios, listaPrestamos);
            DialogResult dr = formBusqueda.ShowDialog();
        }
        private void listadoPrestamosToolStripMenuItem_Clicked(object sender, EventArgs e)
        {
            List<Prestamo> lista = logicaSala.GetAllPrestamos();

            if (lista != null && lista.Count > 0)
            {
                FListadoPrestamos formListado = new FListadoPrestamos(lista);

                formListado.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay préstamos registrados en el sistema.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
