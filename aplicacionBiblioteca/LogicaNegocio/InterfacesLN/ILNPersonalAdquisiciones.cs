using modeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesLN
{
    public interface ILNPersonalAdquisiciones
    {
        bool AltaUsuario(Usuario u);
        bool BajaUsuario(Usuario u);
        Usuario ConsultarUsuario(Usuario u);
        Usuario ConsultarUsuarioPorDNI(Usuario u);
        bool ModificarDatosUsuario(Usuario u);
    }
}
