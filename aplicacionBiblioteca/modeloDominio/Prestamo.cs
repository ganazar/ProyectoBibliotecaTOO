using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class Prestamo
    {
        private Usuario usuario;
        private List<Ejemplar> ejemplares;
        private DateTime fechaPrestamo;
        private EstadoPrestamo estado;
        public Prestamo(Usuario u, DateTime fecha)
        {
            this.usuario = u;
            this.fechaPrestamo = fecha;
        }

        public Prestamo(Usuario usuario, List<Ejemplar> ejemplares, DateTime fecha, EstadoPrestamo estado)
        {
            this.usuario = usuario;
            this.ejemplares = ejemplares;
            this.fechaPrestamo = fecha;
            this.estado = estado;
        }

        public Usuario Usuario
        {
            get { return this.usuario; }
        }
        public DateTime FechaPrestamo{
            get {return this.fechaPrestamo; }
        }
        public List<Ejemplar> Ejemplares
        {
            get {return this.ejemplares; }
            set {this.ejemplares = value; }
        }
        public EstadoPrestamo Estado
        {
            get { return this.estado; }
            set { this.estado=value; }
        }

        public DateTime FechaDevolucion(Ejemplar e)
        {
            if (e.Doc is Audiolibro)
            {
                return fechaPrestamo.AddDays(10);
            }
            else
            {
                return fechaPrestamo.AddDays(15);
            } 
        }

    }

    public enum EstadoPrestamo{
        EnProceso=0, Finalizado=1
    }
}
