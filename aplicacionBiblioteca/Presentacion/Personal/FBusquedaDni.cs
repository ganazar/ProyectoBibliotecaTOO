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
    public partial class FBusquedaDni : Form
    {
        public FBusquedaDni(Dictionary<string,string> listadoUsuarios)
        {
            InitializeComponent();
            BindingSource b = new BindingSource();
            b.DataSource = listadoUsuarios;

            cbDni.DisplayMember = "Key";
            cbDni.ValueMember = "Value";
            cbDni.DataSource = b;

            tbNombre.ReadOnly = true;
        }

        private void cbDni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDni.SelectedValue != null)
            {
                tbNombre.Text = cbDni.SelectedValue.ToString();
            }
        }
    }
}
