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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.textoAgregar = new System.Windows.Forms.TextBox();
            this.BotonAgregar = new System.Windows.Forms.PictureBox();
            this.BotonBuscar = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BotonDeshacer = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BotonAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonDeshacer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar POI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BotonCerrar.BackgroundImage = global::InterfaceGrafica.Properties.Resources._54528;
            this.BotonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrar.Location = new System.Drawing.Point(756, 12);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(32, 36);
            this.BotonCerrar.TabIndex = 2;
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoAgregar
            // 
            this.textoAgregar.BackColor = System.Drawing.Color.Tan;
            this.textoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoAgregar.Location = new System.Drawing.Point(12, 157);
            this.textoAgregar.Name = "textoAgregar";
            this.textoAgregar.Size = new System.Drawing.Size(347, 45);
            this.textoAgregar.TabIndex = 3;
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BotonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAgregar.Location = new System.Drawing.Point(397, 113);
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
            this.BotonBuscar.Location = new System.Drawing.Point(584, 102);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(150, 150);
            this.BotonBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BotonBuscar.TabIndex = 5;
            this.BotonBuscar.TabStop = false;
            this.toolTip1.SetToolTip(this.BotonBuscar, "Confirmar Busqueda");
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
            this.listBox1.Size = new System.Drawing.Size(724, 260);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BotonDeshacer
            // 
            this.BotonDeshacer.BackColor = System.Drawing.Color.Transparent;
            this.BotonDeshacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonDeshacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonDeshacer.Location = new System.Drawing.Point(397, 192);
            this.BotonDeshacer.Name = "BotonDeshacer";
            this.BotonDeshacer.Size = new System.Drawing.Size(125, 60);
            this.BotonDeshacer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonDeshacer.TabIndex = 7;
            this.BotonDeshacer.TabStop = false;
            this.BotonDeshacer.Click += new System.EventHandler(this.BotonDeshacer_Click);
            this.BotonDeshacer.MouseLeave += new System.EventHandler(this.BotonDeshacer_MouseLeave);
            this.BotonDeshacer.MouseHover += new System.EventHandler(this.BotonDeshacer_MouseHover);
            // 
            // PantallaBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceGrafica.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.BotonDeshacer);
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
            this.Load += new System.EventHandler(this.PantallaBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BotonAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonDeshacer)).EndInit();
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
        private System.Windows.Forms.PictureBox BotonDeshacer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}