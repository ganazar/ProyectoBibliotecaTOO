    using modeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Interfaces
{
    public interface IPersistenciaAdquisiciones : IPersistenciaPersonal
    {
        /// <summary>
        /// Añade el Audiolibro a la base de datos si no existe todavia
        /// </summary>
        /// <param name="audiolibro">Audiolibro a insertar</param>
        /// <returns>True si se ha añadido correctamente false en caso contrario</returns>
        bool CreateAudiolibro(Audiolibro audiolibro);

        /// <summary>
        /// Lee el Audiolibro de base de datos
        /// </summary>
        /// <param name="audiolibro">Audiolibro con la clave</param>
        /// <returns>Devuelve el Audiolibro si existe en la base de datos, nulo en caso contrario</returns>
        Audiolibro ReadAudiolibro(Audiolibro audiolibro);

        /// <summary>
        /// Actualiza el Audiolibro si existe en la base de datos, si no lo encuentra no hace nada
        /// </summary>
        /// <param name="audiolibro">Audiolibro a actualizar</param>
        /// <returns>True si actualiza el Audiolibro false en caso contrario</returns>
        bool UpdateAudiolibro(Audiolibro audiolibro);

        /// <summary>
        /// Borra el Audiolibro a la base de datos si existe
        /// </summary>
        /// <param name="audiolibro">Audiolibro a borrar</param>
        /// <returns>True si se ha borrado correctamente false en caso contrario</returns>
        bool DeleteAudiolibro(Audiolibro audiolibro);
        List<Audiolibro> GetAllAudiolibros();

        /// <summary>
        /// Añade el Fisico a la base de datos si no existe todavia
        /// </summary>
        /// <param name="fisico">Fisico a insertar</param>
        /// <returns>True si se ha añadido correctamente false en caso contrario</returns>
        bool CreateFisico(Fisico fisico);

        /// <summary>
        /// Lee el Fisico de base de datos
        /// </summary>
        /// <param name="fisico">Fisico con la clave</param>
        /// <returns>Devuelve el Fisico si existe en la base de datos, nulo en caso contrario</returns>
        Fisico ReadFisico(Fisico fisico);

        /// <summary>
        /// Actualiza el Fisico si existe en la base de datos, si no lo encuentra no hace nada
        /// </summary>
        /// <param name="fisico">Fisico a actualizar</param>
        /// <returns>True si actualiza el Fisico false en caso contrario</returns>
        bool UpdateFisico(Fisico fisico);

        /// <summary>
        /// Borra el Fisico a la base de datos si existe
        /// </summary>
        /// <param name="fisico">Fisico a borrar</param>
        /// <returns>True si se ha borrado correctamente false en caso contrario</returns>
        bool DeleteFisico(Fisico fisico);
        List<Fisico> GetAllFisicos();

        /// <summary>
        /// Añade el documento a la base de datos si no existe todavia
        /// </summary>
        /// <param name="documento">documento a insertar</param>
        /// <returns>True si se ha añadido correctamente false en caso contrario</returns>
        bool CreateDocumento(Documento documento);

        /// <summary>
        /// Lee el documento de base de datos
        /// </summary>
        /// <param name="documento">documento con la clave</param>
        /// <returns>Devuelve el documento si existe en la base de datos, nulo en caso contrario</returns>
        Documento ReadDocumento(Documento documento);

        /// <summary>
        /// Actualiza el documento si existe en la base de datos, si no lo encuentra no hace nada
        /// </summary>
        /// <param name="documento">documento a actualizar</param>
        /// <returns>True si actualiza el documento false en caso contrario</returns>
        bool UpdateDocumento(Documento documento);

        /// <summary>
        /// Borra el documento a la base de datos si existe
        /// </summary>
        /// <param name="documento">documento a borrar</param>
        /// <returns>True si se ha borrado correctamente false en caso contrario</returns>
        bool DeleteDocumento(Documento documento);

        List<Documento> GetAllDocumentos();

        /// <summary>
        /// Crea un nuevo ejemplar en el sistema.
        /// </summary>
        /// <param name="e">El objeto ejemplar a persistir.</param>
        /// <returns>True si se creó correctamente; False si ya existe un ejemplar con el mismo código.</returns>
        bool CreateEjemplar(Ejemplar e);

        /// <summary>
        /// Actualiza los datos de un ejemplar existente.
        /// </summary>
        /// <param name="e">El ejemplar con los datos actualizados.</param>
        /// <returns>True si la actualización fue exitosa; False si el ejemplar no existe.</returns>
        bool UpdateEjemplar(Ejemplar e);

        /// <summary>
        /// Elimina un ejemplar del sistema.
        /// </summary>
        /// <param name="e">El ejemplar a eliminar.</param>
        /// <returns>True si se eliminó correctamente; False si no se encontró en el sistema.</returns>
        bool DeleteEjemplar(Ejemplar e);
    }
}
