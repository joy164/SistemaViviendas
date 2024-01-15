using SistemaViviendas.Forms_hijos;
using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaViviendas.Properties;

namespace SistemaViviendas.Forms_config
{
    public partial class Forms_configPrincipal : Form
    {
        private Form currentChildForm;
        private Button btnActivo = null;
        private readonly Color colorBoton = Color.FromArgb(3, 21, 32);

        public Forms_configPrincipal()
        {
            InitializeComponent();
        }

        private void btn_servidor_Click(object sender, EventArgs e)
        {
            ActivarBoton(btn_servidor);
            OpenChildForm(new Forms_serverConf());
        }
        private void btn_terminar_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            Application.Restart();
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            currentChildForm?.Close();

            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void ActivarBoton(Button btn)
        {
            if (btnActivo == null)
            {
                btn.BackColor = Color.SteelBlue;
                btnActivo = btn;
            }
            else
            {
                btnActivo.BackColor = colorBoton;
                btn.BackColor = Color.SteelBlue;
                btnActivo = btn;
            }
        }

        

    }
}
