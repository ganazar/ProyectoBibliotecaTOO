namespace Presentacion.Personal
{
    partial class FListado
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbDNI = new System.Windows.Forms.ListBox();
            this.lbNombre = new System.Windows.Forms.ListBox();
            this.btDNi = new System.Windows.Forms.Button();
            this.btnombre = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbDNI
            // 
            this.lbDNI.FormattingEnabled = true;
            this.lbDNI.ItemHeight = 16;
            this.lbDNI.Location = new System.Drawing.Point(151, 115);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(120, 212);
            this.lbDNI.TabIndex = 3;
            this.lbDNI.SelectedIndexChanged += new System.EventHandler(this.lbDNI_SelectedIndexChanged);
            // 
            // lbNombre
            // 
            this.lbNombre.FormattingEnabled = true;
            this.lbNombre.ItemHeight = 16;
            this.lbNombre.Location = new System.Drawing.Point(454, 115);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(120, 212);
            this.lbNombre.TabIndex = 4;
            // 
            // btDNi
            // 
            this.btDNi.Location = new System.Drawing.Point(151, 60);
            this.btDNi.Name = "btDNi";
            this.btDNi.Size = new System.Drawing.Size(120, 23);
            this.btDNi.TabIndex = 1;
            this.btDNi.Text = "DNI";
            this.btDNi.UseVisualStyleBackColor = true;
            // 
            // btnombre
            // 
            this.btnombre.Location = new System.Drawing.Point(454, 60);
            this.btnombre.Name = "btnombre";
            this.btnombre.Size = new System.Drawing.Size(120, 23);
            this.btnombre.TabIndex = 3;
            this.btnombre.Text = "Nombre";
            this.btnombre.UseVisualStyleBackColor = true;
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(334, 369);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 5;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            // 
            // FListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btnombre);
            this.Controls.Add(this.btDNi);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbDNI);
            this.Name = "FListado";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox lbDNI;
        private System.Windows.Forms.ListBox lbNombre;
        private System.Windows.Forms.Button btDNi;
        private System.Windows.Forms.Button btnombre;
        private System.Windows.Forms.Button btCerrar;
    }
}