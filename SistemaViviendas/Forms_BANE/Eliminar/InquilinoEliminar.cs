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
    public partial class InquilinoEliminar : Form
    {
        private int clave;
        public InquilinoEliminar()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Inquilino res;

            ValidacionEntradas.LimpiarCampos(tb_rfc, tb_nom, tb_correo, tb_tel);

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
                    tb_rfc.Text = res.RFC;
                    tb_nom.Text = res.Nombre;
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
            DialogResult res = MessageBox.Show("¿Esta seguro que quiere eliminar este registro?", "Eliminando registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) return;

            try
            {
                if (Inquilino.DeleteInquilino(clave))
                {
                    MessageBox.Show("El departamento se elimino con exito", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ValidacionEntradas.LimpiarCampos(tb_rfc, tb_nom, tb_correo, tb_tel);
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
