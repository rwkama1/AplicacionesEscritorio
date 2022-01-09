namespace Gestion
{
    partial class FrmLibros
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.BtnAlta = new System.Windows.Forms.ToolStripButton();
            this.BtnBaja = new System.Windows.Forms.ToolStripButton();
            this.BtnModificar = new System.Windows.Forms.ToolStripButton();
            this.BtnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.TipoLibros = new Controles.CBTipo();
            this.Autores = new Controles.CbAutor();
            this.Isbn = new Controles.TextBoxSoloNumeros();
            this.label2 = new System.Windows.Forms.Label();
            this.RTxtReseña = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.LblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BarraHerramientas.SuspendLayout();
            this.BarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ISBN";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(107, 85);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(209, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAlta,
            this.BtnBaja,
            this.BtnModificar,
            this.BtnDeshacer});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(360, 25);
            this.BarraHerramientas.TabIndex = 8;
            this.BarraHerramientas.Text = "toolStrip1";
            // 
            // BtnAlta
            // 
            this.BtnAlta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAlta.Enabled = false;
            this.BtnAlta.Image = global::Gestion.Properties.Resources.nuevo;
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
            this.BtnBaja.Image = global::Gestion.Properties.Resources.eliminar;
            this.BtnBaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(23, 22);
            this.BtnBaja.Text = "Eliminar ";
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.Image = global::Gestion.Properties.Resources.modificar;
            this.BtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(23, 22);
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnDeshacer
            // 
            this.BtnDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDeshacer.Image = global::Gestion.Properties.Resources.cancelar;
            this.BtnDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeshacer.Name = "BtnDeshacer";
            this.BtnDeshacer.Size = new System.Drawing.Size(23, 22);
            this.BtnDeshacer.Text = "Deshacer";
            this.BtnDeshacer.Click += new System.EventHandler(this.BtnDeshacer_Click);
            // 
            // TipoLibros
            // 
            this.TipoLibros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoLibros.FormattingEnabled = true;
            this.TipoLibros.Location = new System.Drawing.Point(107, 230);
            this.TipoLibros.Name = "TipoLibros";
            this.TipoLibros.Size = new System.Drawing.Size(121, 21);
            this.TipoLibros.TabIndex = 4;
            // 
            // Autores
            // 
            this.Autores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Autores.FormattingEnabled = true;
            this.Autores.Location = new System.Drawing.Point(107, 192);
            this.Autores.Name = "Autores";
            this.Autores.Size = new System.Drawing.Size(121, 21);
            this.Autores.TabIndex = 3;
            // 
            // Isbn
            // 
            this.Isbn.Ingreso = "0";
            this.Isbn.Location = new System.Drawing.Point(105, 48);
            this.Isbn.Name = "Isbn";
            this.Isbn.Size = new System.Drawing.Size(214, 27);
            this.Isbn.TabIndex = 0;
            this.Isbn.Validating += new System.ComponentModel.CancelEventHandler(this.Isbn_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // RTxtReseña
            // 
            this.RTxtReseña.Location = new System.Drawing.Point(107, 124);
            this.RTxtReseña.Name = "RTxtReseña";
            this.RTxtReseña.Size = new System.Drawing.Size(209, 54);
            this.RTxtReseña.TabIndex = 2;
            this.RTxtReseña.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Libro";
            // 
            // BarraEstado
            // 
            this.BarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblError});
            this.BarraEstado.Location = new System.Drawing.Point(0, 284);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(360, 22);
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
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(360, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FrmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 306);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RTxtReseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Isbn);
            this.Controls.Add(this.Autores);
            this.Controls.Add(this.TipoLibros);
            this.Controls.Add(this.BarraHerramientas);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Libros";
            this.Load += new System.EventHandler(this.FrmLibros_Load);
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ToolStrip BarraHerramientas;
        private Controles.CBTipo TipoLibros;
        private Controles.CbAutor Autores;
        private Controles.TextBoxSoloNumeros Isbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTxtReseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton BtnAlta;
        private System.Windows.Forms.ToolStripButton BtnBaja;
        private System.Windows.Forms.ToolStripButton BtnModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip BarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel LblError;
        private System.Windows.Forms.Timer Cronometro;
        private System.Windows.Forms.ToolStripButton BtnDeshacer;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}