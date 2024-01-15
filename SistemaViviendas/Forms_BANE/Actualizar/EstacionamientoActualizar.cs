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
    public partial class EstacionamientoActualizar : Form
    {
        private int clave;
        public EstacionamientoActualizar()
        {
            InitializeComponent(); 
            CB_departamento();
        }

        private void CB_departamento()
        {
            try
            {
                DataTable res = Departamento.GetDepartamentoCB();

                if (res == null)
                {
                    btn_accion.Enabled = false;
                    return;
                }
                    


                cb_departamento.DataSource = res;
                cb_departamento.ValueMember = "clave";
                cb_departamento.DisplayMember = "texto";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error con la base de datos: " + ex.Message, "Error de Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Estacionamiento res;

            if (cb_departamento.SelectedValue != null)
                ValidacionEntradas.LimpiarCampos(cb_departamento);

            if (!ValidacionEntradas.ValidarEntradasNumero(true, tb_buscar))
            {
                MessageBox.Show("El identificador debe ser un numero entero", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clave = int.Parse(tb_buscar.Text);

            try
            {
                res = Estacionamiento.GetEstacionamiento(clave);

                if (res != null)
                {
                    panel1.Enabled = true;
                    cb_departamento.SelectedValue = res.NoDepto;
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
            if (!ValidacionEntradas.ValidarEntradasTexto(cb_departamento))
            {
                MessageBox.Show("El identificador debe ser un numero entero", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int noDepto = (int)cb_departamento.SelectedValue;

            try
            {
                if (Estacionamiento.UpdateEstacionamientoData(clave, noDepto))
                {
                    MessageBox.Show("El departamento se actualizo con exito", "Actualizacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if (cb_departamento.SelectedValue != null)
                        ValidacionEntradas.LimpiarCampos(cb_departamento);

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
    }
}
