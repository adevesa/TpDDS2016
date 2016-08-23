namespace InterfaceGrafica
{
    partial class PantallaLogueo
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
            this.NombreDeUsuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.IngresoNameUsser = new System.Windows.Forms.TextBox();
            this.ContenedorContraseña = new System.Windows.Forms.TextBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreDeUsuario
            // 
            this.NombreDeUsuario.AutoSize = true;
            this.NombreDeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NombreDeUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.NombreDeUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreDeUsuario.Location = new System.Drawing.Point(103, 98);
            this.NombreDeUsuario.Name = "NombreDeUsuario";
            this.NombreDeUsuario.Size = new System.Drawing.Size(137, 20);
            this.NombreDeUsuario.TabIndex = 0;
            this.NombreDeUsuario.Text = "Nombre de usuario";
            // 
            // Contraseña
            // 
            this.Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Contraseña.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(104, 161);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Contraseña.Size = new System.Drawing.Size(136, 24);
            this.Contraseña.TabIndex = 1;
            this.Contraseña.Text = "Contraseña";
            // 
            // IngresoNameUsser
            // 
            this.IngresoNameUsser.Location = new System.Drawing.Point(102, 121);
            this.IngresoNameUsser.Name = "IngresoNameUsser";
            this.IngresoNameUsser.Size = new System.Drawing.Size(138, 20);
            this.IngresoNameUsser.TabIndex = 2;
            // 
            // ContenedorContraseña
            // 
            this.ContenedorContraseña.Location = new System.Drawing.Point(103, 188);
            this.ContenedorContraseña.Name = "ContenedorContraseña";
            this.ContenedorContraseña.Size = new System.Drawing.Size(137, 20);
            this.ContenedorContraseña.TabIndex = 3;
            // 
            // Ingresar
            // 
            this.Ingresar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Ingresar.Location = new System.Drawing.Point(70, 232);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Ingresar.Size = new System.Drawing.Size(60, 28);
            this.Ingresar.TabIndex = 4;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = false;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Cancelar.Location = new System.Drawing.Point(161, 235);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(66, 24);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            // 
            // PantallaLogueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::InterfaceGrafica.Properties.Resources._18902_en_1;
            this.ClientSize = new System.Drawing.Size(397, 321);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.ContenedorContraseña);
            this.Controls.Add(this.IngresoNameUsser);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.NombreDeUsuario);
            this.Name = "PantallaLogueo";
            this.Text = "Logueo";
            this.Load += new System.EventHandler(this.PantallaLogueo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreDeUsuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox IngresoNameUsser;
        private System.Windows.Forms.TextBox ContenedorContraseña;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Button Cancelar;
    }
}