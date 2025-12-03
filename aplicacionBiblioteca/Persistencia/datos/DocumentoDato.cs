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
        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }
        public string Autor
        {
            get { return this.autor; }
            set { this.autor = value; }
        }
        public string Editorial
        {
            get { return this.editorial; }
            set { this.editorial = value; }
        }
        public int AñoEdicion
        {
            get { return this.añoEdicion; }
            set { this.añoEdicion = value; }
        }
    }
}
