namespace Presentacion.Personal
{
    partial class FBusquedaDni
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
            this.lbDni = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.cbDni = new System.Windows.Forms.ComboBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(130, 75);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(33, 16);
            this.lbDni.TabIndex = 0;
            this.lbDni.Text = "DNI:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(130, 124);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(59, 16);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // cbDni
            // 
            this.cbDni.FormattingEnabled = true;
            this.cbDni.Location = new System.Drawing.Point(231, 72);
            this.cbDni.Name = "cbDni";
            this.cbDni.Size = new System.Drawing.Size(212, 24);
            this.cbDni.TabIndex = 2;
            this.cbDni.SelectedIndexChanged += new System.EventHandler(this.cbDni_SelectedIndexChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(231, 124);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(212, 22);
            this.tbNombre.TabIndex = 3;
            // 
            // FBusquedaDni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 243);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.cbDni);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbDni);
            this.Name = "FBusquedaDni";
            this.Text = "Búsqueda por DNI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.ComboBox cbDni;
        private System.Windows.Forms.TextBox tbNombre;
    }
}