using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class Fisico : Documento
    {
        public Fisico(string isbn, string titulo, string autor, string editorial, int añoEdicion) 
            : base(isbn, titulo, autor, editorial, añoEdicion) 
        { }
        public Fisico(string isbn, string titulo, string autor, string editorial, int añoEdicion, int cantEjemplares)
            : base(isbn, titulo, autor, editorial, añoEdicion, cantEjemplares)
        { }
        public Fisico(string isbn) : base(isbn) { }
    }
}
