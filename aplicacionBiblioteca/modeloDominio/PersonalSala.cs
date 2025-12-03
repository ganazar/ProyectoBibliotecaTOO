using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class PersonalSala : Personal
    {
        public PersonalSala (String nss) : base(nss)
        {

        }

        public PersonalSala(string nss, string nombre) : base(nss, nombre)
        {
        }
    }
}
