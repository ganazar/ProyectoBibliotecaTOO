using modeloDominio;
using Persistencia.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.BD
{
    internal class Transformers
    {
        public static Audiolibro Audiolibro(AudiolibroDato a)
        {
            return new Audiolibro(a.Id,a.Titulo, a.Autor,a.Editorial,a.AñoEdicion,a.Duracion,a.Formato);
        }

        public static AudiolibroDato AudiolibroDato(Audiolibro a)
        {
            return new AudiolibroDato(a.ISBN,a.Titulo,a.Autor,a.Editorial,a.AñoEdicion,a.Formato,a.Duracion);
        }

        public static Ejemplar Ejemplar(EjemplarDato e, Documento d)
        {
            return new Ejemplar(d);
        }

        public static EjemplarDato EjemplarDato(Ejemplar e)
        {
            return new EjemplarDato(e.CodEjemplar,e.Prestado, e.Doc.ISBN);
        }

        public static FisicoDato FisicoDato(Fisico f)
        {
            return new FisicoDato(f.ISBN,f.Titulo,f.Autor,f.Editorial,f.AñoEdicion);
        }

        public static Fisico Fisico(FisicoDato f)
        {
            return new Fisico(f.Id,f.Titulo,f.Autor,f.Editorial,f.AñoEdicion);
        }

        public static PersonalAdquisicionDato PersonalAdquisicionDato(PersonalAdquisiciones p)
        {
            return new PersonalAdquisicionDato(p.NSS, p.Nombre);
        }

        public static PersonalAdquisiciones PersonalAdquisiciones(PersonalAdquisicionDato p)
        {
            return new PersonalAdquisiciones(p.Id, p.Nombre);
        }

        public static PersonalSalaDato PersonalSalaDato(PersonalSala p)
        {
            return new PersonalSalaDato(p.NSS, p.Nombre);
        }

        public static PersonalSala PersonalSala(PersonalSalaDato p)
        {
            return new PersonalSala(p.Id, p.Nombre);
        }

        public static PrestamoDato PrestamoDato(Prestamo p)
        {
            return new PrestamoDato(new ClavePrestamo(p.Usuario.DNI, p.FechaPrestamo), p.Estado);
        }

        public static Prestamo Prestamo(PrestamoDato p)
        {
            return new Prestamo(new Usuario(p.Id.Dni), p.Id.Fecha);
        }

        public static UsuarioDato UsuarioDato(Usuario u)
        {
            return new UsuarioDato(u.DNI, u.Nombre);
        }

        public static Usuario Usuario(UsuarioDato u)
        {
            return new Usuario(u.Id, u.Nombre);
        }
    }
}
