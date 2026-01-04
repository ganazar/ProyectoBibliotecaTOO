using modeloDominio;
using Persistencia.Interfaces;
using Persistencia.BD;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia.Repositorios
{
    public class PersistenciaAdquisiciones : IPersistenciaAdquisiciones
    {
        public bool CreateAudiolibro(Audiolibro audiolibro)
        {
            if (BD.BD.tablaAudiolibros.Contains(audiolibro.ISBN)) return false;

            BD.BD.tablaAudiolibros.Add(Transformers.AudiolibroDato(audiolibro));
            return true;
        }

        public Audiolibro ReadAudiolibro(Audiolibro audiolibro)
        {
            if (BD.BD.tablaAudiolibros.Contains(audiolibro.ISBN))
            {
                return Transformers.Audiolibro(BD.BD.tablaAudiolibros[audiolibro.ISBN]);
            }
            return null;
        }

        public bool UpdateAudiolibro(Audiolibro audiolibro)
        {
            if (!BD.BD.tablaAudiolibros.Contains(audiolibro.ISBN)) return false;

            BD.BD.tablaAudiolibros.Remove(audiolibro.ISBN);
            BD.BD.tablaAudiolibros.Add(Transformers.AudiolibroDato(audiolibro));
            return true;
        }

        public bool DeleteAudiolibro(Audiolibro audiolibro)
        {
            if (!BD.BD.tablaAudiolibros.Contains(audiolibro.ISBN)) return false;

            BD.BD.tablaAudiolibros.Remove(audiolibro.ISBN);
            return true;
        }

        public List<Audiolibro> GetAllAudiolibros()
        {
            return BD.BD.tablaAudiolibros.Select(a => Transformers.Audiolibro(a)).ToList();
        }
        public bool CreateFisico(Fisico fisico)
        {
            if (BD.BD.tablaFisicos.Contains(fisico.ISBN)) return false;

            BD.BD.tablaFisicos.Add(Transformers.FisicoDato(fisico));
            return true;
        }

        public Fisico ReadFisico(Fisico fisico)
        {
            if (BD.BD.tablaFisicos.Contains(fisico.ISBN))
            {
                return Transformers.Fisico(BD.BD.tablaFisicos[fisico.ISBN]);
            }
            return null;
        }

        public bool UpdateFisico(Fisico fisico)
        {
            if (!BD.BD.tablaFisicos.Contains(fisico.ISBN)) return false;

            BD.BD.tablaFisicos.Remove(fisico.ISBN);
            BD.BD.tablaFisicos.Add(Transformers.FisicoDato(fisico));
            return true;
        }

        public bool DeleteFisico(Fisico fisico)
        {
            if (!BD.BD.tablaFisicos.Contains(fisico.ISBN)) return false;

            BD.BD.tablaFisicos.Remove(fisico.ISBN);
            return true;
        }

        public List<Fisico> GetAllFisicos()
        {
            return BD.BD.tablaFisicos.Select(f => Transformers.Fisico(f)).ToList();
        }
        public bool CreateDocumento(Documento documento)
        {
            if (documento is Audiolibro audiolibro) return CreateAudiolibro(audiolibro);
            if (documento is Fisico fisico) return CreateFisico(fisico);
            return false;
        }

        public Documento ReadDocumento(Documento documento)
        {
            if (BD.BD.tablaAudiolibros.Contains(documento.ISBN))
                return Transformers.Audiolibro(BD.BD.tablaAudiolibros[documento.ISBN]);

            if (BD.BD.tablaFisicos.Contains(documento.ISBN))
                return Transformers.Fisico(BD.BD.tablaFisicos[documento.ISBN]);

            return null;
        }

        public bool UpdateDocumento(Documento documento)
        {
            if (documento is Audiolibro audiolibro) return UpdateAudiolibro(audiolibro);
            if (documento is Fisico fisico) return UpdateFisico(fisico);
            return false;
        }

        public bool DeleteDocumento(Documento documento)
        {
            bool borradoAudio = false;
            if (BD.BD.tablaAudiolibros.Contains(documento.ISBN))
                borradoAudio = DeleteAudiolibro(new Audiolibro(documento.ISBN));

            bool borradoFisico = false;
            if (BD.BD.tablaFisicos.Contains(documento.ISBN))
                borradoFisico = DeleteFisico(new Fisico(documento.ISBN));

            return borradoAudio || borradoFisico;
        }

        public List<Documento> GetAllDocumentos()
        {
            var lista = new List<Documento>();
            lista.AddRange(GetAllAudiolibros());
            lista.AddRange(GetAllFisicos());
            return lista;
        }
        public bool CreateUsuario(Usuario user)
        {
            if (BD.BD.tablaUsuarios.Contains(user.DNI)) return false;

            BD.BD.tablaUsuarios.Add(Transformers.UsuarioDato(user));
            return true;
        }

        public Usuario ReadUsuario(Usuario user)
        {
            if (BD.BD.tablaUsuarios.Contains(user.DNI))
            {
                return Transformers.Usuario(BD.BD.tablaUsuarios[user.DNI]);
            }
            return null;
        }

        public bool UpdateUsuario(Usuario user)
        {
            if (!BD.BD.tablaUsuarios.Contains(user.DNI)) return false;

            BD.BD.tablaUsuarios.Remove(user.DNI);
            BD.BD.tablaUsuarios.Add(Transformers.UsuarioDato(user));
            return true;
        }

        public bool DeleteUsuario(Usuario user)
        {
            if (!BD.BD.tablaUsuarios.Contains(user.DNI)) return false;

            BD.BD.tablaUsuarios.Remove(user.DNI);
            return true;
        }

        public List<Usuario> GetAllUsuarios()
        {
            return BD.BD.tablaUsuarios.Select(u => Transformers.Usuario(u)).ToList();
        }
    }
}