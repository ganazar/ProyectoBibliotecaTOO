using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public abstract class Personal
    {
        public Personal(string nss)
        {
            NSS = nss;
        }
        public string NSS { get; }
    }
}
