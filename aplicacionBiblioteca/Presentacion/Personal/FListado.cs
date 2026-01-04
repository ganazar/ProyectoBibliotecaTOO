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
    public partial class FListado : Form
    {
        private BindingSource b = new BindingSource();
        private List<KeyValuePair<string, string>> lista;
        public FListado(Dictionary<string, string> listado)
        {
            InitializeComponent();
            lista = listado.ToList();
            lista = lista.OrderBy(x => x.Key).ToList();
            b.DataSource = lista;

            lbDNI.DataSource = b;
            lbDNI.DisplayMember = "Dni";
            lbDNI.ValueMember = "Nombre";

            lbNombre.DataSource = b;
            lbNombre.DisplayMember = "Nombre";
            lbNombre.ValueMember = "Dni";
        }

        
        private void lbDNI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
