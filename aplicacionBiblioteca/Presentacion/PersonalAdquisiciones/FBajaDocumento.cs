using modeloDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion.PersonalAdquisiciones
{
    public partial class FBajaDocumento : Form
    {
        private string titulo, autor, editorial, tipoDocumento, formato;
        private int anoEdicion, duracion;
        public string Titulo { get { return titulo; } }
        public string Autor { get { return autor; } }
        public string Editorial { get { return editorial; } }
        public int AnoEdicion { get { return anoEdicion; } }
        public string TipoDocumento { get { return tipoDocumento; } }
        public int Duracion { get { return duracion; } }
        public string Formato { get { return formato; } }
        private void tbAnoEdicion_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(tbAnoEdicion.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbAnoEdicion.Text = string.Empty;
            }
        }
        private void tbDuracion_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbDuracion.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbDuracion.Text = string.Empty;
            }
        }

        public FBajaDocumento(Documento doc)
        {
            InitializeComponent();
            tbISBN.Text = doc.ISBN;
            tbISBN.ReadOnly = true;
            tbTitulo.Text = doc.Titulo;
            tbTitulo.ReadOnly = true;
            tbAutor.Text = doc.Autor;
            tbAutor.ReadOnly = true;
            tbEditorial.Text = doc.Editorial;
            tbEditorial.ReadOnly = true;
            tbAnoEdicion.Text = doc.AñoEdicion.ToString();
            var audioLibro = doc as Audiolibro;
            if (audioLibro != null)
            {
                rbAudiolibro.Checked = true;
                tbDuracion.Text = audioLibro.Duracion.ToString();
                tbDuracion.ReadOnly = true;
                tbFormato.Text = audioLibro.Formato;
                tbFormato.ReadOnly = true;
            }
            else if(doc is Fisico)
            {
                rbLibro.Checked = true;
            }
        }

        private void rbAudiolibro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAudiolibro.Checked)
            {
                label5.Visible = true;
                tbDuracion.Visible = true;
                label6.Visible = true;
                tbFormato.Visible = true;
            }
            else
            {
                label5.Visible = false;
                tbDuracion.Visible = false;
                label6.Visible = false;
                tbFormato.Visible = false;
            }
        }

        private void FAltaDocumento_FormClosed(object sender, FormClosedEventArgs e)
        {
            titulo = tbTitulo.Text;
            autor = tbAutor.Text;
            editorial = tbEditorial.Text;
            anoEdicion = int.Parse(tbAnoEdicion.Text);
            if (rbLibro.Checked)
            {
                tipoDocumento = "Fisico";
            }
            if (rbAudiolibro.Checked)
            {
                tipoDocumento = "Audiolibro";
                duracion = int.Parse(tbDuracion.Text);
                formato = tbFormato.Text;
            }
        }
    }
}
