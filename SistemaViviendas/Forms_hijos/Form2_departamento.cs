using SistemaViviendas.Forms_BANE.Actualizar;
using SistemaViviendas.Forms_BANE.Buscar;
using SistemaViviendas.Forms_BANE.Eliminar;
using SistemaViviendas.Forms_BANE.Nuevo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaViviendas.Forms_hijos
{
    public partial class Form2_departamento : Form
    {
        private Form currentChildForm;
        private Button btnActivo;

        public Form2_departamento()
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
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            ActivarBoton(btn_nuevo);
            OpenChildForm(new DepartamentoNuevo());
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            ActivarBoton(btn_buscar);
            OpenChildForm(new DepartamentoBuscar());
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            ActivarBoton(btn_actualizar);
            OpenChildForm(new DepartamentoActualizar());
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ActivarBoton(btn_eliminar);
            OpenChildForm(new DepartamentoEliminar());
        }
    }
}
