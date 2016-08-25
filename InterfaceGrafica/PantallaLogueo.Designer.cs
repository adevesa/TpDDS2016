namespace InterfaceGrafica
{
    partial class PantallaLogueo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaLogueo));
            this.NombreDeUsuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.IngresarUsuario = new System.Windows.Forms.TextBox();
            this.IngresarContraseña = new System.Windows.Forms.TextBox();
            this.BotonComenzar = new System.Windows.Forms.PictureBox();
            this.BotonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BotonComenzar)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreDeUsuario
            // 
            resources.ApplyResources(this.NombreDeUsuario, "NombreDeUsuario");
            this.NombreDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.NombreDeUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.NombreDeUsuario.ForeColor = System.Drawing.Color.BurlyWood;
            this.NombreDeUsuario.Name = "NombreDeUsuario";
            this.NombreDeUsuario.Click += new System.EventHandler(this.NombreDeUsuario_Click);
            // 
            // Contraseña
            // 
            this.Contraseña.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Contraseña, "Contraseña");
            this.Contraseña.ForeColor = System.Drawing.Color.BurlyWood;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Click += new System.EventHandler(this.Contraseña_Click);
            // 
            // IngresarUsuario
            // 
            resources.ApplyResources(this.IngresarUsuario, "IngresarUsuario");
            this.IngresarUsuario.Name = "IngresarUsuario";
            this.IngresarUsuario.TextChanged += new System.EventHandler(this.IngresoNameUsser_TextChanged);
            // 
            // IngresarContraseña
            // 
            resources.ApplyResources(this.IngresarContraseña, "IngresarContraseña");
            this.IngresarContraseña.Name = "IngresarContraseña";
            this.IngresarContraseña.UseSystemPasswordChar = true;
            this.IngresarContraseña.TextChanged += new System.EventHandler(this.ContenedorContraseña_TextChanged);
            // 
            // BotonComenzar
            // 
            this.BotonComenzar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BotonComenzar, "BotonComenzar");
            this.BotonComenzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonComenzar.Name = "BotonComenzar";
            this.BotonComenzar.TabStop = false;
            this.BotonComenzar.Click += new System.EventHandler(this.pictureBox1_Click);
            this.BotonComenzar.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.BotonComenzar.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BotonCerrar.BackgroundImage = global::InterfaceGrafica.Properties.Resources._54528;
            resources.ApplyResources(this.BotonCerrar, "BotonCerrar");
            this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PantallaLogueo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::InterfaceGrafica.Properties.Resources._1440x900_city_skyline_minimalism_30121;
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.BotonComenzar);
            this.Controls.Add(this.IngresarContraseña);
            this.Controls.Add(this.IngresarUsuario);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.NombreDeUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaLogueo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaLogueo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BotonComenzar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreDeUsuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox IngresarUsuario;
        private System.Windows.Forms.TextBox IngresarContraseña;
        private System.Windows.Forms.PictureBox BotonComenzar;
        private System.Windows.Forms.Button BotonCerrar;
    }
}