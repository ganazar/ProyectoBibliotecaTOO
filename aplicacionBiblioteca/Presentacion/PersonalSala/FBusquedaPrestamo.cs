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

namespace Presentacion.PersonalSala
{
    public partial class FBusquedaPrestamo : Form
    {
        private List<Prestamo> todosLosPrestamos;

        public FBusquedaPrestamo(List<Usuario> usuarios, List<Prestamo> prestamos)
        {
            InitializeComponent();
            this.todosLosPrestamos = prestamos;

            cbUsuarios.DataSource = usuarios;
            cbUsuarios.DisplayMember = "DNI";
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Usuario seleccionado = (Usuario)cbUsuarios.SelectedItem;
            DateTime fecha = dtpFecha.Value.Date;

            
            var encontrado = todosLosPrestamos.FirstOrDefault(p =>
                p != null &&
                p.Usuario.DNI == seleccionado.DNI &&
                p.FechaPrestamo.Date == fecha);

            if (encontrado != null)
            {
                CargarEjemplaresEnPanel(encontrado.Ejemplares);
            }
            else
            {
                MessageBox.Show("No se encontró ningún préstamo para esos datos.");
            }
        }
        private void CargarEjemplaresEnPanel(List<Ejemplar> ejemplares)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var ej in ejemplares)
            {
                UCRenglonEjemplar fila = new UCRenglonEjemplar(ej.CodEjemplar);

                fila.MarcarComoPrestado(ej.Prestado);

                flowLayoutPanel1.Controls.Add(fila);
            }
        }
    }
}
