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
            this.fecha = fecha.Date;
        }
        public string Dni { 
            get { 
                return this.dni; 
            } 
        }
        public DateTime Fecha { get { return this.fecha; } }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            ClavePrestamo otra = (ClavePrestamo)obj;
            return string.Equals(this.dni, otra.dni, StringComparison.OrdinalIgnoreCase)
                   && this.fecha == otra.fecha;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (dni != null ? dni.ToLower().GetHashCode() : 0);
                hash = hash * 23 + fecha.GetHashCode();
                return hash;
            }
        }
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
