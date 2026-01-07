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
    public partial class FElejirEjemplar : Form
    {
        public FElejirEjemplar(List<Ejemplar> ejemp)
        {
            InitializeComponent();
            BindingSource ejem = new BindingSource();
            ejem.DataSource = ejemp;

            cbEjemplares.DataSource = ejem;
            cbEjemplares.DisplayMember = "InfoMostrar";
        }

        private void FElejirEjemplar_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
