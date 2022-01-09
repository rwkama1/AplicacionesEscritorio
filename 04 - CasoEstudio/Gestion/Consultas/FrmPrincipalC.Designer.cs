namespace Gestion
{
    partial class FrmPrincipalC
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
            this.BarraMenu = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosDeUnAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasParametrizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosXAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraMenu
            // 
            this.BarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.consultasParametrizadasToolStripMenuItem});
            this.BarraMenu.Location = new System.Drawing.Point(0, 0);
            this.BarraMenu.Name = "BarraMenu";
            this.BarraMenu.Size = new System.Drawing.Size(626, 24);
            this.BarraMenu.TabIndex = 0;
            this.BarraMenu.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosDeUnAutorToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.consultasToolStripMenuItem.Text = "Consultas (Desconectado)";
            // 
            // librosDeUnAutorToolStripMenuItem
            // 
            this.librosDeUnAutorToolStripMenuItem.Name = "librosDeUnAutorToolStripMenuItem";
            this.librosDeUnAutorToolStripMenuItem.Size = new System.Drawing.Size(312, 22);
            this.librosDeUnAutorToolStripMenuItem.Text = "Autor --> Libros (DataRelation - Automatico)";
            this.librosDeUnAutorToolStripMenuItem.Click += new System.EventHandler(this.librosDeUnAutorToolStripMenuItem_Click);
            // 
            // consultasParametrizadasToolStripMenuItem
            // 
            this.consultasParametrizadasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosXAutorToolStripMenuItem});
            this.consultasParametrizadasToolStripMenuItem.Name = "consultasParametrizadasToolStripMenuItem";
            this.consultasParametrizadasToolStripMenuItem.Size = new System.Drawing.Size(223, 20);
            this.consultasParametrizadasToolStripMenuItem.Text = "Consultas Parametrizadas (Conectado)";
            // 
            // librosXAutorToolStripMenuItem
            // 
            this.librosXAutorToolStripMenuItem.Name = "librosXAutorToolStripMenuItem";
            this.librosXAutorToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.librosXAutorToolStripMenuItem.Text = "Libros x Tipo";
            this.librosXAutorToolStripMenuItem.Click += new System.EventHandler(this.librosXAutorToolStripMenuItem_Click);
            // 
            // FrmPrincipalC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 339);
            this.Controls.Add(this.BarraMenu);
            this.MainMenuStrip = this.BarraMenu;
            this.Name = "FrmPrincipalC";
            this.Text = "Principal - Sin Registrar";
            this.BarraMenu.ResumeLayout(false);
            this.BarraMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BarraMenu;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosDeUnAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasParametrizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosXAutorToolStripMenuItem;
    }
}