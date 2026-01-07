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

namespace Presentacion.PersonalSala
{
    public partial class FAltaPrestamo : Form
    {
        private List<Ejemplar> ej;
        private List<Ejemplar> ejSelec;
        private Prestamo prestamo;
        public Prestamo Prestamo { get { return prestamo; } }
        public List<Ejemplar> Ejemplares { get { return ejSelec; } }
        public FAltaPrestamo(List<Ejemplar> _ej, List<Usuario> usur)
        {
            ej = _ej;
            ejSelec = new List<Ejemplar>();
            InitializeComponent();

            BindingSource us = new BindingSource();
            tbFecha.Text = DateTime.Today.ToShortDateString();
            us.DataSource = usur;

            cbUsuario.DataSource = us;
            cbUsuario.DisplayMember = "DNI";
        }

        private void btAñadirEjem_Click(object sender, EventArgs e)
        {
            if (ej.Count > 0)
            {
                FElejirEjemplar form1 = new FElejirEjemplar(ej);
                DialogResult dr = form1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Ejemplar ejemplar = form1.Ejemplar;
                    ejSelec.Add(ejemplar);
                    ej.Remove(ejemplar);
                    UCRenglonEjemplar nuevaFila = new UCRenglonEjemplar(ejemplar.CodEjemplar);
                    flowLayoutPanel1.Controls.Add(nuevaFila);
                }
            }
            else
            {
                MessageBox.Show("No hay más ejemplares disponibles");
            }
        }

        private void FAltaPrestamo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cbUsuario.SelectedItem != null)
            {
                prestamo = new Prestamo(cbUsuario.SelectedItem as Usuario, DateTime.Today);
                prestamo.Ejemplares = ejSelec;
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Debe seleccionar un usuario antes de continuar.");
            }
        }
    }
}
