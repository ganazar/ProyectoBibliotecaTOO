using modeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Datos
{
    internal class EjemplarDato : Entity<string>
    {
        private bool prestado;
        private string isbn_doc;
        public EjemplarDato(string codigo, bool prestado, string isbn_doc) : base(codigo)
        {

            this.prestado = prestado;
            this.isbn_doc = isbn_doc;
        }
    }
}
