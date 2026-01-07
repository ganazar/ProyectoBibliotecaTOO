using modeloDominio;
using Persistencia.BD;
using Persistencia.Datos;
using Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia.Repositorios
{
    public class PersistenciaSala : PersistenciaPersonal, IPersistenciaSala
    {
        public bool CreatePrestamo(Prestamo prestamo)
        {
            var clave = new ClavePrestamo(prestamo.Usuario.DNI, prestamo.FechaPrestamo);

            if (BD.BD.tablaPrestamos.Contains(clave)) return false;

            BD.BD.tablaPrestamos.Add(Transformers.PrestamoDato(prestamo));

            foreach (var ejemplar in prestamo.Ejemplares)
            {
                var relacion = new PrestamoEjemplar(
                    new ClavePrestamoEjemplar(clave.Dni, clave.Fecha, ejemplar.CodEjemplar)
                );
                if (!BD.BD.tablaPrestamoEjemplar.Contains(relacion.Id))
                {
                    BD.BD.tablaPrestamoEjemplar.Add(relacion);
                }
            }

            return true;
        }

        public Prestamo ReadPrestamo(Prestamo prestamo)
        {
            var clave = new ClavePrestamo(prestamo.Usuario.DNI, prestamo.FechaPrestamo);

            if (!BD.BD.tablaPrestamos.Contains(clave)) return null;

            var pDato = BD.BD.tablaPrestamos[clave];
            var pDominio = Transformers.Prestamo(pDato);

            var ejemplaresAsociados = BD.BD.tablaPrestamoEjemplar
                .Where(pe => pe.Id.Dni == clave.Dni && pe.Id.Fecha == clave.Fecha)
                .ToList();

            foreach (var rel in ejemplaresAsociados)
            {
                if (BD.BD.tablaEjemplares.Contains(rel.Id.CodEjemplar))
                {
                    var eDato = BD.BD.tablaEjemplares[rel.Id.CodEjemplar];

                    Documento doc = null;
                    if (BD.BD.tablaAudiolibros.Contains(eDato.Id))
                        doc = Transformers.Audiolibro(BD.BD.tablaAudiolibros[eDato.Id]);
                    else if (BD.BD.tablaFisicos.Contains(eDato.Id))
                        doc = Transformers.Fisico(BD.BD.tablaFisicos[eDato.Id]);

                    if (doc != null)
                    {
                        pDominio.Ejemplares.Add(Transformers.Ejemplar(eDato, doc));
                    }
                }
            }

            return pDominio;
        }

        public bool UpdatePrestamo(Prestamo prestamo)
        {
            var clave = new ClavePrestamo(prestamo.Usuario.DNI, prestamo.FechaPrestamo);
            if (!BD.BD.tablaPrestamos.Contains(clave)) return false;

            DeletePrestamo(prestamo);
            return CreatePrestamo(prestamo);
        }

        public bool DeletePrestamo(Prestamo prestamo)
        {
            var clave = new ClavePrestamo(prestamo.Usuario.DNI, prestamo.FechaPrestamo);
            if (!BD.BD.tablaPrestamos.Contains(clave)) return false;

            var relaciones = BD.BD.tablaPrestamoEjemplar
                .Where(pe => pe.Id.Dni == clave.Dni && pe.Id.Fecha == clave.Fecha)
                .ToList();

            foreach (var rel in relaciones)
            {
                BD.BD.tablaPrestamoEjemplar.Remove(rel.Id);
            }

            BD.BD.tablaPrestamos.Remove(clave);
            return true;
        }

        public List<Prestamo> GetAllPrestamos()
        {
            List<Prestamo> listaCompleta = new List<Prestamo>();
            foreach (var pDato in BD.BD.tablaPrestamos)
            {
                var pTemp = new Prestamo(new Usuario(pDato.Id.Dni), pDato.Id.Fecha);
                listaCompleta.Add(ReadPrestamo(pTemp));
            }

            return listaCompleta;
        }
    }
}