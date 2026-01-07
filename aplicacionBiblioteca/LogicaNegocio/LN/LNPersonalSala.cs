using LogicaNegocio.InterfacesLN;
using modeloDominio;
using Persistencia;
using Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class LNPersonalSala : LNPersonal,ILNPersonalSala
    {
        private readonly IPersistenciaSala persistencia;
        public LNPersonalSala(IPersistenciaSala _persistencia) :base(_persistencia)
        {
            persistencia = _persistencia;
        }

        /// <summary>
        /// Obtiene una lista de los ejemplares que un usuario tiene actualmente en prestamo.
        /// </summary>
        /// <param name="u">El usuario del cual se quieren consultar los ejemplares en prestamo.</param>
        /// <returns>Una lista de objetos <see cref="Ejemplar"/> prestados al usuario.</returns>
        public List<Ejemplar> consultarEjemplaresPrestadosUsuario(Usuario u)
        { //List<Ejemplar> l = new List<Ejemplar>();

            //foreach (Prestamo p in PersistenciaSala.GetAllPrestamos())
            //{
            //    if (p.Usuario.DNI == u.DNI)
            //    {
            //        foreach (Ejemplar e in p.Ejemplares)
            //        {
            //              if (p.FechaDevolucion(e) < DateTime.Today){
            //                  l.Add(e);
            //              }
            //        }
            //    }
            //}

            return persistencia.GetAllPrestamos().Where(p => p.Usuario.DNI == u.DNI && p.Estado == EstadoPrestamo.EnProceso)
                .SelectMany(p => p.Ejemplares).ToList();
        }

        /// <summary>
        /// Consulta los préstamos que están activos asociados a un usuario.
        /// </summary>
        /// <param name="u">El usuario cuyos préstamos activos se desean consultar.</param>
        /// <returns>Una lista de objetos <see cref="Prestamo"/> que no han finalizado.</returns>
        public List<Prestamo> consultarPrestamosNoDevueltos(Usuario u)
        {
            return persistencia.GetAllPrestamos().Where(p => p.Usuario.DNI == u.DNI && p.Estado == EstadoPrestamo.EnProceso).ToList();
        }

        /// <summary>
        /// Registra un nuevo préstamo de un ejemplar a un usuario.
        /// </summary>
        /// <param name="e">El ejemplar específico que será prestado.</param>
        /// <param name="u">El usuario que solicita el préstamo.</param>
        /// <returns>Verdader si se ha guardo el prestamo y falso en caso contrario</returns>
        public bool iniciarPrestamo(Prestamo p) {
            return persistencia.CreatePrestamo(p); ;
        }

        /// <summary>
        /// Finaliza el préstamo asociado a un ejemplar, marcándolo como devuelto.
        /// </summary>
        /// <param name="e">El ejemplar que está siendo devuelto a la sala.</param>
        public void devolverPrestamo(Ejemplar e)
        {
            Prestamo prestamo = persistencia.GetAllPrestamos().Where(p => p.Ejemplares.Contains(e) && p.Estado == EstadoPrestamo.EnProceso).FirstOrDefault();
            if (prestamo != null)
            {
                prestamo.Ejemplares.Remove(e);
                if (!prestamo.Ejemplares.Any())
                {
                    prestamo.Estado = EstadoPrestamo.Finalizado;
                }
                persistencia.UpdatePrestamo(prestamo);
            } 
        }

        /// <summary>
        /// Consulta el estado actual de un préstamo (enProceso,Finalizado).
        /// </summary>
        /// <param name="p">El préstamo a verificar.</param>
        /// <returns>Un valor de tipo <see cref="EstadoPrestamo"/>.</returns>
        public EstadoPrestamo estadoPrestamo(Prestamo p)
        {
            p = persistencia.ReadPrestamo(p);
            return p.Estado;
        }

        /// <summary>
        /// Obtiene todos los ejemplares de la biblioteca que están en préstamo.
        /// </summary>
        /// <returns>Una lista de <see cref="Ejemplar"/> no devueltos.</returns>
        public List<Ejemplar> ejemplaresNoDevueltos() {
            return persistencia.GetAllPrestamos().Where(p => p.Estado == EstadoPrestamo.EnProceso).SelectMany(p => p.Ejemplares).ToList();
        }

        /// <summary>
        /// Obtiene el listado de préstamos asociados a un documento específico.
        /// </summary>
        /// <param name="d">El documento del cual se buscan los préstamos.</param>
        /// <returns>Una lista de objetos <see cref="Prestamo"/> relacionados con el documento.</returns>
        public List<Prestamo> PrestamosDocumento(Documento d)
        {
            return persistencia.GetAllPrestamos().Where(p => p.Ejemplares.Any(e => e.Doc == d)).ToList();
        }

        /// <summary>
        /// Obtiene todos los préstamos que están activos en el sistema actualmente.
        /// </summary>
        /// <returns>Una lista de objetos <see cref="Prestamo"/> en curso.</returns>
        public List<Prestamo> PrestamosEnProceso()
        {
            return persistencia.GetAllPrestamos().Where(p => p.Estado == EstadoPrestamo.EnProceso).ToList();
        }

        /// <summary>
        /// Obtiene todos los préstamos cuya fecha de devolución ha expirado.
        /// </summary>
        /// <returns>Una lista de objetos <see cref="Prestamo"/> vencidos.</returns>
        public List<Prestamo> PrestamosVencidos()
        {
            return persistencia.GetAllPrestamos().Where(p => p.Estado == EstadoPrestamo.EnProceso &&
                    p.Ejemplares.Any(e => p.FechaDevolucion(e) < DateTime.Today)).ToList();
        }

        public List<Prestamo> GetAllPrestamos()
        {
            return persistencia.GetAllPrestamos();
        }

        public List<Ejemplar> GetAllEjemplares()
        {
            return persistencia.GetAllEjemplares();
        }

        public bool ActualizarEjemplar(Ejemplar ejemplar)
        {
            return persistencia.UpdateEjemplar(ejemplar);
        }
    }
}
