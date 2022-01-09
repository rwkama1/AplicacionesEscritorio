namespace PresentacionWin
{
    partial class FrmPrestamos
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
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.LblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.BtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.DGVPrestamosPendientes = new System.Windows.Forms.DataGridView();
            this.DTPFechaAprob = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblCliente = new System.Windows.Forms.Label();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.RBtnRechazado = new System.Windows.Forms.RadioButton();
            this.RBtnAceptado = new System.Windows.Forms.RadioButton();
            this.LblMonto = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BarraEstado.SuspendLayout();
            this.BarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPrestamosPendientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraEstado
            // 
            this.BarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblError});
            this.BarraEstado.Location = new System.Drawing.Point(0, 229);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(580, 22);
            this.BarraEstado.TabIndex = 15;
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
            this.BtnActualizar});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(580, 25);
            this.BarraHerramientas.TabIndex = 14;
            this.BarraHerramientas.Text = "toolStrip1";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnActualizar.Image = global::PresentacionWin.Properties.Resources.modificar;
            this.BtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(23, 22);
            this.BtnActualizar.Text = "Actualizar Prestamos Pendientes";
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // Cronometro
            // 
            this.Cronometro.Enabled = true;
            this.Cronometro.Interval = 15000;
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // DGVPrestamosPendientes
            // 
            this.DGVPrestamosPendientes.AllowUserToAddRows = false;
            this.DGVPrestamosPendientes.AllowUserToDeleteRows = false;
            this.DGVPrestamosPendientes.AllowUserToResizeColumns = false;
            this.DGVPrestamosPendientes.AllowUserToResizeRows = false;
            this.DGVPrestamosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPrestamosPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGVPrestamosPendientes.Location = new System.Drawing.Point(12, 33);
            this.DGVPrestamosPendientes.Name = "DGVPrestamosPendientes";
            this.DGVPrestamosPendientes.ReadOnly = true;
            this.DGVPrestamosPendientes.RowTemplate.Height = 24;
            this.DGVPrestamosPendientes.Size = new System.Drawing.Size(255, 186);
            this.DGVPrestamosPendientes.TabIndex = 16;
            this.DGVPrestamosPendientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPrestamosPendientes_CellContentDoubleClick);
            // 
            // DTPFechaAprob
            // 
            this.DTPFechaAprob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaAprob.Location = new System.Drawing.Point(74, 26);
            this.DTPFechaAprob.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFechaAprob.Name = "DTPFechaAprob";
            this.DTPFechaAprob.Size = new System.Drawing.Size(99, 20);
            this.DTPFechaAprob.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblCliente);
            this.groupBox1.Controls.Add(this.BtnGrabar);
            this.groupBox1.Controls.Add(this.RBtnRechazado);
            this.groupBox1.Controls.Add(this.RBtnAceptado);
            this.groupBox1.Controls.Add(this.LblMonto);
            this.groupBox1.Controls.Add(this.DTPFechaAprob);
            this.groupBox1.Location = new System.Drawing.Point(292, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(261, 186);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitud Prestamo";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(74, 87);
            this.LblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(81, 13);
            this.LblCliente.TabIndex = 23;
            this.LblCliente.Text = "Dtos del Cliente";
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Enabled = false;
            this.BtnGrabar.Location = new System.Drawing.Point(102, 155);
            this.BtnGrabar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(56, 19);
            this.BtnGrabar.TabIndex = 22;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // RBtnRechazado
            // 
            this.RBtnRechazado.AutoSize = true;
            this.RBtnRechazado.Checked = true;
            this.RBtnRechazado.Location = new System.Drawing.Point(163, 122);
            this.RBtnRechazado.Margin = new System.Windows.Forms.Padding(2);
            this.RBtnRechazado.Name = "RBtnRechazado";
            this.RBtnRechazado.Size = new System.Drawing.Size(71, 17);
            this.RBtnRechazado.TabIndex = 21;
            this.RBtnRechazado.TabStop = true;
            this.RBtnRechazado.Text = "Rechazar";
            this.RBtnRechazado.UseVisualStyleBackColor = true;
            // 
            // RBtnAceptado
            // 
            this.RBtnAceptado.AutoSize = true;
            this.RBtnAceptado.Location = new System.Drawing.Point(34, 122);
            this.RBtnAceptado.Margin = new System.Windows.Forms.Padding(2);
            this.RBtnAceptado.Name = "RBtnAceptado";
            this.RBtnAceptado.Size = new System.Drawing.Size(62, 17);
            this.RBtnAceptado.TabIndex = 20;
            this.RBtnAceptado.Text = "Aceptar";
            this.RBtnAceptado.UseVisualStyleBackColor = true;
            // 
            // LblMonto
            // 
            this.LblMonto.AutoSize = true;
            this.LblMonto.Location = new System.Drawing.Point(74, 59);
            this.LblMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(13, 13);
            this.LblMonto.TabIndex = 18;
            this.LblMonto.Text = "0";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Fecha";
            this.Column1.HeaderText = "Fecha Sol.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Monto";
            this.Column2.HeaderText = "Monto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Monto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fecha:";
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 251);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVPrestamosPendientes);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.BarraHerramientas);
            this.Name = "FrmPrestamos";
            this.Text = "Procesamiento Prestamos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrestamos_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPrestamosPendientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip BarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel LblError;
        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private System.Windows.Forms.ToolStripButton BtnActualizar;
        private System.Windows.Forms.Timer Cronometro;
        private System.Windows.Forms.DataGridView DGVPrestamosPendientes;
        private System.Windows.Forms.DateTimePicker DTPFechaAprob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.RadioButton RBtnRechazado;
        private System.Windows.Forms.RadioButton RBtnAceptado;
        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}