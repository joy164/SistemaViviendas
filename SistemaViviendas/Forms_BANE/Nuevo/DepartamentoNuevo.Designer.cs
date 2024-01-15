namespace SistemaViviendas.Forms_BANE.Nuevo
{
    partial class DepartamentoNuevo
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_accion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NUD_noBaños = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_noRecamaras = new System.Windows.Forms.NumericUpDown();
            this.NUD_noPiso = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_inquilino = new System.Windows.Forms.ComboBox();
            this.tb_noIntDepto = new System.Windows.Forms.TextBox();
            this.cb_unidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_noBaños)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_noRecamaras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_noPiso)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(25, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "* Estos campos son obligatorios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nuevo departamento";
            // 
            // btn_accion
            // 
            this.btn_accion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_accion.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_accion.FlatAppearance.BorderSize = 0;
            this.btn_accion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accion.ForeColor = System.Drawing.Color.White;
            this.btn_accion.Image = global::SistemaViviendas.Properties.Resources.guardar_icon;
            this.btn_accion.Location = new System.Drawing.Point(536, 404);
            this.btn_accion.Name = "btn_accion";
            this.btn_accion.Size = new System.Drawing.Size(121, 44);
            this.btn_accion.TabIndex = 20;
            this.btn_accion.Text = "Guardar";
            this.btn_accion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_accion.UseVisualStyleBackColor = false;
            this.btn_accion.Click += new System.EventHandler(this.btn_accion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "No. de piso";
            // 
            // NUD_noBaños
            // 
            this.NUD_noBaños.BackColor = System.Drawing.SystemColors.Window;
            this.NUD_noBaños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_noBaños.Location = new System.Drawing.Point(243, 77);
            this.NUD_noBaños.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUD_noBaños.Name = "NUD_noBaños";
            this.NUD_noBaños.Size = new System.Drawing.Size(194, 22);
            this.NUD_noBaños.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "No. de baños *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "No. de recamaras *";
            // 
            // NUD_noRecamaras
            // 
            this.NUD_noRecamaras.BackColor = System.Drawing.SystemColors.Window;
            this.NUD_noRecamaras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_noRecamaras.Location = new System.Drawing.Point(28, 78);
            this.NUD_noRecamaras.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUD_noRecamaras.Name = "NUD_noRecamaras";
            this.NUD_noRecamaras.Size = new System.Drawing.Size(194, 22);
            this.NUD_noRecamaras.TabIndex = 23;
            // 
            // NUD_noPiso
            // 
            this.NUD_noPiso.BackColor = System.Drawing.SystemColors.Window;
            this.NUD_noPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_noPiso.Location = new System.Drawing.Point(463, 78);
            this.NUD_noPiso.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUD_noPiso.Name = "NUD_noPiso";
            this.NUD_noPiso.Size = new System.Drawing.Size(194, 22);
            this.NUD_noPiso.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Inquilino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Unidad habitacional *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "No. interior de departamento*";
            // 
            // cb_inquilino
            // 
            this.cb_inquilino.FormattingEnabled = true;
            this.cb_inquilino.Location = new System.Drawing.Point(463, 147);
            this.cb_inquilino.Name = "cb_inquilino";
            this.cb_inquilino.Size = new System.Drawing.Size(194, 21);
            this.cb_inquilino.TabIndex = 29;
            // 
            // tb_noIntDepto
            // 
            this.tb_noIntDepto.Location = new System.Drawing.Point(28, 148);
            this.tb_noIntDepto.Name = "tb_noIntDepto";
            this.tb_noIntDepto.Size = new System.Drawing.Size(194, 20);
            this.tb_noIntDepto.TabIndex = 30;
            // 
            // cb_unidad
            // 
            this.cb_unidad.FormattingEnabled = true;
            this.cb_unidad.Location = new System.Drawing.Point(243, 147);
            this.cb_unidad.Name = "cb_unidad";
            this.cb_unidad.Size = new System.Drawing.Size(194, 21);
            this.cb_unidad.TabIndex = 31;
            // 
            // DepartamentoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 460);
            this.Controls.Add(this.cb_unidad);
            this.Controls.Add(this.tb_noIntDepto);
            this.Controls.Add(this.cb_inquilino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NUD_noPiso);
            this.Controls.Add(this.NUD_noRecamaras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_accion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NUD_noBaños);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepartamentoNuevo";
            this.Text = "DepartamentoNuevo";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_noBaños)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_noRecamaras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_noPiso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_accion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUD_noBaños;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_noRecamaras;
        private System.Windows.Forms.NumericUpDown NUD_noPiso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_inquilino;
        private System.Windows.Forms.TextBox tb_noIntDepto;
        private System.Windows.Forms.ComboBox cb_unidad;
    }
}