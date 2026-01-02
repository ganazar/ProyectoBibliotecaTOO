using LogicaNegocio.InterfacesLN;
using modeloDominio;
using Persistencia;
using Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class LNPersonalAdquisiciones : LNPersonal, ILNPersonalAdquisiciones
    {
        private readonly IPersistenciaAdquisiciones persistencia;
        public LNPersonalAdquisiciones(IPersistenciaAdquisiciones _persistencia) : base(_persistencia)
        {
            persistencia = _persistencia;
        }
        public bool ConsultarDisponibilidadDocumento(Documento d)
        {
            throw new NotImplementedException();
        }

        public Documento ConsultarDocumento()
        {
            throw new NotImplementedException();
        }

        public List<Ejemplar> ConsultarEjemplaresDocumentos(Documento d)
        {
            throw new NotImplementedException();
        }

        public DateTime ConsultarFechaDisponibilidad(Documento d)
        {
            throw new NotImplementedException();
        }

        public bool DarAltaDocumento(Documento d)
        {
            throw new NotImplementedException();
        }

        public bool DarAltaEjemplar(Ejemplar e)
        {
            throw new NotImplementedException();
        }

        public bool DarBajaDocumento(Documento d)
        {
            throw new NotImplementedException();
        }

        public bool DarBajaEjemplar(Ejemplar e)
        {
            throw new NotImplementedException();
        }

        public Documento MasLeido()
        {
            throw new NotImplementedException();
        }
    }
}
