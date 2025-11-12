using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class Prestamo
    {
        public Prestamo(Usuario u, DateTime fecha)
        {
            Usuario = u;
            FechaPrestamo = fecha;
        }
        public Usuario Usuario { get; }
        public DateTime FechaPrestamo { get; }
        public List<Ejemplar> Ejemplares { get; set; }
        public string estado {  get; set; }
    }
}
