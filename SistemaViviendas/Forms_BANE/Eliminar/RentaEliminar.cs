﻿using SistemaViviendas.Clases.Entidades;
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
    public partial class RentaEliminar : Form
    {
        private int clave;
        public RentaEliminar()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Renta res;

            if (cb_departamento.SelectedValue == null)
                ValidacionEntradas.LimpiarCampos(tb_formaPago, tb_mensualidad, tb_pagoRealizado);
            else
                ValidacionEntradas.LimpiarCampos(tb_formaPago, tb_mensualidad, tb_pagoRealizado, cb_departamento);

            if (!ValidacionEntradas.ValidarEntradasNumero(true, tb_buscar))
            {
                MessageBox.Show("El identificador debe ser un numero entero", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clave = int.Parse(tb_buscar.Text);

            try
            {
                res = Renta.GetRenta(clave);

                if (res != null)
                {
                    panel1.Enabled = true;
                    dtp_fechaPago.Value = res.FechaPago;
                    tb_formaPago.Text = res.FormaPago;
                    tb_mensualidad.Text = res.Mensualidad.ToString();
                    tb_pagoRealizado.Text = res.PagoRealizado.ToString();
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
                if (Renta.DeleteRenta(clave))
                {
                    MessageBox.Show("El departamento se elimino con exito", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (cb_departamento.SelectedValue == null)
                        ValidacionEntradas.LimpiarCampos(tb_formaPago, tb_mensualidad, tb_pagoRealizado);
                    else
                        ValidacionEntradas.LimpiarCampos(tb_formaPago, tb_mensualidad, tb_pagoRealizado, cb_departamento);

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
