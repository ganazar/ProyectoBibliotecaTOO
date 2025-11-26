using Persistencia.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.BD
{
    internal static class BD
    {
        private static Tabla<string, PersonalAdquisicionDato> tablaejemplares;
        private static Tabla<string, AudiolibroDato> tablaaudiolibros;
        private static Tabla<string,DocumentoDato> tabladocumentos;
        private static Tabla<string, FisicoDato> tablafisicos;
        private static Tabla<string, PersonalAdquisicionDato> tablapersonalAdquisiciones;
        private static Tabla<string, PersonalDato> tablapersonal;
        private static Tabla<string, PersonalSalaDato> tablapersonalSala;
        private static Tabla<string, PrestamoDato> tablaprestamos;
        private static Tabla<string, PrestamoEjemplar> tablaprestamosEjemplares;
        private static Tabla<string, UsuarioDato> tablausuarios;

        public static Tabla<string, PersonalAdquisicionDato> tablaEjemplares
        {
            get
            {
                if (tablaejemplares == null)
                {
                    tablaejemplares = new Tabla<string, PersonalAdquisicionDato>();
                }
                return tablaejemplares;

            }
        }

        public static Tabla<string, AudiolibroDato> tablaAudiolibros
        {
            get
            {
                if (tablaaudiolibros == null)
                {
                    tablaaudiolibros = new Tabla<string, AudiolibroDato>();
                }
                return tablaaudiolibros;

            }
        }
        public static Tabla<string, DocumentoDato> tablaDocumentos
        {
            get
            {
                if (tabladocumentos == null)
                {
                    tabladocumentos = new Tabla<string, DocumentoDato>();
                }
                return tabladocumentos;

            }
        }

        public static Tabla<string, FisicoDato> tablaFisicos
        {
            get
            {
                if (tablafisicos == null)
                {
                    tablafisicos = new Tabla<string, FisicoDato>();
                }
                return tablafisicos;

            }
        }

        public static Tabla<string, PersonalAdquisicionDato> tablaPersonalAdquisiciones
        {
            get
            {
                if (tablapersonalAdquisiciones == null)
                {
                    tablapersonalAdquisiciones = new Tabla<string, PersonalAdquisicionDato>();
                }
                return tablapersonalAdquisiciones;

            }
        }


    }
}
