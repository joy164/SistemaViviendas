namespace SistemaViviendas.Forms_config
{
    partial class Forms_configPrincipal
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
            this.btn_terminar = new System.Windows.Forms.Button();
            this.btn_servidor = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btn_terminar);
            this.panel1.Controls.Add(this.btn_servidor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 313);
            this.panel1.TabIndex = 0;
            // 
            // btn_terminar
            // 
            this.btn_terminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_terminar.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_terminar.FlatAppearance.BorderSize = 0;
            this.btn_terminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_terminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_terminar.ForeColor = System.Drawing.Color.White;
            this.btn_terminar.Image = global::SistemaViviendas.Properties.Resources.guardar_icon;
            this.btn_terminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_terminar.Location = new System.Drawing.Point(0, 259);
            this.btn_terminar.Name = "btn_terminar";
            this.btn_terminar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_terminar.Size = new System.Drawing.Size(131, 54);
            this.btn_terminar.TabIndex = 2;
            this.btn_terminar.Text = "Terminar";
            this.btn_terminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_terminar.UseVisualStyleBackColor = false;
            this.btn_terminar.Click += new System.EventHandler(this.btn_terminar_Click);
            // 
            // btn_servidor
            // 
            this.btn_servidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_servidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btn_servidor.FlatAppearance.BorderSize = 0;
            this.btn_servidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_servidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_servidor.ForeColor = System.Drawing.Color.White;
            this.btn_servidor.Image = global::SistemaViviendas.Properties.Resources.base_de_datos;
            this.btn_servidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_servidor.Location = new System.Drawing.Point(0, 0);
            this.btn_servidor.Name = "btn_servidor";
            this.btn_servidor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_servidor.Size = new System.Drawing.Size(131, 54);
            this.btn_servidor.TabIndex = 1;
            this.btn_servidor.Text = "Servidor";
            this.btn_servidor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_servidor.UseVisualStyleBackColor = false;
            this.btn_servidor.Click += new System.EventHandler(this.btn_servidor_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(131, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(407, 313);
            this.panelDesktop.TabIndex = 1;
            // 
            // Forms_configPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 313);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Forms_configPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btn_servidor;
        private System.Windows.Forms.Button btn_terminar;
    }
}