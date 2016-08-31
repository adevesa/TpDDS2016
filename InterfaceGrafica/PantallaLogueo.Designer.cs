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
            this.BotonComenzar = new System.Windows.Forms.PictureBox();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotonRegistrarse = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BotonComenzar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonRegistrarse)).BeginInit();
            this.SuspendLayout();
            // 
            // IngresarUsuario
            // 
            this.IngresarUsuario.BackColor = System.Drawing.Color.PeachPuff;
            resources.ApplyResources(this.IngresarUsuario, "IngresarUsuario");
            this.IngresarUsuario.Name = "IngresarUsuario";
            this.IngresarUsuario.TextChanged += new System.EventHandler(this.IngresoNameUsser_TextChanged);
            // 
            // IngresarContraseña
            // 
            this.IngresarContraseña.BackColor = System.Drawing.Color.PeachPuff;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BotonRegistrarse);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IngresarContraseña);
            this.panel1.Controls.Add(this.IngresarUsuario);
            this.panel1.Controls.Add(this.BotonComenzar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // BotonRegistrarse
            // 
            this.BotonRegistrarse.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BotonRegistrarse, "BotonRegistrarse");
            this.BotonRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonRegistrarse.Name = "BotonRegistrarse";
            this.BotonRegistrarse.TabStop = false;
            this.BotonRegistrarse.Click += new System.EventHandler(this.BotonRegistrarse_Click_1);
            this.BotonRegistrarse.MouseLeave += new System.EventHandler(this.BotonRegistrarse_MouseLeave);
            this.BotonRegistrarse.MouseHover += new System.EventHandler(this.BotonRegistrarse_MouseHover_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Name = "label1";
            // 
            // PantallaLogueo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::InterfaceGrafica.Properties.Resources.orig_63734;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BotonCerrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaLogueo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaLogueo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BotonComenzar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonRegistrarse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox IngresarUsuario;
        private System.Windows.Forms.TextBox IngresarContraseña;
        private System.Windows.Forms.PictureBox BotonComenzar;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BotonRegistrarse;
    }
}