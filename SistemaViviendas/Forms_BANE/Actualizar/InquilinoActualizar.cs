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

namespace SistemaViviendas.Forms_BANE.Actualizar
{
    public partial class InquilinoActualizar : Form
    {
        private int clave;
        public InquilinoActualizar()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Inquilino res;

            ValidacionEntradas.LimpiarCampos(tb_correo, tb_tel);

            if (!ValidacionEntradas.ValidarEntradasNumero(true, tb_buscar))
            {
                MessageBox.Show("El identificador debe ser un numero entero", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clave = int.Parse(tb_buscar.Text);

            try
            {
                res = Inquilino.GetInquilino(clave);

                if (res != null)
                {
                    panel1.Enabled = true;
                    tb_correo.Text = res.Correo;
                    tb_tel.Text = res.telefono;
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
            if (!ValidacionEntradas.ValidarEntradasTexto(tb_correo, tb_tel))
            {
                MessageBox.Show("Error en los campos marcados, por favor revise que sus datos o seleccion sea correcta", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string telefono = tb_tel.Text;
            string correo = tb_correo.Text;

            try
            {
                if (Inquilino.UpdateInquilinoData(clave, correo, telefono))
                {
                    MessageBox.Show("La unidad habitacional se actualizo con exito", "Actualizacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ValidacionEntradas.LimpiarCampos(tb_tel, tb_correo);
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
