using modeloDominio;
using Persistencia.Interfaces;
using Persistencia.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Repositorios
{
    public class PersistenciaPersonal : IPersistenciaPersonal
    {
        public bool CreateUsuario(Usuario user)
        {
            if (BD.BD.tablaUsuarios.Contains(user.DNI))
            {
                return false;
            }

            var usuarioDato = Transformers.UsuarioDato(user);
            BD.BD.tablaUsuarios.Add(usuarioDato);
            return true;
        }

        public Usuario ReadUsuario(Usuario user)
        {
            if (BD.BD.tablaUsuarios.Contains(user.DNI))
            {
                var usuarioDato = BD.BD.tablaUsuarios[user.DNI];
                return Transformers.Usuario(usuarioDato);
            }
            return null;
        }

        public bool UpdateUsuario(Usuario user)
        {
            if (!BD.BD.tablaUsuarios.Contains(user.DNI))
            {
                return false;
            }
            BD.BD.tablaUsuarios.Remove(user.DNI);
            BD.BD.tablaUsuarios.Add(Transformers.UsuarioDato(user));
            return true;
        }

        public bool DeleteUsuario(Usuario user)
        {
            if (!BD.BD.tablaUsuarios.Contains(user.DNI))
            {
                return false;
            }

            BD.BD.tablaUsuarios.Remove(user.DNI);
            return true;
        }

        public List<Usuario> GetAllUsuarios()
        {
            return BD.BD.tablaUsuarios.Select(u => Transformers.Usuario(u)).ToList();
        }

        public Ejemplar ReadEjemplar(Ejemplar ejemplar)
        {
            if (!BD.BD.tablaEjemplares.Contains(ejemplar.CodEjemplar)) return null;

            var eDato = BD.BD.tablaEjemplares[ejemplar.CodEjemplar];

            Documento doc = null;
            if (BD.BD.tablaAudiolibros.Contains(eDato.Doc))
                doc = Transformers.Audiolibro(BD.BD.tablaAudiolibros[eDato.Doc]);
            else if (BD.BD.tablaFisicos.Contains(eDato.Doc))
                doc = Transformers.Fisico(BD.BD.tablaFisicos[eDato.Doc]);

            if (doc == null) return null;

            return Transformers.Ejemplar(eDato, doc);
        }

        public List<Ejemplar> GetAllEjemplares()
        {
            List<Ejemplar> lista = new List<Ejemplar>();

            foreach (var eDato in BD.BD.tablaEjemplares)
            {
                var eDominio = ReadEjemplar(new Ejemplar(eDato.Id));
                if (eDominio != null) lista.Add(eDominio);
            }

            return lista;
        }
    }
}