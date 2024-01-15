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

namespace SistemaViviendas.Forms_BANE.Eliminar
{
    public partial class EstacionamientoEliminar : Form
    {
        private int clave;
        public EstacionamientoEliminar()
        {
            InitializeComponent();
            CB_departamento();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Estacionamiento res;

            if (cb_departamento.SelectedValue == null)
                ValidacionEntradas.LimpiarCampos(tb_nivel, tb_seccion, NUD_numEstacionamiento);
            else
                ValidacionEntradas.LimpiarCampos(tb_nivel, tb_seccion, NUD_numEstacionamiento, cb_departamento);

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
                    tb_nivel.Text = res.Nivel;
                    tb_seccion.Text = res.Seccion;
                    NUD_numEstacionamiento.Value = res.NoEstacionamiento;
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
            DialogResult res = MessageBox.Show("¿Esta seguro que quiere eliminar este registro?", "Eliminando registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) return;

            try
            {
                if (Estacionamiento.DeleteEstacionamiento(clave))
                {
                    MessageBox.Show("El departamento se elimino con exito", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (cb_departamento.SelectedValue == null)
                        ValidacionEntradas.LimpiarCampos(tb_nivel, tb_seccion, NUD_numEstacionamiento);
                    else
                        ValidacionEntradas.LimpiarCampos(tb_nivel, tb_seccion, NUD_numEstacionamiento, cb_departamento);

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
    }
}
