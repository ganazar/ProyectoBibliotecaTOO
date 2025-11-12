using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class Ejemplar
    {
        public Ejemplar()
        {
            
        }
        public Documento Documento { get; set; }
        public int NumeroEjemplar {  get; set; }
    }
}
