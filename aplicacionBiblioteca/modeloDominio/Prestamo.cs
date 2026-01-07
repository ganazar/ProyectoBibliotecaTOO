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
            this.ejemplares = new List<Ejemplar>();
        }

        public Prestamo(Usuario usuario, List<Ejemplar> ejemplares, DateTime fecha)
        {
            this.usuario = usuario;
            this.ejemplares = ejemplares;
            this.fechaPrestamo = fecha; 
            this.estado = EstadoPrestamo.EnProceso;
        }

        public Usuario Usuario
        {
            get { return this.usuario; }
        }
        public DateTime FechaPrestamo{
            get {return this.fechaPrestamo; }
            set { this.fechaPrestamo = value;}
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
        public int CantidadEjemplares
        {
            get { return Ejemplares != null ? Ejemplares.Count : 0; }
        }

    }

    public enum EstadoPrestamo{
        EnProceso=0, Finalizado=1
    }
}
