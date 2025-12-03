using modeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Interfaces
{
    public interface IPersistenciaAdquisiciones
    {
        /// <summary>
        /// Añade el Audiolibro a la base de datos si no existe todavia
        /// </summary>
        /// <param name="user">Audiolibro a insertar</param>
        /// <returns>True si se ha añadido correctamente false en caso contrario</returns>
        bool CreateAudiolibro(Audiolibro user);

        /// <summary>
        /// Lee el Audiolibro de base de datos
        /// </summary>
        /// <param name="user">Audiolibro con la clave</param>
        /// <returns>Devuelve el Audiolibro si existe en la base de datos, nulo en caso contrario</returns>
        Audiolibro ReadAudiolibro(Audiolibro user);

        /// <summary>
        /// Actualiza el Audiolibro si existe en la base de datos, si no lo encuentra no hace nada
        /// </summary>
        /// <param name="user">Audiolibro a actualizar</param>
        /// <returns>True si actualiza el Audiolibro false en caso contrario</returns>
        bool UpdateAudiolibro(Audiolibro user);

        /// <summary>
        /// Borra el Audiolibro a la base de datos si existe
        /// </summary>
        /// <param name="user">Audiolibro a borrar</param>
        /// <returns>True si se ha borrado correctamente false en caso contrario</returns>
        bool DeleteAudiolibro(Audiolibro user);
        List<Audiolibro> GetAllAudiolibros();

        /// <summary>
        /// Añade el Fisico a la base de datos si no existe todavia
        /// </summary>
        /// <param name="user">Fisico a insertar</param>
        /// <returns>True si se ha añadido correctamente false en caso contrario</returns>
        bool CreateFisico(Fisico user);

        /// <summary>
        /// Lee el Fisico de base de datos
        /// </summary>
        /// <param name="user">Fisico con la clave</param>
        /// <returns>Devuelve el Fisico si existe en la base de datos, nulo en caso contrario</returns>
        Fisico ReadFisico(Fisico user);

        /// <summary>
        /// Actualiza el Fisico si existe en la base de datos, si no lo encuentra no hace nada
        /// </summary>
        /// <param name="user">Fisico a actualizar</param>
        /// <returns>True si actualiza el Fisico false en caso contrario</returns>
        bool UpdateFisico(Fisico user);

        /// <summary>
        /// Borra el Fisico a la base de datos si existe
        /// </summary>
        /// <param name="user">Fisico a borrar</param>
        /// <returns>True si se ha borrado correctamente false en caso contrario</returns>
        bool DeleteFisico(Fisico user);
        List<Fisico> GetAllFisicos();
    }
}
