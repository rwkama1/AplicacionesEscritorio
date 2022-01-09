namespace PresentacionWin
{
    partial class FrmLogueo
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.MiControlLogin = new ControlesWin.ControlLogueo();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 207);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(438, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LblError
            // 
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 17);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(2, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ejemplo Final - Aplicaciones Distribuidas y Moviles";
            // 
            // MiControlLogin
            // 
            this.MiControlLogin.BackColor = System.Drawing.Color.Azure;
            this.MiControlLogin.Location = new System.Drawing.Point(104, 56);
            this.MiControlLogin.Name = "MiControlLogin";
            this.MiControlLogin.Size = new System.Drawing.Size(210, 131);
            this.MiControlLogin.TabIndex = 8;
            // 
            // FrmLogueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 229);
            this.Controls.Add(this.MiControlLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmLogueo";
            this.Text = "Bienvenidos";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LblError;
        private System.Windows.Forms.Label label3;
        private ControlesWin.ControlLogueo MiControlLogin;
    }
}