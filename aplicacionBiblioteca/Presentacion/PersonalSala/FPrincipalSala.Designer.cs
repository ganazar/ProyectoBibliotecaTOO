namespace Presentacion.PersonalSala
{
    partial class FPrincipalSala
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentosToolStripMenuItem,
            this.ejemplaresToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 44);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1200, 42);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.MergeIndex = 1;
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(170, 38);
            this.documentosToolStripMenuItem.Text = "Documentos";
            // 
            // ejemplaresToolStripMenuItem
            // 
            this.ejemplaresToolStripMenuItem.MergeIndex = 2;
            this.ejemplaresToolStripMenuItem.Name = "ejemplaresToolStripMenuItem";
            this.ejemplaresToolStripMenuItem.Size = new System.Drawing.Size(149, 38);
            this.ejemplaresToolStripMenuItem.Text = "Ejemplares";
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.MergeIndex = 3;
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(143, 38);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.MergeIndex = 4;
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // FPrincipalSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FPrincipalSala";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FPrincipalSala_Load);
            this.Controls.SetChildIndex(this.menuStrip2, 0);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
    }
}