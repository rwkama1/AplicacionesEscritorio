namespace PresentacionWin
{
    partial class FrmCuentaCorriente
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.LblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.BtnAlta = new System.Windows.Forms.ToolStripButton();
            this.BtnBaja = new System.Windows.Forms.ToolStripButton();
            this.BtnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblCliente = new System.Windows.Forms.Label();
            this.TxtMinimo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVCuentas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPNumeros = new System.Windows.Forms.ErrorProvider(this.components);
            this.BarraEstado.SuspendLayout();
            this.BarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(73, 35);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(82, 20);
            this.TxtCliente.TabIndex = 1;
            this.TxtCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCliente_Validating);
            // 
            // Cronometro
            // 
            this.Cronometro.Enabled = true;
            this.Cronometro.Interval = 15000;
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // BarraEstado
            // 
            this.BarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblError});
            this.BarraEstado.Location = new System.Drawing.Point(0, 240);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(400, 22);
            this.BarraEstado.TabIndex = 14;
            this.BarraEstado.Text = "statusStrip1";
            // 
            // LblError
            // 
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 17);
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAlta,
            this.BtnBaja,
            this.BtnDeshacer});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(400, 25);
            this.BarraHerramientas.TabIndex = 15;
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
            this.BtnBaja.Image = global::PresentacionWin.Properties.Resources.eliminar;
            this.BtnBaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(23, 22);
            this.BtnBaja.Text = "Eliminar ";
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
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
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(161, 33);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(37, 23);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "...";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(204, 38);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(0, 13);
            this.LblCliente.TabIndex = 17;
            // 
            // TxtMinimo
            // 
            this.TxtMinimo.Location = new System.Drawing.Point(73, 61);
            this.TxtMinimo.Name = "TxtMinimo";
            this.TxtMinimo.Size = new System.Drawing.Size(82, 20);
            this.TxtMinimo.TabIndex = 19;
            this.TxtMinimo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMinimo_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Minimo:";
            // 
            // DGVCuentas
            // 
            this.DGVCuentas.AllowUserToAddRows = false;
            this.DGVCuentas.AllowUserToDeleteRows = false;
            this.DGVCuentas.AllowUserToResizeColumns = false;
            this.DGVCuentas.AllowUserToResizeRows = false;
            this.DGVCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DGVCuentas.Location = new System.Drawing.Point(28, 87);
            this.DGVCuentas.Name = "DGVCuentas";
            this.DGVCuentas.ReadOnly = true;
            this.DGVCuentas.Size = new System.Drawing.Size(346, 124);
            this.DGVCuentas.TabIndex = 20;
            this.DGVCuentas.SelectionChanged += new System.EventHandler(this.DGVCuentas_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NumCta";
            this.Column1.HeaderText = "Numero";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MinimoCta";
            this.Column2.HeaderText = "Minimo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SaldoCuenta";
            this.Column3.HeaderText = "Saldo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // EPNumeros
            // 
            this.EPNumeros.ContainerControl = this;
            // 
            // FrmCuentaCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 262);
            this.Controls.Add(this.DGVCuentas);
            this.Controls.Add(this.TxtMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BarraHerramientas);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.label1);
            this.Name = "FrmCuentaCorriente";
            this.Text = "AB - CuentaCorriente";
            this.Load += new System.EventHandler(this.FrmCuentaCorriente_Load);
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Timer Cronometro;
        private System.Windows.Forms.StatusStrip BarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel LblError;
        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private System.Windows.Forms.ToolStripButton BtnAlta;
        private System.Windows.Forms.ToolStripButton BtnDeshacer;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.TextBox TxtMinimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripButton BtnBaja;
        private System.Windows.Forms.ErrorProvider EPNumeros;
    }
}