using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class Audiolibro : Documento
    {
        private string formato;
        private int duracion;
        public Audiolibro(string isbn) : base(isbn)
        {

        }

        public Audiolibro(string isbn, int duracion, string formato) : this(isbn)
        {
            this.duracion = duracion;
            this.formato = formato;
        }

        public string Formato {
            get{  return this.formato; }
            set { this.formato = value; }
        }
        public int Duracion
        {
            get {return this.duracion; }
            set {this.duracion=value; }
        }
    }
}
