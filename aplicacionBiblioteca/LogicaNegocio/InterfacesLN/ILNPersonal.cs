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
        /// Registra un nuevo usuario en el sistema de la biblioteca.
        /// </summary>
        /// <param name="user">Objeto Usuario con los datos a registrar (DNI, Nombre, etc.).</param>
        /// <returns>
        /// Devuelve <c>true</c> si el usuario se registró correctamente. 
        /// Devuelve <c>false</c> si ya existe un usuario con ese DNI.
        /// </returns>
        bool DarAltaUsuario(Usuario user);

        /// <summary>
        /// Elimina un usuario existente del sistema.
        /// </summary>
        /// <param name="user">Objeto Usuario que se desea dar de baja (debe contener al menos el DNI).</param>
        /// <returns>
        /// Devuelve <c>true</c> si el usuario fue eliminado correctamente.
        /// Devuelve <c>false</c> si el usuario no existía en la base de datos.
        /// </returns>
        bool DarBajaUsuario(Usuario user);

        /// <summary>
        /// Busca y recupera la información completa de un usuario a partir de un objeto Usuario parcial.
        /// </summary>
        /// <param name="user">Objeto Usuario que contiene el DNI a buscar.</param>
        /// <returns>
        /// Devuelve el objeto <see cref="Usuario"/> completo si se encuentra.
        /// Devuelve <c>null</c> si el usuario no existe.
        /// </returns>
        Usuario ConsultarUsuario(Usuario user);

        /// <summary>
        /// Busca un usuario en el sistema utilizando su DNI.
        /// </summary>
        /// <param name="dni">Cadena de texto con el DNI del usuario a buscar.</param>
        /// <returns>
        /// Devuelve el objeto <see cref="Usuario"/> si se encuentra.
        /// Devuelve <c>null</c> si no existe ningún usuario con ese DNI.
        /// </returns>
        Usuario ConsultarUsuarioPorDni(string dni);

        /// <summary>
        /// Actualiza los datos de un usuario existente (por ejemplo, corrección del nombre).
        /// </summary>
        /// <param name="user">Objeto Usuario con los datos modificados (el DNI debe coincidir con el existente).</param>
        /// <returns>
        /// Devuelve <c>true</c> si la modificación fue exitosa.
        /// Devuelve <c>false</c> si el usuario no se encontró para modificarlo.
        /// </returns>
        bool ModificarDatosUsuario(Usuario user);
    }
}