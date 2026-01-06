using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Datos
{
    internal class FisicoDato : DocumentoDato
    {
        public FisicoDato(string isbn, string titulo, string autor, string editorial, int añoEdicion, int cantEjemplares) 
            : base(isbn, titulo, autor, editorial, añoEdicion, cantEjemplares) 
        { }
    }
}
