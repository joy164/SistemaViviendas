﻿namespace SistemaViviendas.Forms_BANE.Eliminar
{
    partial class EstacionamientoEliminar
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
            this.tb_buscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NUD_numEstacionamiento = new System.Windows.Forms.NumericUpDown();
            this.cb_departamento = new System.Windows.Forms.ComboBox();
            this.tb_seccion = new System.Windows.Forms.TextBox();
            this.tb_nivel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_accion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_numEstacionamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_buscar
            // 
            this.tb_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_buscar.Location = new System.Drawing.Point(183, 76);
            this.tb_buscar.Name = "tb_buscar";
            this.tb_buscar.Size = new System.Drawing.Size(141, 22);
            this.tb_buscar.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Clave de estacionamiento:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_accion);
            this.panel1.Controls.Add(this.NUD_numEstacionamiento);
            this.panel1.Controls.Add(this.cb_departamento);
            this.panel1.Controls.Add(this.tb_seccion);
            this.panel1.Controls.Add(this.tb_nivel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(11, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 319);
            this.panel1.TabIndex = 53;
            // 
            // NUD_numEstacionamiento
            // 
            this.NUD_numEstacionamiento.Enabled = false;
            this.NUD_numEstacionamiento.Location = new System.Drawing.Point(451, 36);
            this.NUD_numEstacionamiento.Name = "NUD_numEstacionamiento";
            this.NUD_numEstacionamiento.Size = new System.Drawing.Size(194, 20);
            this.NUD_numEstacionamiento.TabIndex = 76;
            // 
            // cb_departamento
            // 
            this.cb_departamento.Enabled = false;
            this.cb_departamento.FormattingEnabled = true;
            this.cb_departamento.Location = new System.Drawing.Point(16, 103);
            this.cb_departamento.Name = "cb_departamento";
            this.cb_departamento.Size = new System.Drawing.Size(194, 21);
            this.cb_departamento.TabIndex = 75;
            // 
            // tb_seccion
            // 
            this.tb_seccion.Enabled = false;
            this.tb_seccion.Location = new System.Drawing.Point(231, 33);
            this.tb_seccion.Name = "tb_seccion";
            this.tb_seccion.Size = new System.Drawing.Size(194, 20);
            this.tb_seccion.TabIndex = 73;
            // 
            // tb_nivel
            // 
            this.tb_nivel.Enabled = false;
            this.tb_nivel.Location = new System.Drawing.Point(16, 33);
            this.tb_nivel.Name = "tb_nivel";
            this.tb_nivel.Size = new System.Drawing.Size(194, 20);
            this.tb_nivel.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 16);
            this.label8.TabIndex = 67;
            this.label8.Text = "Numero de departamento *";
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
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Numero *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "Seccion *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nivel *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Eliminar estacionamiento";
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
            this.btn_buscar.Location = new System.Drawing.Point(330, 70);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(83, 34);
            this.btn_buscar.TabIndex = 56;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
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
            this.btn_accion.Location = new System.Drawing.Point(532, 272);
            this.btn_accion.Name = "btn_accion";
            this.btn_accion.Size = new System.Drawing.Size(121, 44);
            this.btn_accion.TabIndex = 77;
            this.btn_accion.Text = "Eliminar";
            this.btn_accion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_accion.UseVisualStyleBackColor = false;
            this.btn_accion.Click += new System.EventHandler(this.btn_accion_Click);
            // 
            // EstacionamientoEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 460);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.tb_buscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstacionamientoEliminar";
            this.Text = "EstacionamientoEliminar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_numEstacionamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox tb_buscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown NUD_numEstacionamiento;
        private System.Windows.Forms.ComboBox cb_departamento;
        private System.Windows.Forms.TextBox tb_seccion;
        private System.Windows.Forms.TextBox tb_nivel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_accion;
    }
}