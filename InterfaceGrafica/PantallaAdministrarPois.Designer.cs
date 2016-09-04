namespace InterfaceGrafica
{
    partial class PantallaAdministrarPois
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BotonVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CrearPOI = new System.Windows.Forms.Button();
            this.BotonEditarPOI = new System.Windows.Forms.Button();
            this.BotonElimiarPOI = new System.Windows.Forms.Button();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrar POIs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BotonVolver
            // 
            this.BotonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonVolver.Location = new System.Drawing.Point(250, 409);
            this.BotonVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonVolver.Name = "BotonVolver";
            this.BotonVolver.Size = new System.Drawing.Size(133, 50);
            this.BotonVolver.TabIndex = 5;
            this.BotonVolver.Text = "Volver";
            this.BotonVolver.UseVisualStyleBackColor = true;
            this.BotonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.CrearPOI);
            this.panel1.Controls.Add(this.BotonEditarPOI);
            this.panel1.Controls.Add(this.BotonElimiarPOI);
            this.panel1.Controls.Add(this.BotonVolver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 486);
            this.panel1.TabIndex = 8;
            // 
            // CrearPOI
            // 
            this.CrearPOI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrearPOI.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearPOI.Location = new System.Drawing.Point(178, 85);
            this.CrearPOI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CrearPOI.Name = "CrearPOI";
            this.CrearPOI.Size = new System.Drawing.Size(273, 88);
            this.CrearPOI.TabIndex = 10;
            this.CrearPOI.Text = "Crear POI";
            this.CrearPOI.UseVisualStyleBackColor = true;
            this.CrearPOI.Click += new System.EventHandler(this.CrearPOI_Click);
            // 
            // BotonEditarPOI
            // 
            this.BotonEditarPOI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonEditarPOI.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEditarPOI.Location = new System.Drawing.Point(178, 288);
            this.BotonEditarPOI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonEditarPOI.Name = "BotonEditarPOI";
            this.BotonEditarPOI.Size = new System.Drawing.Size(273, 88);
            this.BotonEditarPOI.TabIndex = 9;
            this.BotonEditarPOI.Text = "Editar POI";
            this.BotonEditarPOI.UseVisualStyleBackColor = true;
            this.BotonEditarPOI.Click += new System.EventHandler(this.BotonEditarPOI_Click);
            // 
            // BotonElimiarPOI
            // 
            this.BotonElimiarPOI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonElimiarPOI.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonElimiarPOI.Location = new System.Drawing.Point(178, 187);
            this.BotonElimiarPOI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonElimiarPOI.Name = "BotonElimiarPOI";
            this.BotonElimiarPOI.Size = new System.Drawing.Size(273, 88);
            this.BotonElimiarPOI.TabIndex = 8;
            this.BotonElimiarPOI.Text = "Eliminar POI";
            this.BotonElimiarPOI.UseVisualStyleBackColor = true;
            this.BotonElimiarPOI.Click += new System.EventHandler(this.BotonElimiarPOI_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BotonCerrar.BackgroundImage = global::InterfaceGrafica.Properties.Resources._54528;
            this.BotonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrar.Location = new System.Drawing.Point(555, 10);
            this.BotonCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(34, 29);
            this.BotonCerrar.TabIndex = 3;
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // PantallaAdministrarPois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BotonCerrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PantallaAdministrarPois";
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonEditarPOI;
        private System.Windows.Forms.Button BotonElimiarPOI;
        private System.Windows.Forms.Button CrearPOI;
    }
}