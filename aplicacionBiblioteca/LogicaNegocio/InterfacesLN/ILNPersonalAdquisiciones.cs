using modeloDominio;
using System;
using System.Collections.Generic;

namespace LogicaNegocio.InterfacesLN
{
    public interface ILNPersonalAdquisiciones : ILNPersonal
    {
        /// <summary>
        /// Determina cuál es el documento que ha tenido mayor número de préstamos en el histórico.
        /// </summary>
        /// <returns>El Documento más leido, o null si no hay registros.</returns>
        Documento MasLeido();

        /// <summary>
        /// Obtiene la información detallada de un documento específico del catálogo.
        /// </summary>
        /// <param name="d">Documento que contiene el criterio de búsqueda (normalmente el ISBN).</param>
        /// <returns>El Documento completo con sus datos, o null si no existe.</returns>
        Documento ConsultarDocumento(Documento d);
        /// <summary>
        /// Obtiene la información detallada de un ejemplar específico del catálogo.
        /// </summary>
        /// <param name="e">Ejemplar que contiene el codigo identificatorio.</param>
        /// <returns>El Ejemplar completo con sus datos, o null si no existe.</returns>
        Ejemplar ConsultarEjemplar(Ejemplar e);

        /// <summary>
        /// Registra la entrada de una nueva unidad física (ejemplar) de un documento en la biblioteca.
        /// </summary>
        /// <param name="e">El ejemplar que se desea dar de alta.</param>
        /// <returns>True si el alta fue exitosa; False si el ejemplar ya existía o los datos son incorrectos.</returns>
        bool DarAltaEjemplar(Ejemplar e);

        /// <summary>
        /// Elimina un ejemplar específico del inventario de la biblioteca.
        /// </summary>
        /// <param name="e">El ejemplar que se desea retirar.</param>
        /// <returns>True si se eliminó correctamente; False si el ejemplar está prestado o no se encuentra.</returns>
        bool DarBajaEjemplar(Ejemplar e);

        /// <summary>
        /// Incorpora un nuevo título (libro, audiolibro, etc.) al catálogo general de la biblioteca.
        /// </summary>
        /// <param name="d">El documento base que se va a registrar.</param>
        /// <returns>True si se registró correctamente; False si el documento ya existe por su ISBN.</returns>
        bool DarAltaDocumento(Documento d);

        /// <summary>
        /// Elimina un título del catálogo de la biblioteca.
        /// </summary>
        /// <param name="d">El documento que se desea dar de baja.</param>
        /// <returns>True si se eliminó con éxito; False si el documento aún tiene ejemplares asociados.</returns>
        bool DarBajaDocumento(Documento d);

        /// <summary>
        /// Verifica si existe al menos una unidad de un documento que no esté actualmente en préstamo.
        /// </summary>
        /// <param name="d">El documento a consultar.</param>
        /// <returns>True si hay unidades disponibles para préstamo; False en caso contrario.</returns>
        bool ConsultarDisponibilidadDocumento(Documento d);

        /// <summary>
        /// Calcula la fecha estimada en la que una unidad de un documento volverá a estar libre.
        /// </summary>
        /// <param name="d">El documento del cual se quiere conocer la disponibilidad futura.</param>
        /// <returns>La fecha prevista de devolución más cercana.</returns>
        DateTime ConsultarFechaDisponibilidad(Documento d);

        /// <summary>
        /// Lista todas las unidades físicas (ejemplares) asociadas a un documento concreto.
        /// </summary>
        /// <param name="d">El documento del cual se quieren listar las unidades.</param>
        /// <returns>Una lista Ejemplares vinculados al documento.</returns>
        List<Ejemplar> ConsultarEjemplaresDocumentos(Documento d);

        /// <summary>
        /// Obtiene el listado completo de todos los documentos registrados en la base de datos.
        /// </summary>
        /// <returns>Una lista genérica (List) con todos los objetos Documento encontrados.</returns>
        List<Documento> GetAllDocumentos();
    }
}