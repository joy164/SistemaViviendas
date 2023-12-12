using SistemaViviendas.Forms_hijos;
using System.Windows.Forms;
using System.Drawing;
using System;
using SistemaViviendas.Clases.Entidades;

namespace SistemaViviendas
{
    public partial class Form_menuPrincipal : Form
    {
        private Form currentChildForm;
        private Button btnActivo = null;
        private readonly Color colorBoton = Color.FromArgb(3, 21, 32);
        
        public Form_menuPrincipal(string nom)
        {
            InitializeComponent();
            label1.Text += string.Format(" {0}", nom) ;
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
            Text = childForm.Text;
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
        
        private void btn_unidad_Click(object sender, EventArgs e)
        {
            ActivarBoton(btn_unidad);
            OpenChildForm(new Form1_unidad());
        }

        private void btn_departamento_Click(object sender, EventArgs e)
        {
            ActivarBoton(btn_departamento);
            OpenChildForm(new Form2_departamento());
        }

        private void btn_estacionamiento_Click(object sender, EventArgs e)
        {
            ActivarBoton(btn_estacionamiento);
            OpenChildForm(new Form3_estacionamiento());
        }

        private void btn_renta_Click(object sender, EventArgs e)
        {
            ActivarBoton(btn_renta);
            OpenChildForm(new Form4_renta());
        }

        private void btn_inquilino_Click(object sender, EventArgs e)
        {
            ActivarBoton(btn_inquilino);
            OpenChildForm(new Form5_inquilino());
        }

        private void btn_caractDepto_Click(object sender, EventArgs e)
        {
            ActivarBoton(btn_caractDepto);
            OpenChildForm(new Form6_caractDepto());
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Esta seguro que quiere cerrar sesion?", "Precaucion", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
                Close();
        }
    }
}
