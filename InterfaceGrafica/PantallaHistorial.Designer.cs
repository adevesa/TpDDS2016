namespace InterfaceGrafica
{
    partial class PantallaHistorial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Desde = new System.Windows.Forms.TextBox();
            this.Hasta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BotonAplicar = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BotonAplicar)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Historial de Busquedas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Por usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(507, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Por fecha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Usuario
            // 
            this.Usuario.BackColor = System.Drawing.Color.White;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(33, 155);
            this.Usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(183, 34);
            this.Usuario.TabIndex = 7;
            // 
            // Desde
            // 
            this.Desde.BackColor = System.Drawing.Color.White;
            this.Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desde.Location = new System.Drawing.Point(651, 140);
            this.Desde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(81, 34);
            this.Desde.TabIndex = 8;
            // 
            // Hasta
            // 
            this.Hasta.BackColor = System.Drawing.Color.White;
            this.Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hasta.Location = new System.Drawing.Point(651, 208);
            this.Hasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(81, 34);
            this.Hasta.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(508, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Desde";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(508, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hasta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotonAplicar
            // 
            this.BotonAplicar.BackColor = System.Drawing.Color.Transparent;
            this.BotonAplicar.BackgroundImage = global::InterfaceGrafica.Properties.Resources.chrome_accept_apply_22369;
            this.BotonAplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAplicar.Location = new System.Drawing.Point(281, 96);
            this.BotonAplicar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonAplicar.Name = "BotonAplicar";
            this.BotonAplicar.Size = new System.Drawing.Size(149, 150);
            this.BotonAplicar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BotonAplicar.TabIndex = 12;
            this.BotonAplicar.TabStop = false;
            this.toolTip1.SetToolTip(this.BotonAplicar, "Confirmar parametros");
            this.BotonAplicar.Click += new System.EventHandler(this.pictureBox1_MouseHover);
            this.BotonAplicar.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.BotonAplicar.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(31, 313);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(721, 244);
            this.listBox1.TabIndex = 13;
            // 
            // PantallaHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BotonAplicar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Hasta);
            this.Controls.Add(this.Desde);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonCerrar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BotonAplicar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Desde;
        private System.Windows.Forms.TextBox Hasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox BotonAplicar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}