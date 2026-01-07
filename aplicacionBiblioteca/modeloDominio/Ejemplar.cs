using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class Ejemplar
    {
        private string codEjemplar;
        private Documento doc;
        private bool prestado;

        public Ejemplar(Documento doc)
        {
            this.codEjemplar = doc.Titulo + doc.CantEjemplares;
            this.prestado = false;
            this.doc = doc;
            doc.CantEjemplares += 1;
        }

        public Ejemplar(string codEjemplar)
        {
            this.codEjemplar = codEjemplar;
        }

        public string CodEjemplar {
            get { return this.codEjemplar; }
        }
        public Documento Doc
        {
            get {return this.doc; }
            set {this.doc= value; }
        }

        public bool Prestado
        {
            get { return this.prestado; }
            set { this.prestado = value; }
        }
        public string InfoMostrar
        {
            get
            {
                return $"Codigo: {codEjemplar} Documento: ISBN: {doc.ISBN} Titulo: {doc.Titulo}";
            }
        }
        public string ISBN { get { return doc.ISBN; } }
    }

}
