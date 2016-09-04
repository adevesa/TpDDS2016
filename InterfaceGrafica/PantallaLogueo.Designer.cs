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
            this.IngresarUsuario = new System.Windows.Forms.TextBox();
            this.IngresarContraseña = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CrearCuenta = new System.Windows.Forms.Button();
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IngresarUsuario
            // 
            this.IngresarUsuario.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.IngresarUsuario, "IngresarUsuario");
            this.IngresarUsuario.Name = "IngresarUsuario";
            this.IngresarUsuario.TextChanged += new System.EventHandler(this.IngresoNameUsser_TextChanged);
            // 
            // IngresarContraseña
            // 
            this.IngresarContraseña.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.IngresarContraseña, "IngresarContraseña");
            this.IngresarContraseña.Name = "IngresarContraseña";
            this.IngresarContraseña.UseSystemPasswordChar = true;
            this.IngresarContraseña.TextChanged += new System.EventHandler(this.ContenedorContraseña_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.CrearCuenta);
            this.panel1.Controls.Add(this.IniciarSesion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IngresarContraseña);
            this.panel1.Controls.Add(this.IngresarUsuario);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // CrearCuenta
            // 
            resources.ApplyResources(this.CrearCuenta, "CrearCuenta");
            this.CrearCuenta.Name = "CrearCuenta";
            this.CrearCuenta.UseVisualStyleBackColor = true;
            this.CrearCuenta.Click += new System.EventHandler(this.CrearCuenta_Click);
            // 
            // IniciarSesion
            // 
            resources.ApplyResources(this.IniciarSesion, "IniciarSesion");
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.UseVisualStyleBackColor = true;
            this.IniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(222)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BotonCerrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaLogueo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaLogueo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox IngresarUsuario;
        private System.Windows.Forms.TextBox IngresarContraseña;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button IniciarSesion;
        private System.Windows.Forms.Button CrearCuenta;
    }
}