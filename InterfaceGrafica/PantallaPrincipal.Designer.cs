namespace InterfaceGrafica
{
    partial class PantallaPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fecha = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HistorialDeBusquedas = new System.Windows.Forms.Button();
            this.BuscarPOIs = new System.Windows.Forms.Button();
            this.AdministrarPois = new System.Windows.Forms.Button();
            this.BotonAdministrarUsuarios = new System.Windows.Forms.Button();
            this.CerrarSecion = new System.Windows.Forms.PictureBox();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarSecion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.Usuario);
            this.panel1.Controls.Add(this.Hora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 574);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 27);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.BackColor = System.Drawing.Color.Transparent;
            this.Fecha.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(495, 0);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(70, 23);
            this.Fecha.TabIndex = 2;
            this.Fecha.Text = "Fecha";
            this.Fecha.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Usuario.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(247, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(94, 23);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "Usuario";
            this.Usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.BackColor = System.Drawing.Color.Transparent;
            this.Hora.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(13, 0);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(58, 23);
            this.Hora.TabIndex = 0;
            this.Hora.Text = "Hora";
            this.Hora.Click += new System.EventHandler(this.Hora_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 0);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.HistorialDeBusquedas);
            this.panel3.Controls.Add(this.BuscarPOIs);
            this.panel3.Controls.Add(this.AdministrarPois);
            this.panel3.Controls.Add(this.BotonAdministrarUsuarios);
            this.panel3.Controls.Add(this.CerrarSecion);
            this.panel3.Location = new System.Drawing.Point(79, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 559);
            this.panel3.TabIndex = 15;
            // 
            // HistorialDeBusquedas
            // 
            this.HistorialDeBusquedas.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistorialDeBusquedas.Location = new System.Drawing.Point(100, 355);
            this.HistorialDeBusquedas.Name = "HistorialDeBusquedas";
            this.HistorialDeBusquedas.Size = new System.Drawing.Size(453, 90);
            this.HistorialDeBusquedas.TabIndex = 19;
            this.HistorialDeBusquedas.Text = "Historial De Busquedas";
            this.HistorialDeBusquedas.UseVisualStyleBackColor = true;
            this.HistorialDeBusquedas.Click += new System.EventHandler(this.HistorialDeBusquedas_Click);
            // 
            // BuscarPOIs
            // 
            this.BuscarPOIs.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarPOIs.Location = new System.Drawing.Point(100, 243);
            this.BuscarPOIs.Name = "BuscarPOIs";
            this.BuscarPOIs.Size = new System.Drawing.Size(453, 90);
            this.BuscarPOIs.TabIndex = 18;
            this.BuscarPOIs.Text = "Buscar POIs";
            this.BuscarPOIs.UseVisualStyleBackColor = true;
            this.BuscarPOIs.Click += new System.EventHandler(this.BuscarPOIs_Click);
            // 
            // AdministrarPois
            // 
            this.AdministrarPois.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdministrarPois.Location = new System.Drawing.Point(100, 124);
            this.AdministrarPois.Name = "AdministrarPois";
            this.AdministrarPois.Size = new System.Drawing.Size(453, 90);
            this.AdministrarPois.TabIndex = 17;
            this.AdministrarPois.Text = "Administrar POIs";
            this.AdministrarPois.UseVisualStyleBackColor = true;
            this.AdministrarPois.Click += new System.EventHandler(this.AdministrarPois_Click);
            // 
            // BotonAdministrarUsuarios
            // 
            this.BotonAdministrarUsuarios.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAdministrarUsuarios.Location = new System.Drawing.Point(100, 16);
            this.BotonAdministrarUsuarios.Name = "BotonAdministrarUsuarios";
            this.BotonAdministrarUsuarios.Size = new System.Drawing.Size(453, 90);
            this.BotonAdministrarUsuarios.TabIndex = 16;
            this.BotonAdministrarUsuarios.Text = "Administrar Usuarios";
            this.BotonAdministrarUsuarios.UseVisualStyleBackColor = true;
            this.BotonAdministrarUsuarios.Click += new System.EventHandler(this.BotonConfig_Click);
            // 
            // CerrarSecion
            // 
            this.CerrarSecion.BackColor = System.Drawing.Color.Transparent;
            this.CerrarSecion.BackgroundImage = global::InterfaceGrafica.Properties.Resources.cerrar_sesion;
            this.CerrarSecion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CerrarSecion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarSecion.Location = new System.Drawing.Point(269, 505);
            this.CerrarSecion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CerrarSecion.Name = "CerrarSecion";
            this.CerrarSecion.Size = new System.Drawing.Size(132, 33);
            this.CerrarSecion.TabIndex = 14;
            this.CerrarSecion.TabStop = false;
            this.CerrarSecion.Click += new System.EventHandler(this.CerrarSecion_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BotonCerrar.BackgroundImage = global::InterfaceGrafica.Properties.Resources._54528;
            this.BotonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BotonCerrar.Location = new System.Drawing.Point(753, 11);
            this.BotonCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(35, 33);
            this.BotonCerrar.TabIndex = 7;
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarSecion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox CerrarSecion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BotonAdministrarUsuarios;
        private System.Windows.Forms.Button AdministrarPois;
        private System.Windows.Forms.Button BuscarPOIs;
        private System.Windows.Forms.Button HistorialDeBusquedas;
    }
}