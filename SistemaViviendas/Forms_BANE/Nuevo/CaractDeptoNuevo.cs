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
    public partial class CaractDeptoNuevo : Form
    {
        public CaractDeptoNuevo()
        {
            InitializeComponent();
        }

        private void btn_accion_Click(object sender, EventArgs e)
        {
            if (!ValidacionEntradas.ValidarEntradasTexto(tb_nombre,tb_clave, tb_descripcion) || !ValidacionEntradas.ValidarEntradasNumero(false, tb_costoExtra))
            {
                MessageBox.Show("Error en los campos marcados, por favor revise que sus datos o seleccion sea correcta", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nom = tb_nombre.Text;
            float costoExtra = float.Parse(tb_costoExtra.Text);
            string clave = tb_clave.Text;
            string descripcion = tb_descripcion.Text;
            try
            {
                if (Caract_dpto.NewCaractDpto(nom, descripcion, clave, costoExtra))
                {
                    MessageBox.Show("El departamento se registro con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ValidacionEntradas.LimpiarCampos(tb_nombre, tb_costoExtra, tb_clave, tb_descripcion);
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
