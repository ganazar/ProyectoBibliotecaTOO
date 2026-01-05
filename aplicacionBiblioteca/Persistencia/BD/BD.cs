using modeloDominio;
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
        private static Tabla<string, EjemplarDato> tablaejemplares;
        private static Tabla<string, AudiolibroDato> tablaaudiolibros;
        private static Tabla<string, DocumentoDato> tabladocumentos;
        private static Tabla<string, FisicoDato> tablafisicos;
        private static Tabla<string, PersonalAdquisicionDato> tablapersonalAdquisiciones;
        private static Tabla<string, PersonalDato> tablapersonal;
        private static Tabla<string, PersonalSalaDato> tablapersonalSala;
        private static Tabla<ClavePrestamo, PrestamoDato> tablaprestamos;
        private static Tabla<ClavePrestamoEjemplar, PrestamoEjemplar> tablaprestamosEjemplares;
        private static Tabla<string, UsuarioDato> tablausuarios;
        static BD()
        {
            UsuarioDato u1 = new UsuarioDato("11111111A", "Ana Álvarez");
            tablaUsuarios.Add(u1);

            UsuarioDato u2 = new UsuarioDato("22222222B", "Javier Bueno");
            tablaUsuarios.Add(u2);

            UsuarioDato u3 = new UsuarioDato("99999999Z", "Zacarías Flores");
            tablaUsuarios.Add(u3);

            UsuarioDato u4 = new UsuarioDato("55555555X", "Javier Bueno"); // Mismo nombre
            tablaUsuarios.Add(u4);

            UsuarioDato u5 = new UsuarioDato("00000001R", "Beatriz Primera");
            tablaUsuarios.Add(u5);
        }
        public static Tabla<string, EjemplarDato> tablaEjemplares
        {
            get
            {
                if (tablaejemplares == null)
                {
                    tablaejemplares = new Tabla<string, EjemplarDato>();
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

        public static Tabla<string, PersonalDato> tablaPersonal
        {
            get
            {
                if (tablapersonal == null)
                {
                    tablapersonal = new Tabla<string, PersonalDato>();
                }
                return tablapersonal;
            }
        }

        public static Tabla<string, PersonalSalaDato> tablaPersonalSala
        {
            get
            {
                if (tablapersonalSala == null)
                {
                    tablapersonalSala = new Tabla<string, PersonalSalaDato>();
                }
                return tablapersonalSala;
            }
        }
        public static Tabla<ClavePrestamo, PrestamoDato> tablaPrestamos
        {
            get
            { 
                if (tablaprestamos == null)
                {
                    tablaprestamos = new Tabla<ClavePrestamo, PrestamoDato>();
                }
                return tablaprestamos;
            }
        }

        public static Tabla<ClavePrestamoEjemplar,PrestamoEjemplar> tablaPrestamoEjemplar{
            get
            {
                if (tablaprestamosEjemplares == null)
                {
                    tablaprestamosEjemplares = new Tabla<ClavePrestamoEjemplar, PrestamoEjemplar> ();
                }
                return tablaprestamosEjemplares;
            }
        }

        public static Tabla<string, UsuarioDato> tablaUsuarios
        {
            get { 
                if (tablausuarios == null)
                {
                    tablausuarios = new Tabla<string, UsuarioDato> ();
                }
                return tablausuarios;
            }
        }

    }
}
