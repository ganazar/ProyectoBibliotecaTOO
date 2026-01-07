using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class Usuario
    {
        private string dni;
        private string nombre;

        public Usuario(string dni)
        {
            this.dni = dni;
        }

        public Usuario(string dni, string nombre) {
            this.dni = dni;
            this.nombre = nombre;
        }
        public string DNI
        {
            get { return this.dni; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre= value; }
        }
        public override string ToString()
        {
            return this.dni;
        }
    }
}
