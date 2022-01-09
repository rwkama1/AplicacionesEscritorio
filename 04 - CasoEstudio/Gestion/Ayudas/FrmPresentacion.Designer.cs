namespace Gestion
{
    partial class FrmPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPresentacion));
            this.PbImagen = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.Conometro = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // PbImagen
            // 
            this.PbImagen.Image = ((System.Drawing.Image)(resources.GetObject("PbImagen.Image")));
            this.PbImagen.Location = new System.Drawing.Point(61, 58);
            this.PbImagen.Name = "PbImagen";
            this.PbImagen.Size = new System.Drawing.Size(391, 293);
            this.PbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbImagen.TabIndex = 0;
            this.PbImagen.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblTitulo.Location = new System.Drawing.Point(155, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(205, 46);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Biblioteca";
            // 
            // Conometro
            // 
            this.Conometro.Enabled = true;
            this.Conometro.Interval = 2500;
            this.Conometro.Tick += new System.EventHandler(this.Conometro_Tick);
            // 
            // FrmPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 359);
            this.ControlBox = false;
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PbImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPresentacion";
            ((System.ComponentModel.ISupportInitialize)(this.PbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbImagen;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Timer Conometro;
    }
}