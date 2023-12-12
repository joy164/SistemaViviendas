namespace SistemaViviendas.Forms_BANE.Nuevo
{
    partial class UnidadNuevo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomUnidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dirUnidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NUD_noDeptos = new System.Windows.Forms.NumericUpDown();
            this.cb_tipoUnidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_accion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_noDeptos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de unidad *";
            // 
            // tb_nomUnidad
            // 
            this.tb_nomUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nomUnidad.Location = new System.Drawing.Point(22, 75);
            this.tb_nomUnidad.Name = "tb_nomUnidad";
            this.tb_nomUnidad.Size = new System.Drawing.Size(194, 22);
            this.tb_nomUnidad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. de departamentos *";
            // 
            // tb_dirUnidad
            // 
            this.tb_dirUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dirUnidad.Location = new System.Drawing.Point(22, 138);
            this.tb_dirUnidad.Multiline = true;
            this.tb_dirUnidad.Name = "tb_dirUnidad";
            this.tb_dirUnidad.Size = new System.Drawing.Size(629, 116);
            this.tb_dirUnidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ubicacion de unidad *";
            // 
            // NUD_noDeptos
            // 
            this.NUD_noDeptos.BackColor = System.Drawing.SystemColors.Window;
            this.NUD_noDeptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_noDeptos.Location = new System.Drawing.Point(237, 75);
            this.NUD_noDeptos.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUD_noDeptos.Name = "NUD_noDeptos";
            this.NUD_noDeptos.Size = new System.Drawing.Size(194, 22);
            this.NUD_noDeptos.TabIndex = 6;
            // 
            // cb_tipoUnidad
            // 
            this.cb_tipoUnidad.FormattingEnabled = true;
            this.cb_tipoUnidad.Location = new System.Drawing.Point(457, 76);
            this.cb_tipoUnidad.Name = "cb_tipoUnidad";
            this.cb_tipoUnidad.Size = new System.Drawing.Size(194, 21);
            this.cb_tipoUnidad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de unidad *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nueva Unidad habitacional";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(19, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "* Estos campos son obligatorios";
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
            this.btn_accion.Location = new System.Drawing.Point(530, 404);
            this.btn_accion.Name = "btn_accion";
            this.btn_accion.Size = new System.Drawing.Size(121, 44);
            this.btn_accion.TabIndex = 9;
            this.btn_accion.Text = "Guardar";
            this.btn_accion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_accion.UseVisualStyleBackColor = false;
            this.btn_accion.Click += new System.EventHandler(this.btn_accion_Click);
            // 
            // UnidadNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 460);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_accion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_tipoUnidad);
            this.Controls.Add(this.NUD_noDeptos);
            this.Controls.Add(this.tb_dirUnidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nomUnidad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnidadNuevo";
            this.Text = "UnidadNuevo";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_noDeptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomUnidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dirUnidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUD_noDeptos;
        private System.Windows.Forms.ComboBox cb_tipoUnidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_accion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}