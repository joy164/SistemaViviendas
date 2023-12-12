using SistemaViviendas.Clases.ConectorDB;
using MySql.Data.MySqlClient;
using System.Data;
using System;

namespace SistemaViviendas.Clases.Entidades
{
    internal class Usuario
    {
        #region Atributos
        public int ID {  get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        #endregion

        #region Constructor
        public Usuario(int iD, string nombre, string password)
        {
            ID = iD;
            Nombre = nombre;
            Password = password;
        }
        public Usuario() 
        { 
        
        }
        #endregion

        #region Metodos      
        public static Usuario GetUsuario(int clave, string password)
        {
            string cmdText = "SELECT * FROM JAIV_USUARIO WHERE ID_USUARIO = @CLAVE AND PASSWORD = @PASSWORD";
            MySqlConnection conn;
            DataSet dataSet = new DataSet();
            Usuario usuario = new Usuario();

            try
            {
                //establecemos si se hay una conexion exitosa con la base de datos
                using (conn = ConectorMySQL.InitConexion())
                {

                    if (conn == null || conn.State != ConnectionState.Open)
                        throw new Exception("No se pudo establecer la conexion con la base de datos, revise el estado de conexion de su internet o del servidor");

                    //realizamos la consulta en la base de datos con el parametro de tipo entero
                    using (MySqlCommand cmdDB = new MySqlCommand(cmdText, conn))
                    {
                        cmdDB.Parameters.AddWithValue("@CLAVE", clave);
                        cmdDB.Parameters.AddWithValue("@PASSWORD", password);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmdDB);

                        //si no hay ningun grupo se retorna un valor nulo
                        if (da.Fill(dataSet) == 0)
                            return null;

                        usuario.ID = (int)dataSet.Tables[0].Rows[0]["ID_USUARIO"];
                        usuario.Nombre = (string)dataSet.Tables[0].Rows[0]["NOM_USUARIO"];
                        usuario.Password = (string)dataSet.Tables[0].Rows[0]["PASSWORD"];
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            ConectorMySQL.TermConexion(conn);
            return usuario;
        }
        public static bool NewUsuario(string usuario, string password)
        {
            string cmdText = "INSERT INTO JAIV_USUARIO(nom_usuario, password)  VALUES(@USUARIO, @PASSWORD)";
            MySqlConnection conn;
            bool resultado = false;

            try
            {
                //establecemos si se hay una conexion exitosa con la base de datos
                using (conn = ConectorMySQL.InitConexion())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                        throw new Exception("No se pudo establecer la conexion con la base de datos, revise el estado de conexion de su internet o del servidor");

                    //realizamos la consulta en la base de datos con el parametro de tipo entero
                    using (MySqlCommand cmdDB = new MySqlCommand(cmdText, conn))
                    {
                        cmdDB.Parameters.AddWithValue("@USUARIO", usuario);
                        cmdDB.Parameters.AddWithValue("@PASSWORD", password);

                        if (cmdDB.ExecuteNonQuery() == 1) resultado = true;
                    }

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            ConectorMySQL.TermConexion(conn);
            return resultado;
        }
        public static bool UpdateUsuarioData(int clave, string password)
        {
            string cmdText = "UPDATE JAIV_USUARIO SET PASSWORD = @PASSWORD WHERE ID_USUARIO = @CLAVE";
            MySqlConnection conn;
            bool resultado = false;

            try
            {
                //establecemos si se hay una conexion exitosa con la base de datos
                using (conn = ConectorMySQL.InitConexion())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                        throw new Exception("No se pudo establecer la conexion con la base de datos, revise el estado de conexion de su internet o del servidor");

                    //realizamos la consulta en la base de datos con el parametro de tipo entero
                    using (MySqlCommand cmdDB = new MySqlCommand(cmdText, conn))
                    {
                        cmdDB.Parameters.AddWithValue("@PASSWORD", password);
                        cmdDB.Parameters.AddWithValue("@CLAVE", clave);

                        if (cmdDB.ExecuteNonQuery() == 1) resultado = true;
                    }

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            ConectorMySQL.TermConexion(conn);
            return resultado;
        }
        public static bool DeleteUsuario(int clave)
        {
            string cmdText = "DELETE FROM JAIV_USUARIO WHERE ID_USUARIO = @CLAVE";
            MySqlConnection conn;
            bool resultado = false;

            try
            {
                //establecemos si se hay una conexion exitosa con la base de datos
                using (conn = ConectorMySQL.InitConexion())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                        throw new Exception("No se pudo establecer la conexion con la base de datos, revise el estado de conexion de su internet o del servidor");

                    //realizamos la consulta en la base de datos con el parametro de tipo entero
                    using (MySqlCommand cmdDB = new MySqlCommand(cmdText, conn))
                    {
                        cmdDB.Parameters.AddWithValue("@CLAVE", clave);

                        if (cmdDB.ExecuteNonQuery() == 1) resultado = true;
                    }

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            ConectorMySQL.TermConexion(conn);
            return resultado;
        }
        #endregion
    }
}
