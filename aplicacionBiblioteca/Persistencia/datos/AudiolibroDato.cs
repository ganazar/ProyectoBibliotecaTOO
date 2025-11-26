using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Datos
{
    internal class AudiolibroDato : DocumentoDato
    {
        private string formato;
        private int duracion;
        public AudiolibroDato(string isbn, string titulo, string autor, string editorial, int añoEdicion, string formato, int duracion)
            : base(isbn, titulo, autor, editorial, añoEdicion)
        {
            this.duracion = duracion;
            this.formato = formato;
        }
    }
}
