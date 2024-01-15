namespace SistemaViviendas.Forms_BANE.Eliminar
{
    partial class DepartamentoEliminar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_accion = new System.Windows.Forms.Button();
            this.cb_unidad = new System.Windows.Forms.ComboBox();
            this.tb_noIntDepto = new System.Windows.Forms.TextBox();
            this.cb_inquilino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NUD_noPiso = new System.Windows.Forms.NumericUpDown();
            this.NUD_noRecamaras = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NUD_noBaños = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.tb_buscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_noPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_noRecamaras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_noBaños)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_accion);
            this.panel1.Controls.Add(this.cb_unidad);
            this.panel1.Controls.Add(this.tb_noIntDepto);
            this.panel1.Controls.Add(this.cb_inquilino);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.NUD_noPiso);
            this.panel1.Controls.Add(this.NUD_noRecamaras);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NUD_noBaños);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(11, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 340);
            this.panel1.TabIndex = 43;
            // 
            // btn_accion
            // 
            this.btn_accion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_accion.BackColor = System.Drawing.Color.DarkRed;
            this.btn_accion.FlatAppearance.BorderSize = 0;
            this.btn_accion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accion.ForeColor = System.Drawing.Color.White;
            this.btn_accion.Image = global::SistemaViviendas.Properties.Resources.borrar_icon;
            this.btn_accion.Location = new System.Drawing.Point(524, 287);
            this.btn_accion.Name = "btn_accion";
            this.btn_accion.Size = new System.Drawing.Size(121, 44);
            this.btn_accion.TabIndex = 47;
            this.btn_accion.Text = "Eliminar";
            this.btn_accion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_accion.UseVisualStyleBackColor = false;
            this.btn_accion.Click += new System.EventHandler(this.btn_accion_Click);
            // 
            // cb_unidad
            // 
            this.cb_unidad.Enabled = false;
            this.cb_unidad.FormattingEnabled = true;
            this.cb_unidad.Location = new System.Drawing.Point(231, 106);
            this.cb_unidad.Name = "cb_unidad";
            this.cb_unidad.Size = new System.Drawing.Size(194, 21);
            this.cb_unidad.TabIndex = 72;
            // 
            // tb_noIntDepto
            // 
            this.tb_noIntDepto.Enabled = false;
            this.tb_noIntDepto.Location = new System.Drawing.Point(16, 107);
            this.tb_noIntDepto.Name = "tb_noIntDepto";
            this.tb_noIntDepto.Size = new System.Drawing.Size(194, 20);
            this.tb_noIntDepto.TabIndex = 71;
            // 
            // cb_inquilino
            // 
            this.cb_inquilino.Enabled = false;
            this.cb_inquilino.FormattingEnabled = true;
            this.cb_inquilino.Location = new System.Drawing.Point(451, 106);
            this.cb_inquilino.Name = "cb_inquilino";
            this.cb_inquilino.Size = new System.Drawing.Size(194, 21);
            this.cb_inquilino.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Inquilino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "Unidad habitacional *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 16);
            this.label8.TabIndex = 67;
            this.label8.Text = "No. interior de departamento*";
            // 
            // NUD_noPiso
            // 
            this.NUD_noPiso.BackColor = System.Drawing.SystemColors.Window;
            this.NUD_noPiso.Enabled = false;
            this.NUD_noPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_noPiso.Location = new System.Drawing.Point(451, 36);
            this.NUD_noPiso.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUD_noPiso.Name = "NUD_noPiso";
            this.NUD_noPiso.Size = new System.Drawing.Size(194, 22);
            this.NUD_noPiso.TabIndex = 66;
            // 
            // NUD_noRecamaras
            // 
            this.NUD_noRecamaras.BackColor = System.Drawing.SystemColors.Window;
            this.NUD_noRecamaras.Enabled = false;
            this.NUD_noRecamaras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_noRecamaras.Location = new System.Drawing.Point(16, 36);
            this.NUD_noRecamaras.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUD_noRecamaras.Name = "NUD_noRecamaras";
            this.NUD_noRecamaras.Size = new System.Drawing.Size(194, 22);
            this.NUD_noRecamaras.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(13, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "* Estos campos son obligatorios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "No. de piso";
            // 
            // NUD_noBaños
            // 
            this.NUD_noBaños.BackColor = System.Drawing.SystemColors.Window;
            this.NUD_noBaños.Enabled = false;
            this.NUD_noBaños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_noBaños.Location = new System.Drawing.Point(231, 35);
            this.NUD_noBaños.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUD_noBaños.Name = "NUD_noBaños";
            this.NUD_noBaños.Size = new System.Drawing.Size(194, 22);
            this.NUD_noBaños.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "No. de baños *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "No. de recamaras *";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Image = global::SistemaViviendas.Properties.Resources.busqueda;
            this.btn_buscar.Location = new System.Drawing.Point(274, 58);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(83, 34);
            this.btn_buscar.TabIndex = 46;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // tb_buscar
            // 
            this.tb_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_buscar.Location = new System.Drawing.Point(127, 64);
            this.tb_buscar.Name = "tb_buscar";
            this.tb_buscar.Size = new System.Drawing.Size(141, 22);
            this.tb_buscar.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Clave de depto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Eliminar departamento";
            // 
            // DepartamentoEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.tb_buscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepartamentoEliminar";
            this.Text = "DepartamentoEliminar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_noPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_noRecamaras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_noBaños)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_unidad;
        private System.Windows.Forms.TextBox tb_noIntDepto;
        private System.Windows.Forms.ComboBox cb_inquilino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NUD_noPiso;
        private System.Windows.Forms.NumericUpDown NUD_noRecamaras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUD_noBaños;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox tb_buscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_accion;
    }
}