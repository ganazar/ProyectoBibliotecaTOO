using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Presentacion.Personal
{
    public partial class FIntroducirClave : Form
    {
        private string clave;
        public string Clave { get { return clave; }}
        public FIntroducirClave(string nombre)
        {
            InitializeComponent();
            Text = "Introducir " + nombre;
            lbClave.Text = nombre+":";
            tbClave.Focus();
        }
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbClave.Text))
            {
                MessageBox.Show("Introduzca un DNI","Error");
                return;
            }

            //if (!DniValido(tbClave.Text))
            //{
            //    MessageBox.Show("El formato del DNI no es válido o la letra es incorrecta.\nEjemplo: 12345678Z",
            //                    "DNI Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    tbClave.SelectAll();
            //    tbClave.Focus();
            //    return;
            //}

            clave = tbClave.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        /// <summary>
        /// Verifica si una cadena de texto cumple con el formato oficial del DNI español.
        /// </summary>
        /// <param name="dni">La cadena que contiene el DNI a validar.</param>
        /// <returns>
        /// <c>true</c> si tiene 8 dígitos seguidos de la letra de control correcta(modulo 23); 
        /// <c>false</c> si el formato es incorrecto o la letra no coincide con el algoritmo matemático.
        /// </returns>
        private bool DniValido(string dni)
        {
            if (!Regex.IsMatch(dni, @"^\d{8}[A-Z]$"))
            {
                return false;
            }

            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            int numero = int.Parse(dni.Substring(0, 8));

            return letras[numero % 23] == dni[8];
        }
    }
}
