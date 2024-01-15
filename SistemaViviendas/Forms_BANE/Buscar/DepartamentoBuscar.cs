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

namespace SistemaViviendas.Forms_BANE.Buscar
{
    public partial class DepartamentoBuscar : Form
    {
        public DepartamentoBuscar()
        {
            InitializeComponent();
            CB_inquilino();
            CB_unidad();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Departamento res;

            if(cb_inquilino.SelectedValue == null)
                ValidacionEntradas.LimpiarCampos(NUD_noRecamaras, NUD_noBaños, NUD_noPiso, tb_noIntDepto, cb_unidad);
            else
                ValidacionEntradas.LimpiarCampos(NUD_noRecamaras, NUD_noBaños, NUD_noPiso, tb_noIntDepto, cb_unidad, cb_inquilino);

            if (!ValidacionEntradas.ValidarEntradasNumero(true, tb_buscar))
            {
                MessageBox.Show("El identificador debe ser un numero entero", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int noDepto = int.Parse(tb_buscar.Text);

            try
            {
                res = Departamento.GetDepartamento(noDepto);

                if (res != null)
                {
                    NUD_noRecamaras.Value = res.NoRecamaras;
                    NUD_noBaños.Value = res.NoBaños;
                    NUD_noPiso.Value = res.NoPiso;
                    tb_noIntDepto.Text = res.NumeroDpto;
                    cb_unidad.SelectedValue = res.CveUnidad;

                    if (cb_inquilino.SelectedValue != null)
                        cb_inquilino.SelectedValue = res.NoInquilino;
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

                if (res == null)
                    return;
                

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
