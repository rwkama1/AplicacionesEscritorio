namespace Controles
{
    partial class TextBoxSoloNumeros
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtIngreso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtIngreso
            // 
            this.TxtIngreso.Location = new System.Drawing.Point(3, 3);
            this.TxtIngreso.Name = "TxtIngreso";
            this.TxtIngreso.Size = new System.Drawing.Size(207, 20);
            this.TxtIngreso.TabIndex = 0;
            this.TxtIngreso.Text = "0";
            this.TxtIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIngreso_KeyPress);
            // 
            // TextBoxSoloNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtIngreso);
            this.Name = "TextBoxSoloNumeros";
            this.Size = new System.Drawing.Size(213, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIngreso;
    }
}
