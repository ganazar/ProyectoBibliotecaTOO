using modeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesLN
{
    public interface ILNPersonal
    {
        bool DarAltaUsuario(Usuario user);
        bool DarBajaUsuario(Usuario user);
        Usuario ConsultarUsuario(Usuario user);
        Usuario ConsultarUsuarioPorDni(string dni);
        bool ModificarDatosUsuario(Usuario user);
    }
}
