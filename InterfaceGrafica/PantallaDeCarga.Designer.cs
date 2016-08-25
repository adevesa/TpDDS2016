namespace InterfaceGrafica
{
    partial class PantallaDeCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaDeCarga));
            this.BarraDeCarga = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BarraDeCarga
            // 
            resources.ApplyResources(this.BarraDeCarga, "BarraDeCarga");
            this.BarraDeCarga.Name = "BarraDeCarga";
            this.BarraDeCarga.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contador
            // 
            resources.ApplyResources(this.contador, "contador");
            this.contador.BackColor = System.Drawing.Color.Transparent;
            this.contador.Name = "contador";
            // 
            // PantallaDeCarga
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceGrafica.Properties.Resources.big_thumb_178c9f57852b89a220ba586c26d85e84;
            this.Controls.Add(this.contador);
            this.Controls.Add(this.BarraDeCarga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaDeCarga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaDeCarga_FormClosing);
            this.Load += new System.EventHandler(this.PantallaDeCarga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar BarraDeCarga;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label contador;
    }
}