using modeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Datos
{
    internal class ClavePrestamoEjemplar
    {
        private string dni;
        private DateTime fecha;
        private string codEjemplar;

        public ClavePrestamoEjemplar(string dni, DateTime fecha, string codEjemplar)
        {
            this.dni = dni;
            this.fecha = fecha.Date;
            this.codEjemplar = codEjemplar;
        }
        public string Dni
        {
            get
            {
                return this.dni;
            }
        }
        public DateTime Fecha {
            get {
                return this.fecha;
            }
        }
        public string CodEjemplar
        {
            get
            {
                return this.codEjemplar;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ClavePrestamoEjemplar otra = (ClavePrestamoEjemplar)obj;
            return string.Equals(this.dni, otra.dni, StringComparison.OrdinalIgnoreCase)
                   && this.fecha == otra.fecha
                   && string.Equals(this.codEjemplar, otra.codEjemplar, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (dni != null ? dni.ToLower().GetHashCode() : 0);
                hash = hash * 23 + fecha.GetHashCode();
                hash = hash * 23 + (codEjemplar != null ? codEjemplar.ToLower().GetHashCode() : 0);
                return hash;
            }
        }
    }
    internal class PrestamoEjemplar : Entity<ClavePrestamoEjemplar>
        {
            public PrestamoEjemplar(ClavePrestamoEjemplar id) : base(id)
            {

            }            
    }
}

 