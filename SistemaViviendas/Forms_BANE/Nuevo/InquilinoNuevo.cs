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
    public partial class InquilinoNuevo : Form
    {
        public InquilinoNuevo()
        {
            InitializeComponent();
        }

        private void btn_accion_Click(object sender, EventArgs e)
        {
            if (!ValidacionEntradas.ValidarEntradasTexto(tb_nom, tb_correo, tb_tel))
            {
                MessageBox.Show("Error en los campos marcados, por favor revise que sus datos o seleccion sea correcta", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string rfc = string.IsNullOrEmpty(tb_rfc.Text) ? string.Empty : tb_rfc.Text;
            string nom = tb_nom.Text;
            string correo = tb_correo.Text;
            string tel = tb_tel.Text;
            
            try
            {
                if (Inquilino.NewInquilino(rfc, nom, correo, tel))
                {
                    MessageBox.Show("El inquilino se registro con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ValidacionEntradas.LimpiarCampos(tb_nom, tb_correo, tb_tel, tb_rfc);
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
