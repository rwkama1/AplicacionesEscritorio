namespace Gestion
{
    partial class FrmMuestraControles
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
            this.DtpFechaLarga = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnModifico = new System.Windows.Forms.Button();
            this.DtpFechaAMedida = new System.Windows.Forms.DateTimePicker();
            this.DtpHora = new System.Windows.Forms.DateTimePicker();
            this.DialogoColor = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtMuestra = new System.Windows.Forms.TextBox();
            this.BtnMuestra = new System.Windows.Forms.Button();
            this.BtnInvoco = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.DgvTipos = new System.Windows.Forms.DataGridView();
            this.LbAutores = new System.Windows.Forms.ListBox();
            this.EPMisErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPMisErrores)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtpFechaLarga
            // 
            this.DtpFechaLarga.Location = new System.Drawing.Point(6, 19);
            this.DtpFechaLarga.Name = "DtpFechaLarga";
            this.DtpFechaLarga.Size = new System.Drawing.Size(208, 20);
            this.DtpFechaLarga.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnModifico);
            this.groupBox1.Controls.Add(this.DtpFechaAMedida);
            this.groupBox1.Controls.Add(this.DtpHora);
            this.groupBox1.Controls.Add(this.DtpFechaLarga);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manejo de DateTime";
            // 
            // BtnModifico
            // 
            this.BtnModifico.Location = new System.Drawing.Point(34, 45);
            this.BtnModifico.Name = "BtnModifico";
            this.BtnModifico.Size = new System.Drawing.Size(112, 23);
            this.BtnModifico.TabIndex = 5;
            this.BtnModifico.Text = "Modificar Años";
            this.BtnModifico.UseVisualStyleBackColor = true;
            this.BtnModifico.Click += new System.EventHandler(this.BtnMuestra_Click);
            // 
            // DtpFechaAMedida
            // 
            this.DtpFechaAMedida.CustomFormat = "dd * MM * yy";
            this.DtpFechaAMedida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaAMedida.Location = new System.Drawing.Point(221, 19);
            this.DtpFechaAMedida.Name = "DtpFechaAMedida";
            this.DtpFechaAMedida.Size = new System.Drawing.Size(137, 20);
            this.DtpFechaAMedida.TabIndex = 3;
            // 
            // DtpHora
            // 
            this.DtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpHora.Location = new System.Drawing.Point(221, 45);
            this.DtpHora.Name = "DtpHora";
            this.DtpHora.ShowUpDown = true;
            this.DtpHora.Size = new System.Drawing.Size(137, 20);
            this.DtpHora.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtMuestra);
            this.groupBox2.Controls.Add(this.BtnMuestra);
            this.groupBox2.Controls.Add(this.BtnInvoco);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 84);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuadro de Dialogo";
            // 
            // TxtMuestra
            // 
            this.TxtMuestra.Location = new System.Drawing.Point(243, 48);
            this.TxtMuestra.Name = "TxtMuestra";
            this.TxtMuestra.Size = new System.Drawing.Size(112, 20);
            this.TxtMuestra.TabIndex = 7;
            this.TxtMuestra.Text = "Muestra";
            // 
            // BtnMuestra
            // 
            this.BtnMuestra.Location = new System.Drawing.Point(243, 19);
            this.BtnMuestra.Name = "BtnMuestra";
            this.BtnMuestra.Size = new System.Drawing.Size(112, 23);
            this.BtnMuestra.TabIndex = 6;
            this.BtnMuestra.Text = "Muestra";
            this.BtnMuestra.UseVisualStyleBackColor = true;
            // 
            // BtnInvoco
            // 
            this.BtnInvoco.Location = new System.Drawing.Point(23, 29);
            this.BtnInvoco.Name = "BtnInvoco";
            this.BtnInvoco.Size = new System.Drawing.Size(112, 23);
            this.BtnInvoco.TabIndex = 5;
            this.BtnInvoco.Text = "Abrir Dialogo";
            this.BtnInvoco.UseVisualStyleBackColor = true;
            this.BtnInvoco.Click += new System.EventHandler(this.BtnInvoco_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnMostrar);
            this.groupBox3.Controls.Add(this.BtnCargar);
            this.groupBox3.Controls.Add(this.DgvTipos);
            this.groupBox3.Controls.Add(this.LbAutores);
            this.groupBox3.Location = new System.Drawing.Point(393, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 241);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manejo de listas con Colecciones de Objetos";
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(225, 201);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(118, 23);
            this.BtnMostrar.TabIndex = 8;
            this.BtnMostrar.Text = "Mostrar Selecciones";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(19, 201);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(112, 23);
            this.BtnCargar.TabIndex = 7;
            this.BtnCargar.Text = "Cargar Datos";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // DgvTipos
            // 
            this.DgvTipos.AllowUserToAddRows = false;
            this.DgvTipos.AllowUserToDeleteRows = false;
            this.DgvTipos.AllowUserToResizeColumns = false;
            this.DgvTipos.AllowUserToResizeRows = false;
            this.DgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTipos.Location = new System.Drawing.Point(19, 97);
            this.DgvTipos.Name = "DgvTipos";
            this.DgvTipos.Size = new System.Drawing.Size(362, 78);
            this.DgvTipos.TabIndex = 1;
            // 
            // LbAutores
            // 
            this.LbAutores.FormattingEnabled = true;
            this.LbAutores.Location = new System.Drawing.Point(19, 20);
            this.LbAutores.Name = "LbAutores";
            this.LbAutores.Size = new System.Drawing.Size(362, 69);
            this.LbAutores.TabIndex = 0;
            // 
            // EPMisErrores
            // 
            this.EPMisErrores.ContainerControl = this;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.TxtNumero);
            this.groupBox4.Location = new System.Drawing.Point(12, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(373, 76);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manejo de ErrorProvider";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Solo Numeros";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(115, 29);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(129, 20);
            this.TxtNumero.TabIndex = 7;
            this.TxtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNumero_Validating);
            // 
            // FrmMuestraControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 297);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMuestraControles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muestra de controles Varios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPMisErrores)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpFechaLarga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog DialogoColor;
        private System.Windows.Forms.DateTimePicker DtpFechaAMedida;
        private System.Windows.Forms.DateTimePicker DtpHora;
        private System.Windows.Forms.Button BtnModifico;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtMuestra;
        private System.Windows.Forms.Button BtnMuestra;
        private System.Windows.Forms.Button BtnInvoco;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox LbAutores;
        private System.Windows.Forms.DataGridView DgvTipos;
        private System.Windows.Forms.ErrorProvider EPMisErrores;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button BtnMostrar;
    }
}