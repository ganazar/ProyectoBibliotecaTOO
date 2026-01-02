using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modeloDominio;
using Persistencia;

namespace LogicaNegocio.InterfacesLN
{
    public interface ILNPersonalSala : ILNPersonal
    {
        /// <summary>
        /// Obtiene una lista de los ejemplares que un usuario tiene actualmente en prestamo.
        /// </summary>
        /// <param name="u">El usuario del cual se quieren consultar los ejemplares en prestamo.</param>
        /// <returns>Una lista de objetos <see cref="Ejemplar"/> prestados al usuario.</returns>
        List<Ejemplar> consultarEjemplaresPrestadosUsuario(Usuario u);

        /// <summary>
        /// Consulta los préstamos que están activos asociados a un usuario.
        /// </summary>
        /// <param name="u">El usuario cuyos préstamos activos se desean consultar.</param>
        /// <returns>Una lista de objetos <see cref="Prestamo"/> que no han finalizado.</returns>
        List<Prestamo> consultarPrestamosNoDevueltos(Usuario u);

        /// <summary>
        /// Registra un nuevo préstamo de un ejemplar a un usuario.
        /// </summary>
        /// <param name="e">El ejemplar específico que será prestado.</param>
        /// <param name="u">El usuario que solicita el préstamo.</param>
        /// <returns>El objeto <see cref="Prestamo"/> generado.</returns>
        Prestamo iniciarPrestamo(List<Ejemplar> le, Usuario u);

        /// <summary>
        /// Finaliza el préstamo asociado a un ejemplar, marcándolo como devuelto.
        /// </summary>
        /// <param name="e">El ejemplar que está siendo devuelto a la sala.</param>
        void devolverPrestamo(Ejemplar e);

        /// <summary>
        /// Obtiene el usuario asociado a un préstamo específico.
        /// </summary>
        /// <param name="p">El préstamo del cual se quiere conocer el titular.</param>
        /// <returns>El objeto <see cref="Usuario"/> asociado al préstamo.</returns>
        Usuario usuarioDePrestamo(Prestamo p);

        /// <summary>
        /// Consulta el estado actual de un préstamo (enProceso,Finalizado).
        /// </summary>
        /// <param name="p">El préstamo a verificar.</param>
        /// <returns>Un valor de tipo <see cref="EstadoPrestamo"/>.</returns>
        EstadoPrestamo estadoPrestamo(Prestamo p);

        /// <summary>
        /// Obtiene todos los ejemplares de la biblioteca que están en préstamo.
        /// </summary>
        /// <returns>Una lista de <see cref="Ejemplar"/> no devueltos.</returns>
        List<Ejemplar> ejemplaresNoDevueltos();

        /// <summary>
        /// Obtiene el listado de préstamos asociados a un documento específico.
        /// </summary>
        /// <param name="d">El documento del cual se buscan los préstamos.</param>
        /// <returns>Una lista de objetos <see cref="Prestamo"/> relacionados con el documento.</returns>
        List<Prestamo> PrestamosDocumento(Documento d);

        /// <summary>
        /// Obtiene todos los préstamos que están activos en el sistema actualmente.
        /// </summary>
        /// <returns>Una lista de objetos <see cref="Prestamo"/> en curso.</returns>
        List<Prestamo> PrestamosEnProceso();

        /// <summary>
        /// Obtiene todos los préstamos cuya fecha de devolución ha expirado.
        /// </summary>
        /// <returns>Una lista de objetos <see cref="Prestamo"/> vencidos.</returns>
        List<Prestamo> PrestamosVencidos();
    }
}
