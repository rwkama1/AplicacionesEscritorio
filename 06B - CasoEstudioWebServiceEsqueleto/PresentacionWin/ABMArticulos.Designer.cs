namespace PresentacionWin
{
    partial class ABMArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMArticulos));
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.BtnAlta = new System.Windows.Forms.ToolStripButton();
            this.BtnBaja = new System.Windows.Forms.ToolStripButton();
            this.BtnModificar = new System.Windows.Forms.ToolStripButton();
            this.BtnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnListar = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.LblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BarraHerramientas.SuspendLayout();
            this.BarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(66, 43);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(90, 20);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            this.TxtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigo_Validating);
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAlta,
            this.BtnBaja,
            this.BtnModificar,
            this.BtnDeshacer,
            this.toolStripSeparator1,
            this.BtnListar});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(286, 25);
            this.BarraHerramientas.TabIndex = 8;
            this.BarraHerramientas.Text = "toolStrip1";
            // 
            // BtnAlta
            // 
            this.BtnAlta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAlta.Enabled = false;
            this.BtnAlta.Image = global::PresentacionWin.Properties.Resources.nuevo;
            this.BtnAlta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(23, 22);
            this.BtnAlta.Text = "Dar Alta";
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // BtnBaja
            // 
            this.BtnBaja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnBaja.Enabled = false;
            this.BtnBaja.Image = global::PresentacionWin.Properties.Resources.eliminar;
            this.BtnBaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(23, 22);
            this.BtnBaja.Text = "Eliminar ";
            // 
            // BtnModificar
            // 
            this.BtnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.Image = global::PresentacionWin.Properties.Resources.modificar;
            this.BtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(23, 22);
            this.BtnModificar.Text = "Modificar";
            // 
            // BtnDeshacer
            // 
            this.BtnDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDeshacer.Image = global::PresentacionWin.Properties.Resources.cancelar;
            this.BtnDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeshacer.Name = "BtnDeshacer";
            this.BtnDeshacer.Size = new System.Drawing.Size(23, 22);
            this.BtnDeshacer.Text = "Deshacer";
            this.BtnDeshacer.Click += new System.EventHandler(this.BtnDeshacer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnListar
            // 
            this.BtnListar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnListar.Image = ((System.Drawing.Image)(resources.GetObject("BtnListar.Image")));
            this.BtnListar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(49, 22);
            this.BtnListar.Text = "Listado";
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo";
            // 
            // BarraEstado
            // 
            this.BarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblError});
            this.BarraEstado.Location = new System.Drawing.Point(0, 144);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(286, 22);
            this.BarraEstado.TabIndex = 11;
            this.BarraEstado.Text = "statusStrip1";
            // 
            // LblError
            // 
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 17);
            // 
            // Cronometro
            // 
            this.Cronometro.Enabled = true;
            this.Cronometro.Interval = 15000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(66, 69);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(188, 20);
            this.TxtNombre.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Precio";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(66, 95);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(90, 20);
            this.TxtPrecio.TabIndex = 14;
            // 
            // ABMArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 166);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BarraHerramientas);
            this.Controls.Add(this.TxtCodigo);
            this.Name = "ABMArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Articulos";
            this.Load += new System.EventHandler(this.ABMArticulos_Load);
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton BtnAlta;
        private System.Windows.Forms.ToolStripButton BtnBaja;
        private System.Windows.Forms.ToolStripButton BtnModificar;
        private System.Windows.Forms.StatusStrip BarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel LblError;
        private System.Windows.Forms.Timer Cronometro;
        private System.Windows.Forms.ToolStripButton BtnDeshacer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnListar;
    }
}