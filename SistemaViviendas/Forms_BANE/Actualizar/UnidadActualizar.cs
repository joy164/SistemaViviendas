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
    public partial class UnidadActualizar : Form
    {
        private int noUnidad;
        public UnidadActualizar()
        {
            InitializeComponent();
            LlenarCB();
        }

        private void LlenarCB()
        {
            string[] clave = {null, "L", "R", "E" };
            string[] texto = {"No seleccionado", "Unidades de lujo", "Unidades regulares", "Unidades economicas" };

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("clave", typeof(char));
            dataTable.Columns.Add("texto", typeof(string));

            for (int i = 0; i < texto.Length; i++)
                dataTable.Rows.Add(clave[i], texto[i]);

            cb_tipoUnidad.DataSource = dataTable;
            cb_tipoUnidad.ValueMember = "clave";
            cb_tipoUnidad.DisplayMember = "texto";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Unidad res;

            ValidacionEntradas.LimpiarCampos(tb_nomUnidad, NUD_noDeptos, cb_tipoUnidad, tb_dirUnidad);

            if (!ValidacionEntradas.ValidarEntradasNumero(true, tb_buscar))
            {
                MessageBox.Show("El identificador debe ser un numero entero", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            noUnidad = int.Parse(tb_buscar.Text);
            tb_buscar.Text = string.Empty;

            try
            {
                res = Unidad.GetUnidad(noUnidad);

                if (res != null)
                {
                    panel1.Enabled = true;
                    tb_nomUnidad.Text = res.Nommbre;
                    NUD_noDeptos.Value = res.NumeroDeptos;
                    cb_tipoUnidad.SelectedValue = res.Tipo;
                    tb_dirUnidad.Text = res.Direccion;
                }
                else
                    MessageBox.Show("Ocurrio un error inesperado, revise la conexion a internet e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error con la base de datos: " + ex.Message, "Error de Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tb_buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Unidad res;

                ValidacionEntradas.LimpiarCampos(tb_nomUnidad, NUD_noDeptos, cb_tipoUnidad, tb_dirUnidad);

                if (!ValidacionEntradas.ValidarEntradasNumero(true, tb_buscar))
                {
                    MessageBox.Show("El identificador debe ser un numero entero", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                noUnidad = int.Parse(tb_buscar.Text);
                tb_buscar.Text = string.Empty;

                try
                {
                    res = Unidad.GetUnidad(noUnidad);

                    if (res != null)
                    {
                        panel1.Enabled = true;
                        tb_nomUnidad.Text = res.Nommbre;
                        NUD_noDeptos.Value = res.NumeroDeptos;
                        cb_tipoUnidad.SelectedValue = res.Tipo;
                        tb_dirUnidad.Text = res.Direccion;
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

        private void btn_accion_Click(object sender, EventArgs e)
        {
            if (!ValidacionEntradas.ValidarEntradasTexto(tb_nomUnidad, NUD_noDeptos, cb_tipoUnidad, tb_dirUnidad))
            {
                MessageBox.Show("Error en los campos marcados, por favor revise que sus datos o seleccion sea correcta", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nomUnidad = tb_nomUnidad.Text;
            int noDeptos = (int)NUD_noDeptos.Value;
            char tipoUnidad = cb_tipoUnidad.SelectedValue.ToString()[0];
            string dirUnidad = tb_dirUnidad.Text;

            try
            {
                if (Unidad.UpdateUnidadData(noUnidad, nomUnidad, dirUnidad, noDeptos, tipoUnidad))
                {
                    MessageBox.Show("La unidad habitacional se actualizo con exito", "Actualizacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ValidacionEntradas.LimpiarCampos(tb_nomUnidad, NUD_noDeptos, cb_tipoUnidad, tb_dirUnidad);
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
