namespace PresentacionWin
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.RTxtIntroduccion = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBDeCuentaCorrienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesDePrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosConFiltroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTxtIntroduccion
            // 
            this.RTxtIntroduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtIntroduccion.Location = new System.Drawing.Point(21, 30);
            this.RTxtIntroduccion.Name = "RTxtIntroduccion";
            this.RTxtIntroduccion.ReadOnly = true;
            this.RTxtIntroduccion.Size = new System.Drawing.Size(941, 306);
            this.RTxtIntroduccion.TabIndex = 0;
            this.RTxtIntroduccion.Text = resources.GetString("RTxtIntroduccion.Text");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMDeClientesToolStripMenuItem,
            this.aBDeCuentaCorrienteToolStripMenuItem,
            this.solicitudesDePrestamosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // aBMDeClientesToolStripMenuItem
            // 
            this.aBMDeClientesToolStripMenuItem.Name = "aBMDeClientesToolStripMenuItem";
            this.aBMDeClientesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.aBMDeClientesToolStripMenuItem.Text = "ABM de Clientes";
            this.aBMDeClientesToolStripMenuItem.Click += new System.EventHandler(this.aBMDeClientesToolStripMenuItem_Click);
            // 
            // aBDeCuentaCorrienteToolStripMenuItem
            // 
            this.aBDeCuentaCorrienteToolStripMenuItem.Name = "aBDeCuentaCorrienteToolStripMenuItem";
            this.aBDeCuentaCorrienteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.aBDeCuentaCorrienteToolStripMenuItem.Text = "AB de Cuenta Corriente";
            this.aBDeCuentaCorrienteToolStripMenuItem.Click += new System.EventHandler(this.aBDeCuentaCorrienteToolStripMenuItem_Click);
            // 
            // solicitudesDePrestamosToolStripMenuItem
            // 
            this.solicitudesDePrestamosToolStripMenuItem.Name = "solicitudesDePrestamosToolStripMenuItem";
            this.solicitudesDePrestamosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.solicitudesDePrestamosToolStripMenuItem.Text = "Solicitudes de Prestamos";
            this.solicitudesDePrestamosToolStripMenuItem.Click += new System.EventHandler(this.solicitudesDePrestamosToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            this.movimientosToolStripMenuItem.Click += new System.EventHandler(this.movimientosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.cuentasToolStripMenuItem,
            this.movimientosConFiltroToolStripMenuItem,
            this.prestamosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            this.cuentasToolStripMenuItem.Click += new System.EventHandler(this.cuentasToolStripMenuItem_Click);
            // 
            // movimientosConFiltroToolStripMenuItem
            // 
            this.movimientosConFiltroToolStripMenuItem.Name = "movimientosConFiltroToolStripMenuItem";
            this.movimientosConFiltroToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.movimientosConFiltroToolStripMenuItem.Text = "Movimientos con Filtro";
            this.movimientosConFiltroToolStripMenuItem.Click += new System.EventHandler(this.movimientosConFiltroToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            this.prestamosToolStripMenuItem.Click += new System.EventHandler(this.prestamosToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 345);
            this.Controls.Add(this.RTxtIntroduccion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Menu Principal de Empleado";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTxtIntroduccion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBDeCuentaCorrienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosConFiltroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesDePrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
    }
}