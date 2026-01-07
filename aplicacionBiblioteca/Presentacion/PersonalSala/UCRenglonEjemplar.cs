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
    public partial class UCRenglonEjemplar : UserControl
    {
        public UCRenglonEjemplar(string id)
        {
            InitializeComponent();
            tbIdEjemplar.Text = id;
        }
        public void MarcarComoPrestado(bool estaPrestado)
        {
            rbPrestado.Checked = estaPrestado;
        }
    }
}
