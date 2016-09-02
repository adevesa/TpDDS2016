namespace InterfaceGrafica
{
    partial class PantallaEditarUsuario
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
            this.IngresarUsuario = new System.Windows.Forms.TextBox();
            this.UsuarioAEditar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NuevaContraseña = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NuevoEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NuevoNombre = new System.Windows.Forms.TextBox();
            this.BotonDesHacer2 = new System.Windows.Forms.Button();
            this.BotonConfirmar2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OpcionSi = new System.Windows.Forms.RadioButton();
            this.OpcionNo = new System.Windows.Forms.RadioButton();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Editar usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IngresarUsuario
            // 
            this.IngresarUsuario.BackColor = System.Drawing.Color.White;
            this.IngresarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarUsuario.Location = new System.Drawing.Point(287, 112);
            this.IngresarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.IngresarUsuario.Name = "IngresarUsuario";
            this.IngresarUsuario.Size = new System.Drawing.Size(245, 41);
            this.IngresarUsuario.TabIndex = 7;
            // 
            // UsuarioAEditar
            // 
            this.UsuarioAEditar.AutoSize = true;
            this.UsuarioAEditar.BackColor = System.Drawing.Color.Transparent;
            this.UsuarioAEditar.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioAEditar.ForeColor = System.Drawing.Color.Black;
            this.UsuarioAEditar.Location = new System.Drawing.Point(26, 112);
            this.UsuarioAEditar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsuarioAEditar.Name = "UsuarioAEditar";
            this.UsuarioAEditar.Size = new System.Drawing.Size(247, 36);
            this.UsuarioAEditar.TabIndex = 11;
            this.UsuarioAEditar.Text = "Usuario a editar:";
            this.UsuarioAEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UsuarioAEditar.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(91, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nueva contraseña:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // NuevaContraseña
            // 
            this.NuevaContraseña.BackColor = System.Drawing.Color.White;
            this.NuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevaContraseña.Location = new System.Drawing.Point(453, 259);
            this.NuevaContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.NuevaContraseña.Name = "NuevaContraseña";
            this.NuevaContraseña.Size = new System.Drawing.Size(183, 34);
            this.NuevaContraseña.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(178, 323);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nuevo Email:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NuevoEmail
            // 
            this.NuevoEmail.BackColor = System.Drawing.Color.White;
            this.NuevoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoEmail.Location = new System.Drawing.Point(453, 327);
            this.NuevoEmail.Margin = new System.Windows.Forms.Padding(4);
            this.NuevoEmail.Name = "NuevoEmail";
            this.NuevoEmail.Size = new System.Drawing.Size(183, 34);
            this.NuevoEmail.TabIndex = 18;
            this.NuevoEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(139, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 36);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nuevo Nombre:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // NuevoNombre
            // 
            this.NuevoNombre.BackColor = System.Drawing.Color.White;
            this.NuevoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoNombre.Location = new System.Drawing.Point(453, 191);
            this.NuevoNombre.Margin = new System.Windows.Forms.Padding(4);
            this.NuevoNombre.Name = "NuevoNombre";
            this.NuevoNombre.Size = new System.Drawing.Size(183, 34);
            this.NuevoNombre.TabIndex = 22;
            // 
            // BotonDesHacer2
            // 
            this.BotonDesHacer2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonDesHacer2.ForeColor = System.Drawing.Color.Black;
            this.BotonDesHacer2.Location = new System.Drawing.Point(443, 482);
            this.BotonDesHacer2.Name = "BotonDesHacer2";
            this.BotonDesHacer2.Size = new System.Drawing.Size(145, 56);
            this.BotonDesHacer2.TabIndex = 23;
            this.BotonDesHacer2.Text = "Deshacer";
            this.BotonDesHacer2.UseVisualStyleBackColor = true;
            // 
            // BotonConfirmar2
            // 
            this.BotonConfirmar2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonConfirmar2.ForeColor = System.Drawing.Color.Black;
            this.BotonConfirmar2.Location = new System.Drawing.Point(205, 482);
            this.BotonConfirmar2.Name = "BotonConfirmar2";
            this.BotonConfirmar2.Size = new System.Drawing.Size(145, 56);
            this.BotonConfirmar2.TabIndex = 24;
            this.BotonConfirmar2.Text = "Confirmar";
            this.BotonConfirmar2.UseVisualStyleBackColor = true;
            this.BotonConfirmar2.Click += new System.EventHandler(this.BotonConfirmar2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(79, 394);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 36);
            this.label3.TabIndex = 25;
            this.label3.Text = "Convertir en admin:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpcionSi
            // 
            this.OpcionSi.AutoSize = true;
            this.OpcionSi.Location = new System.Drawing.Point(491, 409);
            this.OpcionSi.Name = "OpcionSi";
            this.OpcionSi.Size = new System.Drawing.Size(41, 21);
            this.OpcionSi.TabIndex = 26;
            this.OpcionSi.TabStop = true;
            this.OpcionSi.Text = "Si";
            this.OpcionSi.UseVisualStyleBackColor = true;
            // 
            // OpcionNo
            // 
            this.OpcionNo.AutoSize = true;
            this.OpcionNo.Location = new System.Drawing.Point(560, 409);
            this.OpcionNo.Name = "OpcionNo";
            this.OpcionNo.Size = new System.Drawing.Size(47, 21);
            this.OpcionNo.TabIndex = 27;
            this.OpcionNo.TabStop = true;
            this.OpcionNo.Text = "No";
            this.OpcionNo.UseVisualStyleBackColor = true;
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BotonCerrar.BackgroundImage = global::InterfaceGrafica.Properties.Resources._54528;
            this.BotonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrar.Location = new System.Drawing.Point(749, 11);
            this.BotonCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(39, 36);
            this.BotonCerrar.TabIndex = 3;
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBuscar.ForeColor = System.Drawing.Color.Black;
            this.BotonBuscar.Location = new System.Drawing.Point(560, 106);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(145, 56);
            this.BotonBuscar.TabIndex = 28;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            // 
            // PantallaEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.OpcionNo);
            this.Controls.Add(this.OpcionSi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BotonConfirmar2);
            this.Controls.Add(this.BotonDesHacer2);
            this.Controls.Add(this.NuevoNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NuevoEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NuevaContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsuarioAEditar);
            this.Controls.Add(this.IngresarUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonCerrar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PantallaCrearCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.TextBox IngresarUsuario;
        private System.Windows.Forms.Label UsuarioAEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NuevaContraseña;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NuevoEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NuevoNombre;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonDesHacer2;
        private System.Windows.Forms.Button BotonConfirmar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton OpcionSi;
        private System.Windows.Forms.RadioButton OpcionNo;
        private System.Windows.Forms.Button BotonBuscar;
    }
}