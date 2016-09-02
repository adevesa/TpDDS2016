namespace InterfaceGrafica
{
    partial class PantallaDeConfig
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.BotonAplicar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BotonAplicar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configuración";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BotonCerrar.BackgroundImage = global::InterfaceGrafica.Properties.Resources._54528;
            this.BotonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrar.Location = new System.Drawing.Point(567, 10);
            this.BotonCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(24, 29);
            this.BotonCerrar.TabIndex = 3;
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(25, 149);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(296, 304);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // BotonAplicar
            // 
            this.BotonAplicar.BackColor = System.Drawing.Color.Transparent;
            this.BotonAplicar.BackgroundImage = global::InterfaceGrafica.Properties.Resources.chrome_accept_apply_22369;
            this.BotonAplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAplicar.Location = new System.Drawing.Point(413, 238);
            this.BotonAplicar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonAplicar.Name = "BotonAplicar";
            this.BotonAplicar.Size = new System.Drawing.Size(112, 122);
            this.BotonAplicar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BotonAplicar.TabIndex = 6;
            this.BotonAplicar.TabStop = false;
            this.toolTip1.SetToolTip(this.BotonAplicar, "Aplicar");
            this.BotonAplicar.Click += new System.EventHandler(this.BotonAplicar_Click);
            this.BotonAplicar.MouseLeave += new System.EventHandler(this.BotonAplicar_MouseLeave);
            this.BotonAplicar.MouseHover += new System.EventHandler(this.BotonBuscar_MouseHover);
            // 
            // PantallaDeConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.BotonAplicar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaDeConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PantallaDeConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BotonAplicar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox BotonAplicar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}