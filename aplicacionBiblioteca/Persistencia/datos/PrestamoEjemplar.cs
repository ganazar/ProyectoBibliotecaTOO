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
            this.fecha = fecha;
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
    }
    internal class PrestamoEjemplar : Entity<ClavePrestamoEjemplar>
        {
            public PrestamoEjemplar(ClavePrestamoEjemplar id) : base(id)
            {

            }            
    }
}

 