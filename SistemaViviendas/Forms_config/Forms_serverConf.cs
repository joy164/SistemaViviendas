using SistemaViviendas.Clases.Utils;
using SistemaViviendas.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaViviendas.Forms_config
{
    public partial class Forms_serverConf : Form
    {
        public Forms_serverConf()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(!ValidacionEntradas.ValidarEntradasTexto(tb_host, tb_name_db, tb_user) || !ValidacionEntradas.ValidarEntradasNumero(true, tb_puerto))
            {
                MessageBox.Show("Entrada de texto invalida, revise la configuracion ingresada e intente nuevamente", "Error de campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Settings.Default.host = tb_host.Text;
            Settings.Default.port = tb_puerto.Text;
            Settings.Default.user = tb_user.Text;
            Settings.Default.password = tb_password.Text;

            Settings.Default.Save();

        }

        private void cargarDatos()
        {
            tb_host.Text = Settings.Default.host;
            tb_puerto.Text = Settings.Default.port;
            tb_name_db.Text = Settings.Default.name_db;
            tb_user.Text = Settings.Default.user;
            tb_password.Text = Settings.Default.password;
        }

    }
}
