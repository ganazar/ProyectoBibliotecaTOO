using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class Documento
    {
        public Documento(string isbn)
        {
            ISBN = isbn;
        }
        public string ISBN { get; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public int AñoEdicion { get; set; }
    }
}
