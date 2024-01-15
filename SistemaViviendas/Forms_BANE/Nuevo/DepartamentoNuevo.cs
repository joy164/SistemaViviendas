using SistemaViviendas.Clases.Entidades;
using SistemaViviendas.Clases.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaViviendas.Forms_BANE.Nuevo
{
    public partial class DepartamentoNuevo : Form
    {
        public DepartamentoNuevo()
        {
            InitializeComponent();
            CB_inquilino();
            CB_unidad();

        }

        private void btn_accion_Click(object sender, EventArgs e)
        {
            if (!ValidacionEntradas.ValidarEntradasTexto(NUD_noRecamaras, NUD_noBaños, NUD_noPiso, tb_noIntDepto, cb_unidad))
            {
                MessageBox.Show("Error en los campos marcados, por favor revise que sus datos o seleccion sea correcta", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int noRecamaras = (int)NUD_noRecamaras.Value;
            int noBaños = (int)NUD_noBaños.Value;
            int noPiso = (int)NUD_noPiso.Value;
            string noInt = tb_noIntDepto.Text;
            int noUnidad = (int)cb_unidad.SelectedValue;
            int noInquilino = cb_inquilino.SelectedValue == null ? 0 : (int)cb_inquilino.SelectedValue;

            try
            {
                if (Departamento.NewDepartamento(noRecamaras, noBaños, noPiso, noInt, noUnidad, noInquilino))
                {
                    MessageBox.Show("El departamento se registro con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    if(cb_inquilino.SelectedValue == null)
                        ValidacionEntradas.LimpiarCampos(NUD_noRecamaras, NUD_noBaños, NUD_noPiso, tb_noIntDepto, cb_unidad);
                    else
                        ValidacionEntradas.LimpiarCampos(NUD_noRecamaras, NUD_noBaños, NUD_noPiso, tb_noIntDepto, cb_unidad, cb_inquilino);
                }
                else
                    MessageBox.Show("Ocurrio un error inesperado, revise la conexion a internet e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error con la base de datos: " + ex.Message, "Error de Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CB_unidad()
        {
            try
            {
                DataTable res = Unidad.GetUnidadesCB();
                
                if(res == null)
                {
                    btn_accion.Enabled = false;
                    return;
                }

                cb_unidad.DataSource = res;
                cb_unidad.ValueMember = "clave";
                cb_unidad.DisplayMember = "texto";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error con la base de datos: " + ex.Message, "Error de Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CB_inquilino()
        {
            try
            {
                DataTable res = Inquilino.GetInquilinoCB();

                if (res == null)
                    return;
                
                    
                

                cb_inquilino.DataSource = res;
                cb_inquilino.ValueMember = "clave";
                cb_inquilino.DisplayMember = "texto";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error con la base de datos: " + ex.Message, "Error de Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
