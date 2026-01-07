namespace Presentacion.PersonalSala
{
    partial class FAltaPrestamo
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
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAñadirEjem = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gbEjemplares = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbEjemplares.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFecha
            // 
            this.tbFecha.Enabled = false;
            this.tbFecha.Location = new System.Drawing.Point(265, 90);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(192, 31);
            this.tbFecha.TabIndex = 1;
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(265, 165);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(192, 33);
            this.cbUsuario.TabIndex = 2;
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(453, 549);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(173, 50);
            this.btAceptar.TabIndex = 3;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(704, 549);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(173, 50);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btAñadirEjem
            // 
            this.btAñadirEjem.Location = new System.Drawing.Point(72, 278);
            this.btAñadirEjem.Name = "btAñadirEjem";
            this.btAñadirEjem.Size = new System.Drawing.Size(385, 38);
            this.btAñadirEjem.TabIndex = 5;
            this.btAñadirEjem.Text = "Añadir ejemplar";
            this.btAñadirEjem.UseVisualStyleBackColor = true;
            this.btAñadirEjem.Click += new System.EventHandler(this.btAñadirEjem_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(67, 96);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(78, 25);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(67, 173);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(92, 25);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario:";
            // 
            // gbEjemplares
            // 
            this.gbEjemplares.Controls.Add(this.flowLayoutPanel1);
            this.gbEjemplares.Location = new System.Drawing.Point(566, 90);
            this.gbEjemplares.Name = "gbEjemplares";
            this.gbEjemplares.Size = new System.Drawing.Size(737, 410);
            this.gbEjemplares.TabIndex = 9;
            this.gbEjemplares.TabStop = false;
            this.gbEjemplares.Text = "Ejemplares añadidos";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(702, 343);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // FAltaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 715);
            this.Controls.Add(this.gbEjemplares);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btAñadirEjem);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.tbFecha);
            this.Name = "FAltaPrestamo";
            this.Text = "FAltaPrestamo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FAltaPrestamo_FormClosing);
            this.gbEjemplares.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAñadirEjem;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gbEjemplares;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}