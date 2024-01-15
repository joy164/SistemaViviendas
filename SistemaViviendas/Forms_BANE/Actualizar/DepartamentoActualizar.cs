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

namespace SistemaViviendas.Forms_BANE.Actualizar
{
    public partial class DepartamentoActualizar : Form
    {
        private int noDepto;
        public DepartamentoActualizar()
        {
            InitializeComponent();
            CB_inquilino();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Departamento res;

            if (cb_inquilino.SelectedValue != null)
                ValidacionEntradas.LimpiarCampos(cb_inquilino);

            if (!ValidacionEntradas.ValidarEntradasNumero(true, tb_buscar))
            {
                MessageBox.Show("El identificador debe ser un numero entero", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            noDepto = int.Parse(tb_buscar.Text);

            try
            {
                res = Departamento.GetDepartamento(noDepto);

                if (res != null)
                {
                    if (cb_inquilino.SelectedValue != null)
                    {
                        panel1.Enabled = true;
                        cb_inquilino.SelectedValue = res.NoInquilino;
                    }
                        
                }
                else
                    MessageBox.Show("Ocurrio un error inesperado, revise la conexion a internet e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error con la base de datos: " + ex.Message, "Error de Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_accion_Click(object sender, EventArgs e)
        {
            int noInquilino = cb_inquilino.SelectedValue == null ? 0 : (int)cb_inquilino.SelectedValue;

            try
            {
                if (Departamento.UpdateDepartamentoData(noDepto, noInquilino))
                {
                    MessageBox.Show("El departamento se actualizo con exito", "Actualizacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if (cb_inquilino.SelectedValue != null)
                        ValidacionEntradas.LimpiarCampos(cb_inquilino);

                    panel1.Enabled = false;
                }
                else
                    MessageBox.Show("Ocurrio un error inesperado, revise la conexion a internet e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                {
                    btn_accion.Enabled = false;
                    return;
                }
                
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
