namespace PresentacionWin
{
    partial class FrmListadoCuenta 
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
            this.DGVCuentas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCuentas
            // 
            this.DGVCuentas.AllowUserToAddRows = false;
            this.DGVCuentas.AllowUserToDeleteRows = false;
            this.DGVCuentas.AllowUserToOrderColumns = true;
            this.DGVCuentas.AllowUserToResizeColumns = false;
            this.DGVCuentas.AllowUserToResizeRows = false;
            this.DGVCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DGVCuentas.Location = new System.Drawing.Point(12, 12);
            this.DGVCuentas.Name = "DGVCuentas";
            this.DGVCuentas.ReadOnly = true;
            this.DGVCuentas.Size = new System.Drawing.Size(348, 189);
            this.DGVCuentas.TabIndex = 0;
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
            this.Column2.DataPropertyName = "MiCliente";
            this.Column2.HeaderText = "Cliente";
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
            // FrmListadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 214);
            this.Controls.Add(this.DGVCuentas);
            this.Name = "FrmListadoCuenta";
            this.Text = "Listado Cuentas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListadoCuenta_FormClosing);
            this.Load += new System.EventHandler(this.FrmListadoCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}