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

namespace Presentacion.PersonalAdquisiciones
{
    public partial class FPrincipalAdquisicion : Personal.FPrincipal
    {
        public FPrincipalAdquisicion()
        {
            InitializeComponent();
        }

        public FPrincipalAdquisicion(string nombre, ILNPersonalAdquisiciones logicaAdq) : base(nombre, logicaAdq)
        {
            InitializeComponent();
        }
        
    }
}
