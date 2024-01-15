using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System;

namespace SistemaViviendas.Clases.Utils
{
    static class ValidacionEntradas
    {
        public static bool ValidarEntradasTexto(params object[] entradas)
        {
            bool camposValidos = true;
            bool campoValido = true;

            foreach (object control in entradas)
            {
                //Instancias que evaluara la funcion 
                TextBox tb_obj = new TextBox();
                NumericUpDown NUD_obj = new NumericUpDown();
                ComboBox cb_obj = new ComboBox();

                //si el control es un objeto de tipo TextBox
                if (object.ReferenceEquals(control.GetType(), tb_obj.GetType()))
                {
                    //caracteres especiales que no queremos en el texto
                    string diccionario = "=<>^/[]{};:,?\\|~+-%#!*$`'\"";
                    tb_obj = (TextBox)control;

                    //determina si el campo de texto esta vacio
                    if(string.IsNullOrEmpty(tb_obj.Text.Trim()))
                    {
                        camposValidos = false;
                        campoValido = false;
                        tb_obj.BackColor = Color.Moccasin;
                    }
                    else
                    {
                        //determinamos que el texto no contenga caracteres especiales
                        foreach(char token in diccionario)
                        {
                            if (tb_obj.Text.Contains(token))
                            {
                                camposValidos = false;
                                campoValido = false;
                                tb_obj.BackColor = Color.Moccasin;
                            }
                        }

                        //si el campo antes tuvo errores y ahora ya no, reiniciamos a su apariencia original
                        if (campoValido)
                            tb_obj.BackColor = SystemColors.Window;
                    }
                }

                //si el control es un objeto de tipo NumericUpDown
                if (object.ReferenceEquals(control.GetType(), NUD_obj.GetType()))
                {
                    NUD_obj = (NumericUpDown)control;
                    
                    //evaluamos que no se haya ingresado manualmente un numero fuera de rango del control para evitar excepciones
                    if(NUD_obj.Value <= NUD_obj.Minimum || NUD_obj.Value > NUD_obj.Maximum)
                    {
                        camposValidos = false;
                        campoValido = false;
                        NUD_obj.BackColor = Color.Moccasin;
                    }

                    //si el campo antes tuvo errores y ahora ya no, reiniciamos a su apariencia original
                    if (campoValido)
                        NUD_obj.BackColor = SystemColors.Window;
                }

                //si el control es un objeto de tipo ComboBox
                if (object.ReferenceEquals(control.GetType(), cb_obj.GetType()))
                {
                    cb_obj = (ComboBox)control;

                    //evaluamos si el elemento seleccionado es el primero de la lista que por defecto tendra un valor null o vacio
                    if(cb_obj.SelectedValue == null || string.IsNullOrEmpty(cb_obj.SelectedValue.ToString()))
                    {
                        camposValidos = false;
                        campoValido = false;
                        cb_obj.BackColor = Color.Moccasin;
                    }

                    //si el campo antes tuvo errores y ahora ya no, reiniciamos a su apariencia original
                    if (campoValido)
                        cb_obj.BackColor = SystemColors.Window;
                }

                campoValido = true;
            }
            return camposValidos;
        }

        public static bool ValidarEntradasNumero(bool paraEntero, params object[] entradas)
        {
            bool camposValidos = true;
            bool campoValido = true;

            foreach (object control in entradas)
            {
                //Instancias que evaluara la funcion 
                TextBox tb_obj = new TextBox();
                NumericUpDown NUD_obj = new NumericUpDown();
                ComboBox cb_obj = new ComboBox();

                //si el control es un objeto de tipo TextBox
                if (object.ReferenceEquals(control.GetType(), tb_obj.GetType()))
                {
                    //caracteres especiales que no queremos en el texto
                    string diccionario = "=<>^/[]{};:,?\\|~+-%#!*$`'\"";
                    tb_obj = (TextBox)control;

                    //determina si el campo de texto esta vacio
                    if (string.IsNullOrEmpty(tb_obj.Text.Trim()))
                    {
                        camposValidos = false;
                        campoValido = false;
                        tb_obj.BackColor = Color.Moccasin;
                    }
                    else
                    {
                        //determinamos que el texto no contenga caracteres especiales
                        foreach (char token in diccionario)
                        {
                            if (tb_obj.Text.Contains(token))
                            {
                                camposValidos = false;
                                campoValido = false;
                                tb_obj.BackColor = Color.Moccasin;
                            }
                        }

                        //validamos si el texto es numero si se espera un numero
                        if (!paraEntero)
                        {
                            if (!float.TryParse(tb_obj.Text, out _))
                            {
                                camposValidos = false;
                                campoValido = false;
                                tb_obj.BackColor = Color.Moccasin;
                            }

                        }
                        else
                        {
                            if (!int.TryParse(tb_obj.Text, out _))
                            {
                                camposValidos = false;
                                campoValido = false;
                                tb_obj.BackColor = Color.Moccasin;
                            }
                        }
                        
                        //si el campo antes tuvo errores y ahora ya no, reiniciamos a su apariencia original
                        if (campoValido)
                            tb_obj.BackColor = SystemColors.Window;
                    }
                }

                //si el control es un objeto de tipo NumericUpDown
                if (object.ReferenceEquals(control.GetType(), NUD_obj.GetType()))
                {
                    NUD_obj = (NumericUpDown)control;

                    //evaluamos que no se haya ingresado manualmente un numero fuera de rango del control para evitar excepciones
                    if (NUD_obj.Value <= NUD_obj.Minimum || NUD_obj.Value > NUD_obj.Maximum)
                    {
                        camposValidos = false;
                        campoValido = false;
                        NUD_obj.BackColor = Color.Moccasin;
                    }

                    //si el campo antes tuvo errores y ahora ya no, reiniciamos a su apariencia original
                    if (campoValido)
                        NUD_obj.BackColor = SystemColors.Window;
                }

                //si el control es un objeto de tipo ComboBox
                if (object.ReferenceEquals(control.GetType(), cb_obj.GetType()))
                {
                    cb_obj = (ComboBox)control;

                    //evaluamos si el elemento seleccionado es el primero de la lista que por defecto tendra un valor null o vacio
                    if (cb_obj.SelectedValue == null || string.IsNullOrEmpty(cb_obj.SelectedValue.ToString()))
                    {
                        camposValidos = false;
                        campoValido = false;
                        cb_obj.BackColor = Color.Moccasin;
                    }

                    //si el campo antes tuvo errores y ahora ya no, reiniciamos a su apariencia original
                    if (campoValido)
                        cb_obj.BackColor = SystemColors.Window;
                }

                campoValido = true;
            }
            return camposValidos;
        }

        internal static void LimpiarCampos(params object[] entradas)
        {
            foreach (object control in entradas)
            {
                //Instancias que evaluara la funcion 
                TextBox tb_obj = new TextBox();
                NumericUpDown NUD_obj = new NumericUpDown();
                ComboBox cb_obj = new ComboBox();

                //si el control es un objeto de tipo TextBox
                if (object.ReferenceEquals(control.GetType(), tb_obj.GetType()))
                {
                    tb_obj = (TextBox)control;
                    tb_obj.Text = string.Empty;
                    tb_obj.BackColor = SystemColors.Window;
                }

                //si el control es un objeto de tipo NumericUpDown
                if (object.ReferenceEquals(control.GetType(), NUD_obj.GetType()))
                {
                    NUD_obj = (NumericUpDown)control;
                    NUD_obj.Value = 0;
                    NUD_obj.BackColor = SystemColors.Window;
                }

                //si el control es un objeto de tipo ComboBox
                if (object.ReferenceEquals(control.GetType(), cb_obj.GetType()))
                {
                    cb_obj = (ComboBox)control;
                    cb_obj.SelectedIndex = 0;
                    cb_obj.BackColor = SystemColors.Window;
                }   
            }
        }
    }
}
