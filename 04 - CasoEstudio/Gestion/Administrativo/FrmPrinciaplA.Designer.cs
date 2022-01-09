namespace Gestion
{
    partial class FrmPrinciaplA
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
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cicloDeVidaDelFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoDelMauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraMenu
            // 
            this.BarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.ejemplosToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.BarraMenu.Location = new System.Drawing.Point(0, 0);
            this.BarraMenu.Name = "BarraMenu";
            this.BarraMenu.Size = new System.Drawing.Size(626, 24);
            this.BarraMenu.TabIndex = 0;
            this.BarraMenu.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoresToolStripMenuItem,
            this.librosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.autoresToolStripMenuItem.Text = "Autores (Desconectado)";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.librosToolStripMenuItem.Text = "Libros (Conectado)";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.librosToolStripMenuItem_Click);
            // 
            // ejemplosToolStripMenuItem
            // 
            this.ejemplosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cicloDeVidaDelFormularioToolStripMenuItem,
            this.manejoDelMauseToolStripMenuItem,
            this.winControlsToolStripMenuItem});
            this.ejemplosToolStripMenuItem.Name = "ejemplosToolStripMenuItem";
            this.ejemplosToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
            this.ejemplosToolStripMenuItem.Text = "Ejemplos Elementos Nuevos";
            // 
            // cicloDeVidaDelFormularioToolStripMenuItem
            // 
            this.cicloDeVidaDelFormularioToolStripMenuItem.Name = "cicloDeVidaDelFormularioToolStripMenuItem";
            this.cicloDeVidaDelFormularioToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.cicloDeVidaDelFormularioToolStripMenuItem.Text = "Ciclo de Vida del Formulario";
            this.cicloDeVidaDelFormularioToolStripMenuItem.Click += new System.EventHandler(this.cicloDeVidaDelFormularioToolStripMenuItem_Click);
            // 
            // manejoDelMauseToolStripMenuItem
            // 
            this.manejoDelMauseToolStripMenuItem.Name = "manejoDelMauseToolStripMenuItem";
            this.manejoDelMauseToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.manejoDelMauseToolStripMenuItem.Text = "Manejo del Mouse";
            this.manejoDelMauseToolStripMenuItem.Click += new System.EventHandler(this.manejoDelMauseToolStripMenuItem_Click);
            // 
            // winControlsToolStripMenuItem
            // 
            this.winControlsToolStripMenuItem.Name = "winControlsToolStripMenuItem";
            this.winControlsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.winControlsToolStripMenuItem.Text = "WinControls";
            this.winControlsToolStripMenuItem.Click += new System.EventHandler(this.winControlsToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // FrmPrinciaplA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 339);
            this.Controls.Add(this.BarraMenu);
            this.MainMenuStrip = this.BarraMenu;
            this.Name = "FrmPrinciaplA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal - Administrador";
            this.BarraMenu.ResumeLayout(false);
            this.BarraMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BarraMenu;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoDelMauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cicloDeVidaDelFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winControlsToolStripMenuItem;
    }
}