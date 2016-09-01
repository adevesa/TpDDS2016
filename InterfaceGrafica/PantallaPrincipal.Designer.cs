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
            this.BotonBuscar = new System.Windows.Forms.PictureBox();
            this.BotonHistorial = new System.Windows.Forms.PictureBox();
            this.BotonConfig = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CerrarSecion = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarSecion)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BotonCerrar.BackgroundImage = global::InterfaceGrafica.Properties.Resources._54528;
            this.BotonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BotonCerrar.Location = new System.Drawing.Point(565, 9);
            this.BotonCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(26, 27);
            this.BotonCerrar.TabIndex = 7;
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.Usuario);
            this.panel1.Controls.Add(this.Hora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 466);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 22);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.BackColor = System.Drawing.Color.Transparent;
            this.Fecha.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(371, 0);
            this.Fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(58, 17);
            this.Fecha.TabIndex = 2;
            this.Fecha.Text = "Fecha";
            this.Fecha.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Usuario.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(185, 0);
            this.Usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(78, 17);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "Usuario";
            this.Usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.BackColor = System.Drawing.Color.Transparent;
            this.Hora.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(10, 0);
            this.Hora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(48, 17);
            this.Hora.TabIndex = 0;
            this.Hora.Text = "Hora";
            this.Hora.Click += new System.EventHandler(this.Hora_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BotonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonBuscar.Location = new System.Drawing.Point(108, 137);
            this.BotonBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(300, 102);
            this.BotonBuscar.TabIndex = 10;
            this.BotonBuscar.TabStop = false;
            this.BotonBuscar.Click += new System.EventHandler(this.pictureBox1_Click);
            this.BotonBuscar.MouseLeave += new System.EventHandler(this.BotonBuscar_MouseLeave);
            this.BotonBuscar.MouseHover += new System.EventHandler(this.BotonBuscar_MouseHover);
            // 
            // BotonHistorial
            // 
            this.BotonHistorial.BackColor = System.Drawing.Color.Transparent;
            this.BotonHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonHistorial.Location = new System.Drawing.Point(108, 258);
            this.BotonHistorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonHistorial.Name = "BotonHistorial";
            this.BotonHistorial.Size = new System.Drawing.Size(300, 98);
            this.BotonHistorial.TabIndex = 11;
            this.BotonHistorial.TabStop = false;
            this.BotonHistorial.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.BotonHistorial.MouseLeave += new System.EventHandler(this.BotonHistorial_MouseLeave);
            this.BotonHistorial.MouseHover += new System.EventHandler(this.BotonHistorial_MouseHover);
            // 
            // BotonConfig
            // 
            this.BotonConfig.BackColor = System.Drawing.Color.Transparent;
            this.BotonConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonConfig.Location = new System.Drawing.Point(108, 18);
            this.BotonConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonConfig.Name = "BotonConfig";
            this.BotonConfig.Size = new System.Drawing.Size(300, 102);
            this.BotonConfig.TabIndex = 12;
            this.BotonConfig.TabStop = false;
            this.BotonConfig.Click += new System.EventHandler(this.pictureBox3_Click);
            this.BotonConfig.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.BotonConfig.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 0);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // CerrarSecion
            // 
            this.CerrarSecion.BackColor = System.Drawing.Color.Transparent;
            this.CerrarSecion.BackgroundImage = global::InterfaceGrafica.Properties.Resources.cerrar_sesion;
            this.CerrarSecion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CerrarSecion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CerrarSecion.Location = new System.Drawing.Point(202, 410);
            this.CerrarSecion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CerrarSecion.Name = "CerrarSecion";
            this.CerrarSecion.Size = new System.Drawing.Size(99, 27);
            this.CerrarSecion.TabIndex = 14;
            this.CerrarSecion.TabStop = false;
            this.CerrarSecion.Click += new System.EventHandler(this.CerrarSecion_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.BotonHistorial);
            this.panel3.Controls.Add(this.BotonBuscar);
            this.panel3.Controls.Add(this.CerrarSecion);
            this.panel3.Controls.Add(this.BotonConfig);
            this.panel3.Location = new System.Drawing.Point(59, 9);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 454);
            this.panel3.TabIndex = 15;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarSecion)).EndInit();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox BotonBuscar;
        private System.Windows.Forms.PictureBox BotonHistorial;
        private System.Windows.Forms.PictureBox BotonConfig;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox CerrarSecion;
        private System.Windows.Forms.Panel panel3;
    }
}