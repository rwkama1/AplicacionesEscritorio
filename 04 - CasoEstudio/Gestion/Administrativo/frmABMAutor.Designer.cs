namespace Gestion.Administrativo
{
    partial class frmABMAutor
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnaltados = new System.Windows.Forms.ToolStripButton();
            this.btnbaja = new System.Windows.Forms.ToolStripButton();
            this.btnmodificar = new System.Windows.Forms.ToolStripButton();
            this.btnbuscar = new System.Windows.Forms.ToolStripButton();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.txtnacionalidad = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(25, 51);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "Codigo";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(28, 92);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(112, 48);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(138, 20);
            this.txtcodigo.TabIndex = 4;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(112, 92);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(138, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnaltados,
            this.btnbaja,
            this.btnmodificar,
            this.btnbuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(331, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnaltados
            // 
            this.btnaltados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnaltados.Image = global::Gestion.Properties.Resources.nuevo;
            this.btnaltados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnaltados.Name = "btnaltados";
            this.btnaltados.Size = new System.Drawing.Size(23, 22);
            this.btnaltados.Text = "Alta";
            // 
            // btnbaja
            // 
            this.btnbaja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbaja.Image = global::Gestion.Properties.Resources.eliminar;
            this.btnbaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(23, 22);
            this.btnbaja.Text = "Eliminar";
            // 
            // btnmodificar
            // 
            this.btnmodificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnmodificar.Image = global::Gestion.Properties.Resources.modificar;
            this.btnmodificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(23, 22);
            this.btnmodificar.Text = "Modificar";
            // 
            // btnbuscar
            // 
            this.btnbuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbuscar.Image = global::Gestion.Properties.Resources.libro;
            this.btnbuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(23, 22);
            this.btnbuscar.Text = "Buscar";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(12, 144);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(69, 13);
            this.lblNacionalidad.TabIndex = 11;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // txtnacionalidad
            // 
            this.txtnacionalidad.Location = new System.Drawing.Point(112, 144);
            this.txtnacionalidad.Name = "txtnacionalidad";
            this.txtnacionalidad.Size = new System.Drawing.Size(138, 20);
            this.txtnacionalidad.TabIndex = 12;
            // 
            // frmABMAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 309);
            this.Controls.Add(this.txtnacionalidad);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblcodigo);
            this.Name = "frmABMAutor";
            this.Text = "frmABMAutor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnaltados;
        private System.Windows.Forms.ToolStripButton btnbaja;
        private System.Windows.Forms.ToolStripButton btnmodificar;
        private System.Windows.Forms.ToolStripButton btnbuscar;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.TextBox txtnacionalidad;
    }
}