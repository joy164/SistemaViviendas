using SistemaViviendas.Clases.Entidades;
using SistemaViviendas.Clases.Utils;
using System.Windows.Forms;
using System;
using SistemaViviendas.Forms_config;

namespace SistemaViviendas
{
    public partial class Form_iniciarSesion : Form
    {
        public Form_iniciarSesion()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.PasswordChar = '\0';
            else
                textBox2.PasswordChar = '•';
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            if (!ValidacionEntradas.ValidarEntradasNumero(true, textBox1) || !ValidacionEntradas.ValidarEntradasTexto(textBox2))
            {
                MessageBox.Show("Error en los campos marcados, por favor revise que sus datos o seleccion sea correcta", "Error en los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(textBox1.Text);
            string password = textBox2.Text;
            
            try
            {
                usuario = Usuario.GetUsuario(id, password);

                if (usuario == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Error de credenciales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Form_menuPrincipal form = new Form_menuPrincipal(usuario.Nombre);
                form.FormClosed += Logout;
                form.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error con la base de datos: " + ex.Message, "Error de Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

            ActiveControl = textBox1;
            Show();
        }

        private void Form_iniciarSesion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Alt | Keys.C))
            {
                Forms_configPrincipal form = new Forms_configPrincipal();
                form.ShowDialog();
            }
        }
    }
}
