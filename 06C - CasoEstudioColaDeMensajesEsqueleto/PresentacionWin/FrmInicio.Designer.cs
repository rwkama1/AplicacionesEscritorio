namespace PresentacionWin
{
    partial class FrmInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBMArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarArticulosEnBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPedidosEnLaBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mensaje = new System.Windows.Forms.TextBox();
            this.TxtPedido = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMArticulosToolStripMenuItem,
            this.listarArticulosEnBDToolStripMenuItem,
            this.listarPedidosEnLaBDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBMArticulosToolStripMenuItem
            // 
            this.aBMArticulosToolStripMenuItem.Name = "aBMArticulosToolStripMenuItem";
            this.aBMArticulosToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.aBMArticulosToolStripMenuItem.Text = "ABM Articulos";
            this.aBMArticulosToolStripMenuItem.Click += new System.EventHandler(this.aBMArticulosToolStripMenuItem_Click);
            // 
            // listarArticulosEnBDToolStripMenuItem
            // 
            this.listarArticulosEnBDToolStripMenuItem.Name = "listarArticulosEnBDToolStripMenuItem";
            this.listarArticulosEnBDToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.listarArticulosEnBDToolStripMenuItem.Text = "Listar Articulos en BD";
            this.listarArticulosEnBDToolStripMenuItem.Click += new System.EventHandler(this.listarArticulosEnBDToolStripMenuItem_Click);
            // 
            // listarPedidosEnLaBDToolStripMenuItem
            // 
            this.listarPedidosEnLaBDToolStripMenuItem.Name = "listarPedidosEnLaBDToolStripMenuItem";
            this.listarPedidosEnLaBDToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.listarPedidosEnLaBDToolStripMenuItem.Text = "Listar Pedidos en la BD";
            this.listarPedidosEnLaBDToolStripMenuItem.Click += new System.EventHandler(this.listarPedidosEnLaBDToolStripMenuItem_Click);
            // 
            // Mensaje
            // 
            this.Mensaje.Enabled = false;
            this.Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensaje.ForeColor = System.Drawing.Color.SeaGreen;
            this.Mensaje.Location = new System.Drawing.Point(19, 27);
            this.Mensaje.Multiline = true;
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.ReadOnly = true;
            this.Mensaje.Size = new System.Drawing.Size(522, 50);
            this.Mensaje.TabIndex = 2;
            this.Mensaje.Text = "Mientras este Formulario este funcional Se escucha de forma ASINCRONICA la cola d" +
    "e pedidos del servidor";
            this.Mensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPedido
            // 
            this.TxtPedido.Enabled = false;
            this.TxtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPedido.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.TxtPedido.Location = new System.Drawing.Point(89, 123);
            this.TxtPedido.Multiline = true;
            this.TxtPedido.Name = "TxtPedido";
            this.TxtPedido.Size = new System.Drawing.Size(383, 90);
            this.TxtPedido.TabIndex = 3;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 278);
            this.Controls.Add(this.TxtPedido);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmInicio";
            this.Text = "Formulario Principal ";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBMArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarArticulosEnBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPedidosEnLaBDToolStripMenuItem;
        private System.Windows.Forms.TextBox Mensaje;
        private System.Windows.Forms.TextBox TxtPedido;
    }
}