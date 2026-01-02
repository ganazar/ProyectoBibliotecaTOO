using modeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesLN
{
    public interface ILNPersonalAdquisiciones : ILNPersonal
    {
        Documento MasLeido();
        Documento ConsultarDocumento();
        bool DarAltaEjemplar(Ejemplar e);
        bool DarBajaEjemplar(Ejemplar e);
        bool DarAltaDocumento(Documento d);
        bool DarBajaDocumento(Documento d);
        bool ConsultarDisponibilidadDocumento(Documento d);
        DateTime ConsultarFechaDisponibilidad(Documento d);
        List<Ejemplar> ConsultarEjemplaresDocumentos(Documento d);

    }
}
