namespace InterfaceGrafica
{
    partial class PantallaBusqueda
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
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.textoAgregar = new System.Windows.Forms.TextBox();
            this.BotonAgregar = new System.Windows.Forms.PictureBox();
            this.BotonBuscar = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BotonCerrar.BackgroundImage = global::InterfaceGrafica.Properties.Resources._54528;
            this.BotonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrar.Location = new System.Drawing.Point(563, 2);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(32, 36);
            this.BotonCerrar.TabIndex = 2;
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoAgregar
            // 
            this.textoAgregar.BackColor = System.Drawing.Color.Tan;
            this.textoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoAgregar.Location = new System.Drawing.Point(21, 102);
            this.textoAgregar.Name = "textoAgregar";
            this.textoAgregar.Size = new System.Drawing.Size(240, 38);
            this.textoAgregar.TabIndex = 3;
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BotonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonAgregar.Image = global::InterfaceGrafica.Properties.Resources.agregar1;
            this.BotonAgregar.Location = new System.Drawing.Point(277, 90);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(125, 60);
            this.BotonAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonAgregar.TabIndex = 4;
            this.BotonAgregar.TabStop = false;
            this.BotonAgregar.Click += new System.EventHandler(this.pictureBox1_Click);
            this.BotonAgregar.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.BotonAgregar.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BotonBuscar.BackgroundImage = global::InterfaceGrafica.Properties.Resources.chrome_accept_apply_22369;
            this.BotonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonBuscar.Location = new System.Drawing.Point(490, 176);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(79, 89);
            this.BotonBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BotonBuscar.TabIndex = 5;
            this.BotonBuscar.TabStop = false;
            this.BotonBuscar.Click += new System.EventHandler(this.pictureBox2_Click_1);
            this.BotonBuscar.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.BotonBuscar.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(35, 294);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(534, 180);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PantallaBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceGrafica.Properties.Resources._787538_dark_blue_digital_art_gray_minimalistic_orange_pastel_pastels_red_simple_simple_background_simplistic_squares_tapeta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.textoAgregar);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PantallaBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaBusqueda";
            ((System.ComponentModel.ISupportInitialize)(this.BotonAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.TextBox textoAgregar;
        private System.Windows.Forms.PictureBox BotonAgregar;
        private System.Windows.Forms.PictureBox BotonBuscar;
        private System.Windows.Forms.ListBox listBox1;
    }
}