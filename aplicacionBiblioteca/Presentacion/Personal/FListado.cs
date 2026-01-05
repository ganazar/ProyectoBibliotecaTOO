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
            lbDNI.DisplayMember = "Key";
            lbDNI.ValueMember = "Value";

            lbNombre.DataSource = b;
            lbNombre.DisplayMember = "Value";
            lbNombre.ValueMember = "Key";
        }
        
        private void btDNi_Click(object sender, EventArgs e)
        {
            lista = lista.OrderBy(x => x.Key).ToList();
            b.DataSource = lista;
        }

        private void btnombre_Click(object sender, EventArgs e)
        {
            lista = lista.OrderBy(x => x.Value).ToList();
            b.DataSource = lista;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
