using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Datos
{
    internal class EjemplarDato : Entity<string>
    {

        public EjemplarDato(string codigo, string doc) : base(codigo)
        {

        }
    }
}
