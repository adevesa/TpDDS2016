namespace InterfaceGrafica
{
    partial class PantallaAdministrarUsuarios
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
            this.BotonVolver = new System.Windows.Forms.Button();
            this.BotonEditarUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrar usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BotonVolver
            // 
            this.BotonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonVolver.Location = new System.Drawing.Point(346, 500);
            this.BotonVolver.Name = "BotonVolver";
            this.BotonVolver.Size = new System.Drawing.Size(177, 62);
            this.BotonVolver.TabIndex = 5;
            this.BotonVolver.Text = "Volver";
            this.BotonVolver.UseVisualStyleBackColor = true;
            this.BotonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // BotonEditarUsuario
            // 
            this.BotonEditarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonEditarUsuario.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEditarUsuario.Location = new System.Drawing.Point(235, 129);
            this.BotonEditarUsuario.Name = "BotonEditarUsuario";
            this.BotonEditarUsuario.Size = new System.Drawing.Size(384, 137);
            this.BotonEditarUsuario.TabIndex = 7;
            this.BotonEditarUsuario.Text = "Editar Usuario";
            this.BotonEditarUsuario.UseVisualStyleBackColor = true;
            this.BotonEditarUsuario.Click += new System.EventHandler(this.BotonEditarUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BotonVolver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BotonEditarUsuario);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 598);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 137);
            this.button1.TabIndex = 9;
            this.button1.Text = "Crear Administrador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BotonCerrar.BackgroundImage = global::InterfaceGrafica.Properties.Resources._54528;
            this.BotonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrar.Location = new System.Drawing.Point(756, 12);
            this.BotonCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(32, 36);
            this.BotonCerrar.TabIndex = 3;
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // PantallaAdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BotonCerrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaAdministrarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaDeConfig_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonVolver;
        private System.Windows.Forms.Button BotonEditarUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}