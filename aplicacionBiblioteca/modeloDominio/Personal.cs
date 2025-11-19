using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public abstract class Personal
    {
        private string nss;
        private string nombre;
        public Personal(string nss)
        {
            this.nss = nss;
        }

        public Personal(string nss, string nombre)
        {
            this.nss = nss;
            this.nombre = nombre;
        }
        public string NSS { 
            get { return nss; } 
        }

        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }
    }
}
