namespace PresentacionWin
{
    partial class FrmListadoMovimientos
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
            this.DGVListar = new System.Windows.Forms.DataGridView();
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.LblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.CBTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.LblDatoFiltro = new System.Windows.Forms.Label();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListar)).BeginInit();
            this.BarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVListar
            // 
            this.DGVListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListar.Location = new System.Drawing.Point(16, 150);
            this.DGVListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVListar.Name = "DGVListar";
            this.DGVListar.Size = new System.Drawing.Size(799, 219);
            this.DGVListar.TabIndex = 0;
            // 
            // Cronometro
            // 
            this.Cronometro.Enabled = true;
            this.Cronometro.Interval = 15000;
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick_1);
            // 
            // BarraEstado
            // 
            this.BarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblError});
            this.BarraEstado.Location = new System.Drawing.Point(0, 378);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.BarraEstado.Size = new System.Drawing.Size(840, 22);
            this.BarraEstado.TabIndex = 15;
            this.BarraEstado.Text = "statusStrip1";
            // 
            // LblError
            // 
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seleccione Tipo de Busqueda:";
            // 
            // CBTipoBusqueda
            // 
            this.CBTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoBusqueda.FormattingEnabled = true;
            this.CBTipoBusqueda.Items.AddRange(new object[] {
            "Sin Filtro",
            "Filtrar por Numero de Cuenta",
            "Filtrar por Tipo Movimiento",
            "Filtrar por Fecha",
            "Cantidad de Movimientos por Cuenta",
            "Ordenar por numero de Cuenta"});
            this.CBTipoBusqueda.Location = new System.Drawing.Point(224, 20);
            this.CBTipoBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBTipoBusqueda.Name = "CBTipoBusqueda";
            this.CBTipoBusqueda.Size = new System.Drawing.Size(296, 24);
            this.CBTipoBusqueda.TabIndex = 17;
            this.CBTipoBusqueda.SelectedIndexChanged += new System.EventHandler(this.CBTipoBusqueda_SelectedIndexChanged);
            // 
            // LblDatoFiltro
            // 
            this.LblDatoFiltro.AutoSize = true;
            this.LblDatoFiltro.Location = new System.Drawing.Point(16, 57);
            this.LblDatoFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDatoFiltro.Name = "LblDatoFiltro";
            this.LblDatoFiltro.Size = new System.Drawing.Size(110, 17);
            this.LblDatoFiltro.TabIndex = 18;
            this.LblDatoFiltro.Text = "Dato para Filtro:";
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(224, 53);
            this.TxtFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(164, 22);
            this.TxtFiltro.TabIndex = 19;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(20, 96);
            this.BtnFiltrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(100, 28);
            this.BtnFiltrar.TabIndex = 20;
            this.BtnFiltrar.Text = "Aplicar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // FrmListadoMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 400);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.LblDatoFiltro);
            this.Controls.Add(this.CBTipoBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.DGVListar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmListadoMovimientos";
            this.Text = "Listado Movimientos";
            this.Load += new System.EventHandler(this.FrmListadoMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListar)).EndInit();
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListar;
        private System.Windows.Forms.Timer Cronometro;
        private System.Windows.Forms.StatusStrip BarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel LblError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBTipoBusqueda;
        private System.Windows.Forms.Label LblDatoFiltro;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Button BtnFiltrar;
    }
}