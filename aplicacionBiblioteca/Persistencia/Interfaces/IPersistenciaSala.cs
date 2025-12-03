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
        /// Añade el Prestamo a la base de datos si no existe todavia
        /// </summary>
        /// <param name="user">Prestamo a insertar</param>
        /// <returns>True si se ha añadido correctamente false en caso contrario</returns>
        bool CreatePrestamo(Prestamo user);

        /// <summary>
        /// Lee el Prestamo de base de datos
        /// </summary>
        /// <param name="user">Prestamo con la clave</param>
        /// <returns>Devuelve el Prestamo si existe en la base de datos, nulo en caso contrario</returns>
        Prestamo ReadPrestamo(Prestamo user);

        /// <summary>
        /// Actualiza el Prestamo si existe en la base de datos, si no lo encuentra no hace nada
        /// </summary>
        /// <param name="user">Prestamo a actualizar</param>
        /// <returns>True si actualiza el Prestamo false en caso contrario</returns>
        bool UpdatePrestamo(Prestamo user);

        /// <summary>
        /// Borra el Prestamo a la base de datos si existe
        /// </summary>
        /// <param name="user">Prestamo a borrar</param>
        /// <returns>True si se ha borrado correctamente false en caso contrario</returns>
        bool DeletePrestamo(Prestamo user);
        List<Prestamo> GetAllPrestamos();
    }
}
