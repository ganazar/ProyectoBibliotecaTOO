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
    public partial class FRecorrido : Form
    {
        private BindingSource b = new BindingSource();
        private List<KeyValuePair<string, string>> lista;
        public FRecorrido(Dictionary<string, string> listado)
        {
            InitializeComponent();
            lista = listado.ToList();
            lista = lista.OrderBy(x => x.Key).ToList();
            b.DataSource = lista;

            bNavigator.BindingSource = b;

            lDni.DataSource = b;
            lDni.DisplayMember = "Dni";
            lDni.ValueMember = "Nombre";

            lNombre.DataSource = b;
            lNombre.DisplayMember = "Nombre";
            lNombre.ValueMember = "Dni";
        }   
    }
}
