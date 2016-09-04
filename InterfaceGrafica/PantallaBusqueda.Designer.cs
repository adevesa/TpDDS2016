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
            this.BotonBuscar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ListViewPois = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Disponibilidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.Deshacer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 42);
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
            this.BotonCerrar.Location = new System.Drawing.Point(560, 11);
            this.BotonCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(29, 29);
            this.BotonCerrar.TabIndex = 2;
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextoAgregar
            // 
            this.TextoAgregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoAgregar.Location = new System.Drawing.Point(26, 92);
            this.TextoAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextoAgregar.Name = "TextoAgregar";
            this.TextoAgregar.Size = new System.Drawing.Size(261, 37);
            this.TextoAgregar.TabIndex = 3;
            this.TextoAgregar.TextChanged += new System.EventHandler(this.textoAgregar_TextChanged);
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BotonBuscar.BackgroundImage = global::InterfaceGrafica.Properties.Resources.chrome_accept_apply_22369;
            this.BotonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonBuscar.Location = new System.Drawing.Point(458, 83);
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
            // ListViewPois
            // 
            this.ListViewPois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ListViewPois.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Direccion,
            this.Disponibilidad});
            this.ListViewPois.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewPois.Location = new System.Drawing.Point(26, 236);
            this.ListViewPois.Name = "ListViewPois";
            this.ListViewPois.Size = new System.Drawing.Size(544, 240);
            this.ListViewPois.TabIndex = 8;
            this.ListViewPois.UseCompatibleStateImageBehavior = false;
            this.ListViewPois.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Tag = "Nombre";
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 206;
            // 
            // Direccion
            // 
            this.Direccion.Tag = "Direccion";
            this.Direccion.Text = "Dirección";
            this.Direccion.Width = 258;
            // 
            // Disponibilidad
            // 
            this.Disponibilidad.Text = "Disponible";
            this.Disponibilidad.Width = 157;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingrese su búsqueda";
            // 
            // Agregar
            // 
            this.Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Agregar.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.ForeColor = System.Drawing.Color.Black;
            this.Agregar.Location = new System.Drawing.Point(319, 83);
            this.Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(109, 46);
            this.Agregar.TabIndex = 26;
            this.Agregar.Text = "Aceptar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Deshacer
            // 
            this.Deshacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deshacer.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deshacer.ForeColor = System.Drawing.Color.Black;
            this.Deshacer.Location = new System.Drawing.Point(319, 159);
            this.Deshacer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Deshacer.Name = "Deshacer";
            this.Deshacer.Size = new System.Drawing.Size(109, 46);
            this.Deshacer.TabIndex = 27;
            this.Deshacer.Text = "Deshacer";
            this.Deshacer.UseVisualStyleBackColor = true;
            this.Deshacer.Click += new System.EventHandler(this.Deshacer_Click);
            // 
            // PantallaBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.Deshacer);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListViewPois);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.TextoAgregar);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaBusqueda";
            this.Load += new System.EventHandler(this.PantallaBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BotonBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.TextBox TextoAgregar;
        private System.Windows.Forms.PictureBox BotonBuscar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView ListViewPois;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Direccion;
        private System.Windows.Forms.ColumnHeader Disponibilidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Deshacer;
    }
}