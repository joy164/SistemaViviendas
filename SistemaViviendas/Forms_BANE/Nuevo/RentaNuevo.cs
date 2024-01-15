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
    public partial class RentaNuevo : Form
    {
        public RentaNuevo()
        {
            InitializeComponent();
            CB_departamento();
        }

        private void btn_accion_Click(object sender, EventArgs e)
        {
            if (!ValidacionEntradas.ValidarEntradasTexto(tb_formaPago, cb_departamento) || !ValidacionEntradas.ValidarEntradasNumero(false, tb_mensualidad, tb_pagoRealizado))
            {
                MessageBox.Show("Error en los campos marcados, por favor revise que sus datos o seleccion sea correcta", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime fechaPago = dtp_fechaPago.Value;
            string formaPago = tb_formaPago.Text;
            float pagoRealizado = float.Parse(tb_pagoRealizado.Text);
            float mensualidad = float.Parse(tb_mensualidad.Text);
            int departamento = (int)cb_departamento.SelectedValue;
            
            try
            {
                if (Renta.NewRenta(fechaPago, formaPago, pagoRealizado, mensualidad, departamento))
                {
                    MessageBox.Show("La renta se registro con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ValidacionEntradas.LimpiarCampos(tb_formaPago, tb_pagoRealizado, tb_mensualidad, cb_departamento);
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
