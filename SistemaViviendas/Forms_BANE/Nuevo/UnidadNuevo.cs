using SistemaViviendas.Clases.Entidades;
using SistemaViviendas.Clases.Utils;
using System.Windows.Forms;
using System.Data;
using System;

namespace SistemaViviendas.Forms_BANE.Nuevo
{
    public partial class UnidadNuevo : Form
    {
        public UnidadNuevo()
        {
            InitializeComponent();
            LlenarCB();
            
        }
        private void LlenarCB()
        {
            string[] clave = { null, "L", "R", "E" };
            string[] texto = { "No seleccionado", "Unidades de lujo", "Unidades regulares", "Unidades economicas" };

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("clave", typeof(char));
            dataTable.Columns.Add("texto", typeof(string));

            for (int i = 0; i < texto.Length; i++)
                dataTable.Rows.Add(clave[i], texto[i]);

            cb_tipoUnidad.DataSource = dataTable;
            cb_tipoUnidad.ValueMember = "clave";
            cb_tipoUnidad.DisplayMember = "texto";
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
                if (Unidad.NewUnidad(nomUnidad, dirUnidad, noDeptos, tipoUnidad))
                {
                    MessageBox.Show("La unidad habitacional se registro con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ValidacionEntradas.LimpiarCampos(tb_nomUnidad, NUD_noDeptos, cb_tipoUnidad, tb_dirUnidad);
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
