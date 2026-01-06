using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public abstract class Documento
    {
        private string isbn;
        private string titulo;
        private string autor;
        private string editorial;
        private int añoEdicion;
        private int cantEjemplares;

        public Documento(string isbn)
        {
            this.isbn = isbn;
        }
        public Documento(string isbn,string titulo, string autor, string editorial,int añoEdicion)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.añoEdicion = añoEdicion ;
            this.cantEjemplares = 1;
        }
        public Documento(string isbn, string titulo, string autor, string editorial, int añoEdicion, int cantEjemplares)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.añoEdicion = añoEdicion;
            this.cantEjemplares = cantEjemplares;
        }
        public string ISBN {
            get { return this.isbn; }
        }
        public string Titulo {
            get { return this.titulo; }
            set { this.titulo = value; }
        }
        public string Autor {
            get { return this.autor; }
            set { this.autor = value; }
        }
        public string Editorial {
            get { return this.editorial; }
            set { this.editorial = value; }
        }
        public int AñoEdicion {
            get { return this.añoEdicion; }
            set {this.añoEdicion=value; } 
        }

        public int CantEjemplares
        {
            get { return this.cantEjemplares; }
            set { this.cantEjemplares = value; }
        }
    
    }
}
