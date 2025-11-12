using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class Audiolibro : Documento
    {
        public Audiolibro(string isbn) : base(isbn)
        {

        }
        public string Formato {  get; set; }
        public int Duracion {  get; set; }
    }
}
