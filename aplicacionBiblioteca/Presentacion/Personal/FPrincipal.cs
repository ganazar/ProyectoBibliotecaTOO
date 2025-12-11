using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modeloDominio;

namespace Presentacion
{
    public abstract partial class FPrincipal : Form
    {
        public FPrincipal(Usuario u)
        {
            InitializeComponent();
            this.Text = u.Nombre + "Gestión de biblioteca";
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {

        }

    }
}
