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
        protected ILNPersonalSala logicaSala;
        public FPrincipalSala()
        {
            InitializeComponent();
        }

        public FPrincipalSala(string nombre, ILNPersonalSala _logicaSala) : base(nombre, _logicaSala) 
        {
            logicaSala = _logicaSala;
            InitializeComponent();
            //Inicializar();
        }

        private void FPrincipalSala_Load(object sender, EventArgs e)
        {

        }
    }
}
