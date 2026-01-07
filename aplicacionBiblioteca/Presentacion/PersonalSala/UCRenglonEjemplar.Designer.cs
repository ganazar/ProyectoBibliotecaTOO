namespace Presentacion.PersonalSala
{
    partial class UCRenglonEjemplar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbIdEjemplar = new System.Windows.Forms.TextBox();
            this.lblIdEjemp = new System.Windows.Forms.Label();
            this.rbPrestado = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbIdEjemplar
            // 
            this.tbIdEjemplar.Enabled = false;
            this.tbIdEjemplar.Location = new System.Drawing.Point(170, 24);
            this.tbIdEjemplar.Name = "tbIdEjemplar";
            this.tbIdEjemplar.Size = new System.Drawing.Size(330, 31);
            this.tbIdEjemplar.TabIndex = 5;
            // 
            // lblIdEjemp
            // 
            this.lblIdEjemp.AutoSize = true;
            this.lblIdEjemp.Location = new System.Drawing.Point(18, 27);
            this.lblIdEjemp.Name = "lblIdEjemp";
            this.lblIdEjemp.Size = new System.Drawing.Size(128, 25);
            this.lblIdEjemp.TabIndex = 4;
            this.lblIdEjemp.Text = "ID Ejemplar:";
            // 
            // rbPrestado
            // 
            this.rbPrestado.AutoSize = true;
            this.rbPrestado.Checked = true;
            this.rbPrestado.Enabled = false;
            this.rbPrestado.Location = new System.Drawing.Point(536, 23);
            this.rbPrestado.Name = "rbPrestado";
            this.rbPrestado.Size = new System.Drawing.Size(129, 29);
            this.rbPrestado.TabIndex = 3;
            this.rbPrestado.TabStop = true;
            this.rbPrestado.Text = "Prestado";
            this.rbPrestado.UseVisualStyleBackColor = true;
            // 
            // UCRenglonEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbIdEjemplar);
            this.Controls.Add(this.lblIdEjemp);
            this.Controls.Add(this.rbPrestado);
            this.Name = "UCRenglonEjemplar";
            this.Size = new System.Drawing.Size(703, 74);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdEjemplar;
        private System.Windows.Forms.Label lblIdEjemp;
        private System.Windows.Forms.RadioButton rbPrestado;
    }
}
