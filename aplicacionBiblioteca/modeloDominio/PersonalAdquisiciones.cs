using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class PersonalAdquisiciones : Personal
    {
        public PersonalAdquisiciones(string nss) : base(nss)
        {

        }

        public PersonalAdquisiciones(string nss, string nombre) : base(nss, nombre)
        {

        }
    }
}
