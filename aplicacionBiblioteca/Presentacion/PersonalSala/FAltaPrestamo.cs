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
        public FAltaPrestamo(List<Ejemplar> _ej, List<Usuario> usur)
        {
            this.ej = _ej;
            InitializeComponent();

            BindingSource us = new BindingSource();
            us.DataSource = usur;

            cbUsuario.DataSource = us;
            cbUsuario.DisplayMember = "DNI";
        }

        private void btAñadirEjem_Click(object sender, EventArgs e)
        {

        }
    }
}
