using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Datos
{
    internal class UsuarioDato : Entity<string>
    {
        private string nombre;

        public UsuarioDato(string dni, string nombre) : base(dni)
        {
            this.nombre = nombre;
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
    }
}
