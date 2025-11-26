using modeloDominio;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Interfaces
{
    public interface IPersistenciaSala
    {
        /// <summary>
        /// Añade el usuario a la base de datos si no existe todavia
        /// </summary>
        /// <param name="user">Usuario a insertar</param>
        /// <returns>True si se ha añadido correctamente false en caso contrario</returns>
        bool CreateUsuario(Usuario user);

        /// <summary>
        /// Lee el usuario de base de datos
        /// </summary>
        /// <param name="user">Usuario con la clave</param>
        /// <returns>Devuelve el usuario si existe en la base de datos, nulo en caso contrario</returns>
        Usuario ReadUsuario(Usuario user);

        /// <summary>
        /// Actualiza el usuario si existe en la base de datos, si no lo encuentra no hace nada
        /// </summary>
        /// <param name="user">Usuario a actualizar</param>
        /// <returns>True si actualiza el usuario false en caso contrario</returns>
        bool UpdateUsuario(Usuario user);

        /// <summary>
        /// Borra el usuario a la base de datos si existe
        /// </summary>
        /// <param name="user">Usuario a borrar</param>
        /// <returns>True si se ha borrado correctamente false en caso contrario</returns>
        bool DeleteUsuario(Usuario user);

    }
}
