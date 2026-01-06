namespace Presentacion
{
    partial class Login
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPersonalAdquisicion = new System.Windows.Forms.RadioButton();
            this.rbPersonalSala = new System.Windows.Forms.RadioButton();
            this.btEntrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(48, 36);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(59, 16);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(48, 84);
            this.labelContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(79, 16);
            this.labelContraseña.TabIndex = 1;
            this.labelContraseña.Text = "Contraseña:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(177, 32);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(132, 22);
            this.tbNombre.TabIndex = 2;
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(177, 80);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(132, 22);
            this.tbContraseña.TabIndex = 3;
            this.tbContraseña.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPersonalAdquisicion);
            this.groupBox1.Controls.Add(this.rbPersonalSala);
            this.groupBox1.Location = new System.Drawing.Point(52, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(259, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo empleado";
            // 
            // rbPersonalAdquisicion
            // 
            this.rbPersonalAdquisicion.AutoSize = true;
            this.rbPersonalAdquisicion.Location = new System.Drawing.Point(24, 68);
            this.rbPersonalAdquisicion.Margin = new System.Windows.Forms.Padding(4);
            this.rbPersonalAdquisicion.Name = "rbPersonalAdquisicion";
            this.rbPersonalAdquisicion.Size = new System.Drawing.Size(169, 20);
            this.rbPersonalAdquisicion.TabIndex = 1;
            this.rbPersonalAdquisicion.TabStop = true;
            this.rbPersonalAdquisicion.Text = "Personal adquisiciones";
            this.rbPersonalAdquisicion.UseVisualStyleBackColor = true;
            // 
            // rbPersonalSala
            // 
            this.rbPersonalSala.AutoSize = true;
            this.rbPersonalSala.Location = new System.Drawing.Point(24, 23);
            this.rbPersonalSala.Margin = new System.Windows.Forms.Padding(4);
            this.rbPersonalSala.Name = "rbPersonalSala";
            this.rbPersonalSala.Size = new System.Drawing.Size(111, 20);
            this.rbPersonalSala.TabIndex = 0;
            this.rbPersonalSala.TabStop = true;
            this.rbPersonalSala.Text = "Personal sala";
            this.rbPersonalSala.UseVisualStyleBackColor = true;
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(211, 284);
            this.btEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(100, 28);
            this.btEntrar.TabIndex = 5;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 348);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelNombre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPersonalSala;
        private System.Windows.Forms.RadioButton rbPersonalAdquisicion;
        private System.Windows.Forms.Button btEntrar;
    }
}