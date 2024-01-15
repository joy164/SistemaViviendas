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

namespace SistemaViviendas.Forms_BANE.Buscar
{
    public partial class CaractDeptoBuscar : Form
    {
        private int clave;
        public CaractDeptoBuscar()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Caract_dpto res;

            ValidacionEntradas.LimpiarCampos(tb_nombre, tb_costoExtra, tb_clave, tb_descripcion);

            if (!ValidacionEntradas.ValidarEntradasNumero(true, tb_buscar))
            {
                MessageBox.Show("El identificador debe ser un numero entero", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clave = int.Parse(tb_buscar.Text);

            try
            {
                res = Caract_dpto.GetCaractDpto(clave);

                if (res != null)
                {
                    tb_nombre.Text = res.Nombre;
                    tb_costoExtra.Text = res.CostoExtra.ToString();
                    tb_clave.Text = res.Clave;
                    tb_descripcion.Text = res.Descripcion;
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
