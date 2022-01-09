namespace Gestion
{
    partial class FrmConsulta
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
            this.TipoLibros = new Controles.CBTipo();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvLibros = new System.Windows.Forms.DataGridView();
            this.BtnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoLibros
            // 
            this.TipoLibros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoLibros.FormattingEnabled = true;
            this.TipoLibros.Location = new System.Drawing.Point(87, 24);
            this.TipoLibros.Name = "TipoLibros";
            this.TipoLibros.Size = new System.Drawing.Size(121, 21);
            this.TipoLibros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Libro";
            // 
            // DgvLibros
            // 
            this.DgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLibros.Location = new System.Drawing.Point(12, 72);
            this.DgvLibros.Name = "DgvLibros";
            this.DgvLibros.Size = new System.Drawing.Size(336, 212);
            this.DgvLibros.TabIndex = 2;
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(217, 23);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 3;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 306);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.DgvLibros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipoLibros);
            this.Name = "FrmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Parametrizada";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.CBTipo TipoLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvLibros;
        private System.Windows.Forms.Button BtnListar;
    }
}