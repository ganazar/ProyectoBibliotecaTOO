namespace Presentacion.Personal
{
    partial class FBusquedaUsuario
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

        private void InitializeComponent()
        {
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDNI = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(93, 109);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(59, 16);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(93, 68);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(33, 16);
            this.lbDNI.TabIndex = 1;
            this.lbDNI.Text = "DNI:";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(249, 65);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(100, 22);
            this.tbDNI.TabIndex = 2;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(249, 106);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 22);
            this.tbNombre.TabIndex = 3;
            // 
            // FBusquedaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 270);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.lbNombre);
            this.Name = "FBusquedaUsuario";
            this.Text = "Búsqueda de usuario";
            this.Load += new System.EventHandler(this.FBusquedaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbNombre;
    }
}