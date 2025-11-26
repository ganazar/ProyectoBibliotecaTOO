using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Datos
{
    internal class DocumentoDato : Entity<string>
    {
        private string titulo;
        private string autor;
        private string editorial;
        private int añoEdicion;

        public DocumentoDato(string isbn, string titulo, string autor, string editorial, int añoEdicion) : base(isbn)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.añoEdicion = añoEdicion;
        }
    }
}
