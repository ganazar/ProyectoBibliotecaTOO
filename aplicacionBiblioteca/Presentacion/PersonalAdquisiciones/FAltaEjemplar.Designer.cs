namespace Presentacion.PersonalAdquisiciones
{
    partial class FAltaEjemplar
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
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDocumentos = new System.Windows.Forms.ComboBox();
            this.rbPrestado = new System.Windows.Forms.RadioButton();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(136, 40);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(121, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Documento (ISBN):";
            // 
            // cbDocumentos
            // 
            this.cbDocumentos.FormattingEnabled = true;
            this.cbDocumentos.Location = new System.Drawing.Point(136, 89);
            this.cbDocumentos.Name = "cbDocumentos";
            this.cbDocumentos.Size = new System.Drawing.Size(121, 21);
            this.cbDocumentos.TabIndex = 3;
            this.cbDocumentos.SelectedIndexChanged += new System.EventHandler(this.cbDocumentos_SelectedIndexChanged);
            // 
            // rbPrestado
            // 
            this.rbPrestado.AutoSize = true;
            this.rbPrestado.Location = new System.Drawing.Point(24, 132);
            this.rbPrestado.Name = "rbPrestado";
            this.rbPrestado.Size = new System.Drawing.Size(67, 17);
            this.rbPrestado.TabIndex = 4;
            this.rbPrestado.TabStop = true;
            this.rbPrestado.Text = "Prestado";
            this.rbPrestado.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(182, 174);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 16;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(24, 174);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 15;
            this.btAceptar.Text = "Dar alta";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // FAltaEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 225);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.rbPrestado);
            this.Controls.Add(this.cbDocumentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label1);
            this.Name = "FAltaEjemplar";
            this.Text = "Alta de ejemplar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FAltaEjemplar_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDocumentos;
        private System.Windows.Forms.RadioButton rbPrestado;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
    }
}