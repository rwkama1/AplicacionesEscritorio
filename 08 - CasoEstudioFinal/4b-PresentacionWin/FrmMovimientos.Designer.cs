namespace PresentacionWin
{
    partial class FrmMovimientos
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
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.BtnAlta = new System.Windows.Forms.ToolStripButton();
            this.BtnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.LblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCuenta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBtnRet = new System.Windows.Forms.RadioButton();
            this.RBtnDep = new System.Windows.Forms.RadioButton();
            this.EPNumeros = new System.Windows.Forms.ErrorProvider(this.components);
            this.BarraHerramientas.SuspendLayout();
            this.BarraEstado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // Cronometro
            // 
            this.Cronometro.Enabled = true;
            this.Cronometro.Interval = 15000;
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAlta,
            this.BtnDeshacer});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(375, 25);
            this.BarraHerramientas.TabIndex = 17;
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
            // BarraEstado
            // 
            this.BarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblError});
            this.BarraEstado.Location = new System.Drawing.Point(0, 139);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(375, 22);
            this.BarraEstado.TabIndex = 16;
            this.BarraEstado.Text = "statusStrip1";
            // 
            // LblError
            // 
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 17);
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(115, 57);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(82, 20);
            this.TxtMonto.TabIndex = 24;
            this.TxtMonto.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMonto_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Monto:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(203, 29);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(37, 23);
            this.BtnBuscar.TabIndex = 22;
            this.BtnBuscar.Text = "...";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtCuenta
            // 
            this.TxtCuenta.Location = new System.Drawing.Point(115, 31);
            this.TxtCuenta.Name = "TxtCuenta";
            this.TxtCuenta.Size = new System.Drawing.Size(82, 20);
            this.TxtCuenta.TabIndex = 21;
            this.TxtCuenta.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCuenta_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Numero Cuenta:";
            // 
            // LblCuenta
            // 
            this.LblCuenta.AutoSize = true;
            this.LblCuenta.Location = new System.Drawing.Point(246, 34);
            this.LblCuenta.Name = "LblCuenta";
            this.LblCuenta.Size = new System.Drawing.Size(0, 13);
            this.LblCuenta.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBtnRet);
            this.groupBox1.Controls.Add(this.RBtnDep);
            this.groupBox1.Location = new System.Drawing.Point(35, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 50);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // RBtnRet
            // 
            this.RBtnRet.AutoSize = true;
            this.RBtnRet.Checked = true;
            this.RBtnRet.Location = new System.Drawing.Point(93, 19);
            this.RBtnRet.Name = "RBtnRet";
            this.RBtnRet.Size = new System.Drawing.Size(40, 14);
            this.RBtnRet.TabIndex = 1;
            this.RBtnRet.TabStop = true;
            this.RBtnRet.Text = "Retiro";
            this.RBtnRet.UseVisualStyleBackColor = true;
            // 
            // RBtnDep
            // 
            this.RBtnDep.AutoSize = true;
            this.RBtnDep.Location = new System.Drawing.Point(14, 19);
            this.RBtnDep.Name = "RBtnDep";
            this.RBtnDep.Size = new System.Drawing.Size(50, 14);
            this.RBtnDep.TabIndex = 0;
            this.RBtnDep.Text = "Deposito";
            this.RBtnDep.UseVisualStyleBackColor = true;
            // 
            // EPNumeros
            // 
            this.EPNumeros.ContainerControl = this;
            // 
            // FrmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 161);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblCuenta);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarraHerramientas);
            this.Controls.Add(this.BarraEstado);
            this.Name = "FrmMovimientos";
            this.Text = "Generar Movimientos";
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Cronometro;
        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private System.Windows.Forms.ToolStripButton BtnAlta;
        private System.Windows.Forms.ToolStripButton BtnDeshacer;
        private System.Windows.Forms.StatusStrip BarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel LblError;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCuenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBtnRet;
        private System.Windows.Forms.RadioButton RBtnDep;
        private System.Windows.Forms.ErrorProvider EPNumeros;
    }
}