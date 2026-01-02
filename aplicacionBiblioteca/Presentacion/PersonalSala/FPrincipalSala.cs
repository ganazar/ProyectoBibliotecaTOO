using LogicaNegocio.InterfacesLN;
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
    public partial class FPrincipalSala : Personal.FPrincipal

    {
        public FPrincipalSala()
        {
            InitializeComponent();
        }

        public FPrincipalSala(string nombre, ILNPersonalSala logicaSala) : base(nombre, logicaSala) 
        {
            InitializeComponent();
        }

        private void FPrincipalSala_Load(object sender, EventArgs e)
        {

        }
    }
}
