using LogicaNegocio.InterfacesLN;
using modeloDominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class LNPersonal : ILNPersonal
    {
        private readonly IPersistenciaPersonal persistencia;
        public LNPersonal(IPersistenciaPersonal _persistencia)
        {
            persistencia = _persistencia;
        }
        public Usuario ConsultarUsuario(Usuario user)
        {
            return persistencia.ReadUsuario(user);
        }

        public Usuario ConsultarUsuarioPorDni(string dni)
        {
            return persistencia.GetAllUsuarios().First(u => u.DNI.Equals(dni));
        }

        public bool DarAltaUsuario(Usuario user)
        {
            return persistencia.CreateUsuario(user);
        }

        public bool DarBajaUsuario(Usuario user)
        {
            return persistencia.DeleteUsuario(user);
        }

        public bool ModificarDatosUsuario(Usuario user)
        {
            return persistencia.UpdateUsuario(user);
        }
    }
}
