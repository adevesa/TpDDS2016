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
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fecha = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BotonBuscar = new System.Windows.Forms.PictureBox();
            this.BotonHistorial = new System.Windows.Forms.PictureBox();
            this.BotonConfig = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonConfig)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BotonCerrar.BackgroundImage = global::InterfaceGrafica.Properties.Resources._54528;
            this.BotonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BotonCerrar.Location = new System.Drawing.Point(550, 0);
            this.BotonCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(35, 33);
            this.BotonCerrar.TabIndex = 7;
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Visible = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::InterfaceGrafica.Properties.Resources.lineamarron;
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.Usuario);
            this.panel1.Controls.Add(this.Hora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 442);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 27);
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
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BotonBuscar.BackgroundImage = global::InterfaceGrafica.Properties.Resources._09_search_128_7251238b;
            this.BotonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonBuscar.Location = new System.Drawing.Point(242, 42);
            this.BotonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(120, 120);
            this.BotonBuscar.TabIndex = 10;
            this.BotonBuscar.TabStop = false;
            this.toolTip1.SetToolTip(this.BotonBuscar, "Buscar POI");
            this.BotonBuscar.Click += new System.EventHandler(this.pictureBox1_Click);
            this.BotonBuscar.MouseLeave += new System.EventHandler(this.BotonBuscar_MouseLeave);
            this.BotonBuscar.MouseHover += new System.EventHandler(this.BotonBuscar_MouseHover);
            // 
            // BotonHistorial
            // 
            this.BotonHistorial.BackColor = System.Drawing.Color.Transparent;
            this.BotonHistorial.BackgroundImage = global::InterfaceGrafica.Properties.Resources.libro1;
            this.BotonHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonHistorial.Location = new System.Drawing.Point(74, 0);
            this.BotonHistorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonHistorial.Name = "BotonHistorial";
            this.BotonHistorial.Size = new System.Drawing.Size(83, 94);
            this.BotonHistorial.TabIndex = 11;
            this.BotonHistorial.TabStop = false;
            this.toolTip1.SetToolTip(this.BotonHistorial, "Historial de busquedas");
            this.BotonHistorial.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.BotonHistorial.MouseLeave += new System.EventHandler(this.BotonHistorial_MouseLeave);
            this.BotonHistorial.MouseHover += new System.EventHandler(this.BotonHistorial_MouseHover);
            // 
            // BotonConfig
            // 
            this.BotonConfig.BackColor = System.Drawing.Color.Transparent;
            this.BotonConfig.BackgroundImage = global::InterfaceGrafica.Properties.Resources.settings_circle_blue_128;
            this.BotonConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonConfig.Location = new System.Drawing.Point(441, 0);
            this.BotonConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonConfig.Name = "BotonConfig";
            this.BotonConfig.Size = new System.Drawing.Size(83, 94);
            this.BotonConfig.TabIndex = 12;
            this.BotonConfig.TabStop = false;
            this.toolTip1.SetToolTip(this.BotonConfig, "Configuración");
            this.BotonConfig.Click += new System.EventHandler(this.pictureBox3_Click);
            this.BotonConfig.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.BotonConfig.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.BotonBuscar);
            this.panel2.Controls.Add(this.BotonHistorial);
            this.panel2.Controls.Add(this.BotonConfig);
            this.panel2.Controls.Add(this.BotonCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 164);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::InterfaceGrafica.Properties.Resources.cerrar_sesion;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(229, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 33);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceGrafica.Properties.Resources._1440x900_city_skyline_minimalism_30121;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonConfig)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox BotonBuscar;
        private System.Windows.Forms.PictureBox BotonHistorial;
        private System.Windows.Forms.PictureBox BotonConfig;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}