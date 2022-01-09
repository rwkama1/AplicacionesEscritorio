namespace Gestion
{
    partial class FrmCicloVida
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
            this.LblActivated = new System.Windows.Forms.Label();
            this.LblLoad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblActivated
            // 
            this.LblActivated.AutoSize = true;
            this.LblActivated.Location = new System.Drawing.Point(122, 34);
            this.LblActivated.Name = "LblActivated";
            this.LblActivated.Size = new System.Drawing.Size(89, 13);
            this.LblActivated.TabIndex = 0;
            this.LblActivated.Text = "Evento Activated";
            // 
            // LblLoad
            // 
            this.LblLoad.AutoSize = true;
            this.LblLoad.Location = new System.Drawing.Point(132, 66);
            this.LblLoad.Name = "LblLoad";
            this.LblLoad.Size = new System.Drawing.Size(68, 13);
            this.LblLoad.TabIndex = 1;
            this.LblLoad.Text = "Evento Load";
            // 
            // FrmCicloVida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 123);
            this.Controls.Add(this.LblLoad);
            this.Controls.Add(this.LblActivated);
            this.Name = "FrmCicloVida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos del Ciclo de vida ";
            this.Activated += new System.EventHandler(this.FrmCicloVida_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCicloVida_FormClosing);
            this.Load += new System.EventHandler(this.FrmCicloVida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblActivated;
        private System.Windows.Forms.Label LblLoad;
    }
}