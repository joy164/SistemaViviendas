using SistemaViviendas.Forms_BANE.Actualizar;
using SistemaViviendas.Forms_BANE.Eliminar;
using SistemaViviendas.Forms_BANE.Buscar;
using SistemaViviendas.Forms_BANE.Nuevo;
using System.Windows.Forms;
using System.Drawing;

namespace SistemaViviendas.Forms_hijos
{
    public partial class Form1_unidad : Form
    {
        private Form currentChildForm;
        private Button btnActivo;

        public Form1_unidad()
        {
            InitializeComponent();
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
                btnActivo.BackColor = Color.DarkSlateGray;
                btn.BackColor = Color.SteelBlue;
                btnActivo = btn;
            }
        }
        
        private void Form1_unidad_FormClosing(object sender, FormClosingEventArgs e)
        {
            currentChildForm?.Close();
        }

        private void btn_buscar_Click(object sender, System.EventArgs e)
        {
            ActivarBoton(btn_buscar);
            OpenChildForm(new UnidadBuscar());
        }

        private void btn_actualizar_Click(object sender, System.EventArgs e)
        {
            ActivarBoton(btn_actualizar);
            OpenChildForm(new UnidadActualizar());
        }

        private void btn_nuevo_Click(object sender, System.EventArgs e)
        {
            ActivarBoton(btn_nuevo);
            OpenChildForm(new UnidadNuevo());
        }

        private void btn_eliminar_Click(object sender, System.EventArgs e)
        {
            ActivarBoton(btn_eliminar);
            OpenChildForm(new UnidadEliminar());
        }
    }
}
