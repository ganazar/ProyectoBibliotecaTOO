namespace Presentacion.PersonalAdquisiciones
{
    partial class FBajaDocumento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAudiolibro = new System.Windows.Forms.RadioButton();
            this.rbLibro = new System.Windows.Forms.RadioButton();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEditorial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDuracion = new System.Windows.Forms.TextBox();
            this.tbFormato = new System.Windows.Forms.TextBox();
            this.tbAnoEdicion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN:";
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(93, 34);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(105, 20);
            this.tbISBN.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFormato);
            this.groupBox1.Controls.Add(this.tbDuracion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbAudiolibro);
            this.groupBox1.Controls.Add(this.rbLibro);
            this.groupBox1.Location = new System.Drawing.Point(30, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 92);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de documento";
            // 
            // rbAudiolibro
            // 
            this.rbAudiolibro.AutoSize = true;
            this.rbAudiolibro.Location = new System.Drawing.Point(18, 55);
            this.rbAudiolibro.Name = "rbAudiolibro";
            this.rbAudiolibro.Size = new System.Drawing.Size(71, 17);
            this.rbAudiolibro.TabIndex = 1;
            this.rbAudiolibro.TabStop = true;
            this.rbAudiolibro.Text = "Audiolibro";
            this.rbAudiolibro.UseVisualStyleBackColor = true;
            this.rbAudiolibro.CheckedChanged += new System.EventHandler(this.rbAudiolibro_CheckedChanged);
            // 
            // rbLibro
            // 
            this.rbLibro.AutoSize = true;
            this.rbLibro.Location = new System.Drawing.Point(18, 19);
            this.rbLibro.Name = "rbLibro";
            this.rbLibro.Size = new System.Drawing.Size(48, 17);
            this.rbLibro.TabIndex = 0;
            this.rbLibro.TabStop = true;
            this.rbLibro.Text = "Libro";
            this.rbLibro.UseVisualStyleBackColor = true;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(93, 71);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(298, 20);
            this.tbTitulo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Título:";
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(93, 102);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(298, 20);
            this.tbAutor.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Autor:";
            // 
            // tbEditorial
            // 
            this.tbEditorial.Location = new System.Drawing.Point(93, 132);
            this.tbEditorial.Name = "tbEditorial";
            this.tbEditorial.Size = new System.Drawing.Size(298, 20);
            this.tbEditorial.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Editorial:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Dar alta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Duración:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Formato:";
            this.label6.Visible = false;
            // 
            // tbDuracion
            // 
            this.tbDuracion.Location = new System.Drawing.Point(237, 20);
            this.tbDuracion.Name = "tbDuracion";
            this.tbDuracion.Size = new System.Drawing.Size(100, 20);
            this.tbDuracion.TabIndex = 4;
            this.tbDuracion.Visible = false;
            this.tbDuracion.TextChanged += new System.EventHandler(this.tbDuracion_TextChanged);
            // 
            // tbFormato
            // 
            this.tbFormato.Location = new System.Drawing.Point(237, 54);
            this.tbFormato.Name = "tbFormato";
            this.tbFormato.Size = new System.Drawing.Size(100, 20);
            this.tbFormato.TabIndex = 5;
            this.tbFormato.Visible = false;
            // 
            // tbAnoEdicion
            // 
            this.tbAnoEdicion.Location = new System.Drawing.Point(93, 162);
            this.tbAnoEdicion.Name = "tbAnoEdicion";
            this.tbAnoEdicion.Size = new System.Drawing.Size(298, 20);
            this.tbAnoEdicion.TabIndex = 16;
            this.tbAnoEdicion.TextChanged += new System.EventHandler(this.tbAnoEdicion_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "AñoEdicion:";
            // 
            // FAltaDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 349);
            this.Controls.Add(this.tbAnoEdicion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbEditorial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.label1);
            this.Name = "FAltaDocumento";
            this.Text = "Alta de documento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FAltaDocumento_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAudiolibro;
        private System.Windows.Forms.RadioButton rbLibro;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEditorial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbFormato;
        private System.Windows.Forms.TextBox tbDuracion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAnoEdicion;
        private System.Windows.Forms.Label label7;
    }
}