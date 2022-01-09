namespace Gestion
{
    partial class FrmRelacionTablas
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
            this.DGVAutores = new System.Windows.Forms.DataGridView();
            this.DGVLibros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAutores
            // 
            this.DGVAutores.AllowUserToAddRows = false;
            this.DGVAutores.AllowUserToDeleteRows = false;
            this.DGVAutores.AllowUserToOrderColumns = true;
            this.DGVAutores.AllowUserToResizeColumns = false;
            this.DGVAutores.AllowUserToResizeRows = false;
            this.DGVAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAutores.Location = new System.Drawing.Point(12, 22);
            this.DGVAutores.Name = "DGVAutores";
            this.DGVAutores.ReadOnly = true;
            this.DGVAutores.Size = new System.Drawing.Size(343, 123);
            this.DGVAutores.TabIndex = 0;
            // 
            // DGVLibros
            // 
            this.DGVLibros.AllowUserToAddRows = false;
            this.DGVLibros.AllowUserToDeleteRows = false;
            this.DGVLibros.AllowUserToOrderColumns = true;
            this.DGVLibros.AllowUserToResizeColumns = false;
            this.DGVLibros.AllowUserToResizeRows = false;
            this.DGVLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLibros.Location = new System.Drawing.Point(12, 162);
            this.DGVLibros.Name = "DGVLibros";
            this.DGVLibros.ReadOnly = true;
            this.DGVLibros.Size = new System.Drawing.Size(543, 94);
            this.DGVLibros.TabIndex = 1;
            // 
            // FrmRelacionTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 269);
            this.Controls.Add(this.DGVLibros);
            this.Controls.Add(this.DGVAutores);
            this.Name = "FrmRelacionTablas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relacion automatica entre DataTables";
            this.Load += new System.EventHandler(this.FrmRelacionTablas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAutores;
        private System.Windows.Forms.DataGridView DGVLibros;
    }
}