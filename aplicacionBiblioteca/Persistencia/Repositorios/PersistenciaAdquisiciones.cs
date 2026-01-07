using modeloDominio;
using Persistencia.Interfaces;
using Persistencia.BD;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia.Repositorios
{
    public class PersistenciaAdquisiciones : PersistenciaPersonal, IPersistenciaAdquisiciones
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
        public bool CreateEjemplar(Ejemplar ejemplar)
        {
            if (BD.BD.tablaEjemplares.Contains(ejemplar.CodEjemplar)) return false;

            var ejemplarDato = Transformers.EjemplarDato(ejemplar);
            UpdateDocumento(ejemplar.Doc);
            BD.BD.tablaEjemplares.Add(ejemplarDato);
            return true;
        }

        public bool UpdateEjemplar(Ejemplar ejemplar)
        {
            if (!BD.BD.tablaEjemplares.Contains(ejemplar.CodEjemplar)) return false;

            BD.BD.tablaEjemplares.Remove(ejemplar.CodEjemplar);
            BD.BD.tablaEjemplares.Add(Transformers.EjemplarDato(ejemplar));
            return true;
        }

        public bool DeleteEjemplar(Ejemplar ejemplar)
        {
            if (!BD.BD.tablaEjemplares.Contains(ejemplar.CodEjemplar)) return false;

            BD.BD.tablaEjemplares.Remove(ejemplar.CodEjemplar);
            return true;
        }
    }
}