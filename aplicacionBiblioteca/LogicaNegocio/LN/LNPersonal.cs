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
        private readonly IPersistenciaPersonal persitencia;
        public LNPersonal(IPersistenciaPersonal _persistencia)
        {
            persitencia = _persistencia;
        }
        public Usuario ConsultarUsuario(Usuario user)
        {
            return persitencia.ReadUsuario(user);
        }

        public Usuario ConsultarUsuarioPorDni(string dni)
        {
            return persitencia.GetAllUsuarios().First(u => u.DNI.Equals(dni));
        }

        public bool DarAltaUsuario(Usuario user)
        {
            return persitencia.CreateUsuario(user);
        }

        public bool DarBajaUsuario(Usuario user)
        {
            return persitencia.DeleteUsuario(user);
        }

        public bool ModificarDatosUsuario(Usuario user)
        {
            return persitencia.UpdateUsuario(user);
        }
    }
}
