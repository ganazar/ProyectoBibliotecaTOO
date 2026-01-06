using System;
using System.Collections.Generic;
using System.Linq;
using modeloDominio;
using Persistencia.Interfaces;
using Persistencia.Repositorios;
using LogicaNegocio.InterfacesLN;

namespace LogicaNegocio.ClasesLN
{
    public class LNPersonalAdquisiciones : LNPersonal, ILNPersonalAdquisiciones
    {
        private readonly IPersistenciaAdquisiciones _persistenciaAdq;
        private readonly IPersistenciaSala _persistenciaSala;

        public LNPersonalAdquisiciones(IPersistenciaAdquisiciones _persistencia) : base(_persistencia)
        {
            _persistenciaAdq = _persistencia;
            _persistenciaSala = new PersistenciaSala();
        }

        public bool DarAltaDocumento(Documento d)
        {
            if (d == null || string.IsNullOrEmpty(d.ISBN)) return false;

            return _persistenciaAdq.CreateDocumento(d);
        }

        public bool DarBajaDocumento(Documento d)
        {
            if (d == null) return false;

            var ejemplares = ConsultarEjemplaresDocumentos(d);
            if (ejemplares.Count > 0) return false;

            return _persistenciaAdq.DeleteDocumento(d);
        }

        public Documento ConsultarDocumento(Documento d)
        {
            if (d == null) return null;

            return _persistenciaAdq.ReadDocumento(d);
        }
        public Ejemplar ConsultarEjemplar(Ejemplar e)
        {
            if (e == null) return null;

            return _persistenciaAdq.ReadEjemplar(e);
        }

        public bool DarAltaEjemplar(Ejemplar e)
        {
            if (e == null || e.Doc == null) return false;

            return _persistenciaAdq.CreateEjemplar(e);
        }

        public bool DarBajaEjemplar(Ejemplar e)
        {
            if (e == null) return false;

            if (e.Prestado) return false;

            return _persistenciaAdq.DeleteEjemplar(e);
        }

        public List<Ejemplar> ConsultarEjemplaresDocumentos(Documento d)
        {
            if (d == null) return new List<Ejemplar>();

            return _persistenciaAdq.GetAllEjemplares()
                .Where(ej => ej.Doc.ISBN == d.ISBN)
                .ToList();
        }

        public bool ConsultarDisponibilidadDocumento(Documento d)
        {
            var ejemplares = ConsultarEjemplaresDocumentos(d);
            return ejemplares.Any(e => !e.Prestado);
        }

        public DateTime ConsultarFechaDisponibilidad(Documento d)
        {
            if (ConsultarDisponibilidadDocumento(d)) return DateTime.Now;
            var prestamosActivos = _persistenciaSala.GetAllPrestamos()
                .Where(p => p.Estado == EstadoPrestamo.EnProceso &&
                            p.Ejemplares.Any(ej => ej.Doc.ISBN == d.ISBN))
                .ToList();

            if (!prestamosActivos.Any()) return DateTime.MaxValue;

            return prestamosActivos.Min(p => p.FechaPrestamo.AddDays(15));
        }

        public Documento MasLeido()
        {
            var historicoPrestamos = _persistenciaSala.GetAllPrestamos();

            var isbnMasPopular = historicoPrestamos
                .SelectMany(p => p.Ejemplares)
                .GroupBy(e => e.Doc.ISBN)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();

            if (isbnMasPopular == null) return null;

            return _persistenciaAdq.GetAllDocumentos()
                .FirstOrDefault(doc => doc.ISBN == isbnMasPopular);
        }

        public List<Documento> GetAllDocumentos()
        {
            return _persistenciaAdq.GetAllDocumentos();
        }
    }
}