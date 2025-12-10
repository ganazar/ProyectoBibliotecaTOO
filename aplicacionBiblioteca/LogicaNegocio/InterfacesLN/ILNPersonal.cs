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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool DarAltaUsuario(Usuario user);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool DarBajaUsuario(Usuario user);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Usuario ConsultarUsuario(Usuario user);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        Usuario ConsultarUsuarioPorDni(string dni);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool ModificarDatosUsuario(Usuario user);
    }
}
