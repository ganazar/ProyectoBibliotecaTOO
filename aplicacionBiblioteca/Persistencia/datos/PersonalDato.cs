using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Datos
{
    internal class PersonalDato : Entity<string>
    {
        private string nombre;

        public PersonalDato(string NSS, string nombre) : base(NSS) {
            this.nombre = nombre;
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
    }
}
