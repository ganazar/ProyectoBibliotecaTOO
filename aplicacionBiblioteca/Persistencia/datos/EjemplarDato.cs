using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Datos
{
    internal class PersonalAdquisicionesDato : Entity<string>
    {

        public PersonalAdquisicionesDato(string codigo, string doc) : base(codigo)
        {

        }
    }
}
