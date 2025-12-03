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
            return new Audiolibro(a.Id,a.Duracion,a.Formato);
        }

        public static AudiolibroDato AudiolibroDato(Audiolibro a)
        {
            return new AudiolibroDato(a.ISBN,a.Titulo,a.Autor,a.Editorial,a.AñoEdicion,a.Formato,a.Duracion);
        }

        public static Documento Documento(DocumentoDato d)
        {
            return new Documento();
        }

        public static DocumentoDato DocumentoDato(Documento d) {
            return new DocumentoDato();
        }

        public static Ejemplar Ejemplar(EjemplarDato e)
        {
            return new Ejemplar();
        }

        public static EjemplarDato EjemplarDato(Ejemplar e)
        {
            return new EjemplarDato();
        }

        public static FisicoDato FisicoDato(Fisico f)
        {
            return new FisicoDato();
        }

        public static Fisico Fisico(FisicoDato f)
        {
            return new modeloDominio.Fisico();
        }

        public s
    }
}
