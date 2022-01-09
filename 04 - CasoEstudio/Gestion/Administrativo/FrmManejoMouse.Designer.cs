namespace Gestion
{
    partial class FrmManejoMouse
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
            this.BtnMuestra = new System.Windows.Forms.Button();
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.LblMove = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblOtro = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnMuestra2 = new System.Windows.Forms.Button();
            this.TxtMensaje = new System.Windows.Forms.TextBox();
            this.BarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnMuestra
            // 
            this.BtnMuestra.Location = new System.Drawing.Point(12, 12);
            this.BtnMuestra.Name = "BtnMuestra";
            this.BtnMuestra.Size = new System.Drawing.Size(234, 94);
            this.BtnMuestra.TabIndex = 0;
            this.BtnMuestra.Text = "Muestra (Enter - Leave)";
            this.BtnMuestra.UseVisualStyleBackColor = true;
            this.BtnMuestra.MouseEnter += new System.EventHandler(this.BtnMuestra_MouseEnter);
            this.BtnMuestra.MouseLeave += new System.EventHandler(this.BtnMuestra_MouseLeave);
            // 
            // BarraEstado
            // 
            this.BarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblMove,
            this.LblOtro});
            this.BarraEstado.Location = new System.Drawing.Point(0, 232);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(394, 22);
            this.BarraEstado.TabIndex = 1;
            this.BarraEstado.Text = "statusStrip1";
            // 
            // LblMove
            // 
            this.LblMove.Name = "LblMove";
            this.LblMove.Size = new System.Drawing.Size(0, 17);
            // 
            // LblOtro
            // 
            this.LblOtro.Name = "LblOtro";
            this.LblOtro.Size = new System.Drawing.Size(0, 17);
            // 
            // BtnMuestra2
            // 
            this.BtnMuestra2.Location = new System.Drawing.Point(12, 127);
            this.BtnMuestra2.Name = "BtnMuestra2";
            this.BtnMuestra2.Size = new System.Drawing.Size(234, 94);
            this.BtnMuestra2.TabIndex = 2;
            this.BtnMuestra2.Text = "Muestra (Move)";
            this.BtnMuestra2.UseVisualStyleBackColor = true;
            this.BtnMuestra2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnMuestra2_MouseMove);
            // 
            // TxtMensaje
            // 
            this.TxtMensaje.Enabled = false;
            this.TxtMensaje.ForeColor = System.Drawing.Color.Red;
            this.TxtMensaje.Location = new System.Drawing.Point(283, 76);
            this.TxtMensaje.Multiline = true;
            this.TxtMensaje.Name = "TxtMensaje";
            this.TxtMensaje.Size = new System.Drawing.Size(100, 66);
            this.TxtMensaje.TabIndex = 4;
            this.TxtMensaje.Text = "Verifique los botones del Mouse sobre el fondo del FORMULARIO";
            this.TxtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmManejoMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 254);
            this.Controls.Add(this.TxtMensaje);
            this.Controls.Add(this.BtnMuestra2);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.BtnMuestra);
            this.Name = "FrmManejoMouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos Captura Mouse";
            this.Load += new System.EventHandler(this.FrmManejoMouse_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmManejoMouse_MouseClick);
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMuestra;
        private System.Windows.Forms.StatusStrip BarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel LblMove;
        private System.Windows.Forms.ToolStripStatusLabel LblOtro;
        private System.Windows.Forms.Button BtnMuestra2;
        private System.Windows.Forms.TextBox TxtMensaje;
    }
}