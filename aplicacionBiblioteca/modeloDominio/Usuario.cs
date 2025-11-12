using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class Usuario
    {
        public Usuario(string dni)
        {
            DNI = dni;
        }
        public string DNI { get; }
        public string Nombre { get; set; }
    }
}
