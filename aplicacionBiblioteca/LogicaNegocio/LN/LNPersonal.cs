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
            if (user == null) return null;
            return persistencia.ReadUsuario(user);
        }

        public Usuario ConsultarUsuarioPorDni(string dni)
        {
            return persistencia.GetAllUsuarios().FirstOrDefault(u => u.DNI.Equals(dni));
        }

        public bool DarAltaUsuario(Usuario user)
        {
            if (user == null) return false;
            return persistencia.CreateUsuario(user);
        }

        public bool DarBajaUsuario(Usuario user)
        {
            if (user == null) return false;
            return persistencia.DeleteUsuario(user);
        }

        public bool ModificarDatosUsuario(Usuario user)
        {
            if (user == null) return false;
            return persistencia.UpdateUsuario(user);
        }
        public List<Usuario> GetAllUsuarios()
        {
            return persistencia.GetAllUsuarios();
        }
    }
}
