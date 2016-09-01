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
            this.TextoAgregar = new System.Windows.Forms.TextBox();
            this.BotonAgregar = new System.Windows.Forms.PictureBox();
            this.BotonBuscar = new System.Windows.Forms.PictureBox();
            this.BotonDeshacer = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ListViewPois = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Disponibilidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 66);
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
            this.BotonCerrar.Location = new System.Drawing.Point(567, 10);
            this.BotonCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(24, 29);
            this.BotonCerrar.TabIndex = 2;
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextoAgregar
            // 
            this.TextoAgregar.BackColor = System.Drawing.Color.Tan;
            this.TextoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoAgregar.Location = new System.Drawing.Point(26, 104);
            this.TextoAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextoAgregar.Name = "TextoAgregar";
            this.TextoAgregar.Size = new System.Drawing.Size(261, 37);
            this.TextoAgregar.TabIndex = 3;
            this.TextoAgregar.TextChanged += new System.EventHandler(this.textoAgregar_TextChanged);
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BotonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAgregar.Location = new System.Drawing.Point(298, 92);
            this.BotonAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(94, 49);
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
            this.BotonBuscar.Location = new System.Drawing.Point(438, 83);
            this.BotonBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(112, 122);
            this.BotonBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BotonBuscar.TabIndex = 5;
            this.BotonBuscar.TabStop = false;
            this.toolTip1.SetToolTip(this.BotonBuscar, "Confirmar Busqueda");
            this.BotonBuscar.Click += new System.EventHandler(this.pictureBox2_Click_1);
            this.BotonBuscar.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.BotonBuscar.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // BotonDeshacer
            // 
            this.BotonDeshacer.BackColor = System.Drawing.Color.Transparent;
            this.BotonDeshacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonDeshacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonDeshacer.Location = new System.Drawing.Point(298, 156);
            this.BotonDeshacer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonDeshacer.Name = "BotonDeshacer";
            this.BotonDeshacer.Size = new System.Drawing.Size(94, 49);
            this.BotonDeshacer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonDeshacer.TabIndex = 7;
            this.BotonDeshacer.TabStop = false;
            this.BotonDeshacer.Click += new System.EventHandler(this.BotonDeshacer_Click);
            this.BotonDeshacer.MouseLeave += new System.EventHandler(this.BotonDeshacer_MouseLeave);
            this.BotonDeshacer.MouseHover += new System.EventHandler(this.BotonDeshacer_MouseHover);
            // 
            // ListViewPois
            // 
            this.ListViewPois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ListViewPois.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Direccion,
            this.Disponibilidad});
            this.ListViewPois.Location = new System.Drawing.Point(21, 224);
            this.ListViewPois.Name = "ListViewPois";
            this.ListViewPois.Size = new System.Drawing.Size(547, 166);
            this.ListViewPois.TabIndex = 8;
            this.ListViewPois.UseCompatibleStateImageBehavior = false;
            this.ListViewPois.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Tag = "Nombre";
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 194;
            // 
            // Direccion
            // 
            this.Direccion.Tag = "Direccion";
            this.Direccion.Text = "Dirección";
            this.Direccion.Width = 189;
            // 
            // Disponibilidad
            // 
            this.Disponibilidad.Text = "Disponible";
            this.Disponibilidad.Width = 157;
            // 
            // PantallaBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceGrafica.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.ListViewPois);
            this.Controls.Add(this.BotonDeshacer);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.TextoAgregar);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.TextBox TextoAgregar;
        private System.Windows.Forms.PictureBox BotonAgregar;
        private System.Windows.Forms.PictureBox BotonBuscar;
        private System.Windows.Forms.PictureBox BotonDeshacer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView ListViewPois;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Direccion;
        private System.Windows.Forms.ColumnHeader Disponibilidad;
    }
}