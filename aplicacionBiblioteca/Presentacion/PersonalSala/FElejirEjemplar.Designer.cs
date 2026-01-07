namespace Presentacion.PersonalSala
{
    partial class FElejirEjemplar
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
            this.cbEjemplares = new System.Windows.Forms.ComboBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.brCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejemplares disponibles:";
            // 
            // cbEjemplares
            // 
            this.cbEjemplares.FormattingEnabled = true;
            this.cbEjemplares.Location = new System.Drawing.Point(426, 80);
            this.cbEjemplares.Name = "cbEjemplares";
            this.cbEjemplares.Size = new System.Drawing.Size(464, 33);
            this.cbEjemplares.TabIndex = 1;
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(256, 193);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(178, 40);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // brCancelar
            // 
            this.brCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.brCancelar.Location = new System.Drawing.Point(506, 193);
            this.brCancelar.Name = "brCancelar";
            this.brCancelar.Size = new System.Drawing.Size(178, 40);
            this.brCancelar.TabIndex = 3;
            this.brCancelar.Text = "Cancelar";
            this.brCancelar.UseVisualStyleBackColor = true;
            // 
            // FElejirEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 306);
            this.Controls.Add(this.brCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.cbEjemplares);
            this.Controls.Add(this.label1);
            this.Name = "FElejirEjemplar";
            this.Text = "FElejirEjemplar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FElejirEjemplar_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEjemplares;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button brCancelar;
    }
}