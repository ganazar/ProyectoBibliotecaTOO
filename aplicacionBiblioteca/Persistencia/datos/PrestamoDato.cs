using modeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Datos
{
    internal class ClavePrestamo
    {
        private string dni;
        private DateTime fecha;
        public ClavePrestamo(string dni, DateTime fecha)
        {
            this.dni = dni;
            this.fecha = fecha;
        }
        public string Dni { 
            get { 
                return this.dni; 
            } 
        }
        public DateTime Fecha { get { return this.fecha; } }
    }

    internal class PrestamoDato : Entity<ClavePrestamo>
    {
        private EstadoPrestamo estado;
        public PrestamoDato(ClavePrestamo id, EstadoPrestamo estado) : base(id)
        {
            this.estado = estado;
        }
        public EstadoPrestamo Estado { 
            get { 
                return this.estado; 
            } 
        }
    }

}
