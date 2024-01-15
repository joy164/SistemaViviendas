using MySql.Data.MySqlClient;
using SistemaViviendas.Clases.ConectorDB;
using System.Data;
using System;

namespace SistemaViviendas.Clases.Entidades
{
    internal class Inquilino
    {

        public int NoInquilino { get; set; }
        public string RFC { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string telefono { get; set; }

        public Inquilino(int noInquilino, string rFC, string nombre, string correo, string telefono)
        {
            NoInquilino = noInquilino;
            RFC = rFC;
            Nombre = nombre;
            Correo = correo;
            this.telefono = telefono;
        }

        public Inquilino()
        {
        }

        public static DataTable GetInquilinoCB()
        {
            string cmdText = "SELECT NO_INQUILINO, NOM_INQUILINO FROM JAIV_INQUILINO ORDER BY NO_INQUILINO ASC";
            MySqlConnection conn;
            DataSet dataSet = new DataSet();

            DataTable dataSetFinal = new DataTable();
            dataSetFinal.Columns.Add("clave", typeof(int));
            dataSetFinal.Columns.Add("texto", typeof(string));
            dataSetFinal.Rows.Add(null, "No seleccionado");

            try
            {
                //establecemos si se hay una conexion exitosa con la base de datos
                using (conn = ConectorMySQL.InitConexion())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                        throw new Exception("No se pudo establecer la conexion con la base de datos, revise el estado de conexion de su internet o del servidor");

                    //realizamos la consulta en la base de datos
                    using (MySqlDataAdapter da = new MySqlDataAdapter(new MySqlCommand(cmdText, conn)))
                    {
                        if (da.Fill(dataSet) == 0)
                            return null;

                        foreach (DataRow fila in dataSet.Tables[0].Rows)
                            dataSetFinal.Rows.Add((int)fila["NO_INQUILINO"], string.Format("{0}", (string)fila["NOM_INQUILINO"]));

                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            ConectorMySQL.TermConexion(conn);
            return dataSetFinal;
        }
        public static Inquilino GetInquilino(int clave)
        {
            string cmdText = "SELECT RFC, NOM_INQUILINO, EMAIL_INQUILINO, TEL_INQUILINO FROM JAIV_INQUILINO WHERE NO_INQUILINO = @CLAVE";
            MySqlConnection conn;
            DataSet dataSet = new DataSet();
            Inquilino inquilino = new Inquilino();

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

                        MySqlDataAdapter da = new MySqlDataAdapter(cmdDB);

                        //si no hay ningun grupo se retorna un valor nulo
                        if (da.Fill(dataSet) == 0)
                            return null;

                        inquilino.RFC = (string)dataSet.Tables[0].Rows[0]["RFC"];
                        inquilino.Nombre = (string)dataSet.Tables[0].Rows[0]["NOM_INQUILINO"];
                        inquilino.Correo = (string)dataSet.Tables[0].Rows[0]["EMAIL_INQUILINO"];
                        inquilino.telefono = (string)dataSet.Tables[0].Rows[0]["TEL_INQUILINO"];

                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            ConectorMySQL.TermConexion(conn);
            return inquilino;
        }
        public static bool NewInquilino(string RFC, string nombre, string correo, string telefono)
        {
            string cmdText = "INSERT INTO JAIV_INQUILINO(RFC, NOM_INQUILINO, EMAIL_INQUILINO, TEL_INQUILINO) VALUES(@RFC, @NOM_INQUILINO, @EMAIL_INQUILINO, @TEL_INQUILINO)";
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
                        cmdDB.Parameters.AddWithValue("@RFC", RFC);
                        cmdDB.Parameters.AddWithValue("@NOM_INQUILINO", nombre);
                        cmdDB.Parameters.AddWithValue("@EMAIL_INQUILINO", correo);
                        cmdDB.Parameters.AddWithValue("@TEL_INQUILINO", telefono);

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
        public static bool UpdateInquilinoData(int clave, string correo, string telefono)
        {
            string cmdText = "UPDATE JAIV_INQUILINO SET EMAIL_INQUILINO = @EMAIL_INQUILINO, TEL_INQUILINO = @TEL_INQUILINO WHERE NO_INQUILINO = @CLAVE";
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
                        cmdDB.Parameters.AddWithValue("@EMAIL_INQUILINO", correo);
                        cmdDB.Parameters.AddWithValue("@TEL_INQUILINO", telefono); 
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
        public static bool DeleteInquilino(int clave)
        {
            string cmdText = "DELETE FROM JAIV_INQUILINO WHERE NO_INQUILINO = @CLAVE";
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
    }
}
