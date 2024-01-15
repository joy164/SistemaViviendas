using MySql.Data.MySqlClient;
using SistemaViviendas.Clases.ConectorDB;
using System.Data;
using System;

namespace SistemaViviendas.Clases.Entidades
{
    internal class Estacionamiento
    {
        public int NoEstacionamiento {  get; set; }
        public string Nivel { get; set; }
        public string Seccion {  get; set; }
        public int Numero { get; set; }
        public int NoDepto { get; set; }

        public Estacionamiento(int noEstacionamiento, string nivel, string seccion, int numero, int noDepto)
        {
            NoEstacionamiento = noEstacionamiento;
            Nivel = nivel;
            Seccion = seccion;
            Numero = numero;
            NoDepto = noDepto;
        }

        public Estacionamiento()
        {
        }

        public static DataTable GetEstacionamientoCB()
        {
            string cmdText = "SELECT NO_ESTACIONAMIENTO, NIVEL, SECCION, NUMERO FROM JAIV_ESTACIONAMIENTO ORDER BY NO_ESTACIONAMIENTO ASC";
            MySqlConnection conn;
            DataSet dataSet = new DataSet();

            DataTable dataSetFinal = new DataTable();
            dataSetFinal.Columns.Add("clave", typeof(int));
            dataSetFinal.Columns.Add("texto", typeof(string));

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
                            dataSetFinal.Rows.Add((int)fila["NO_ESTACIONAMIENTO"], string.Format("Nivel {0} Seccion {1} #{2}", (string)fila["NIVEL"], (string)fila["SECCION"], (string)fila["NUMERO"]));
                        
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
        public static Estacionamiento GetEstacionamiento(int clave)
        {
            string cmdText = "SELECT NIVEL, SECCION, NUMERO, NO_DPTO3 FROM JAIV_ESTACIONAMIENTO WHERE NO_ESTACIONAMIENTO = @CLAVE";
            MySqlConnection conn;
            DataSet dataSet = new DataSet();
            Estacionamiento estacionamiento = new Estacionamiento();

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

                        estacionamiento.Nivel = (string)dataSet.Tables[0].Rows[0]["NIVEL"];
                        estacionamiento.Seccion = (string)dataSet.Tables[0].Rows[0]["SECCION"];
                        estacionamiento.Numero = (int)dataSet.Tables[0].Rows[0]["NUMERO"];
                        estacionamiento.NoDepto = (int)dataSet.Tables[0].Rows[0]["NO_DPTO3"];

                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            ConectorMySQL.TermConexion(conn);
            return estacionamiento;
        }
        public static bool NewEstacionamiento(string nivel, string seccion, int numero, int noDepto)
        {
            string cmdText = "INSERT INTO JAIV_ESTACIONAMIENTO(NIVEL, SECCION, NUMERO, NO_DPTO3) VALUES(@NIVEL, @SECCION, @NUMERO, @NO_DPTO3)";
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
                        cmdDB.Parameters.AddWithValue("@NIVEL", nivel);
                        cmdDB.Parameters.AddWithValue("@SECCION", seccion);
                        cmdDB.Parameters.AddWithValue("@NUMERO", numero);
                        cmdDB.Parameters.AddWithValue("@NO_DPTO3", noDepto);

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
        public static bool UpdateEstacionamientoData(int clave, int noDepto)
        {
            string cmdText = "UPDATE JAIV_ESTACIONAMIENTO SET NO_DPTO3 = @NO_DPTO3 WHERE NO_ESTACIONAMIENTO = @CLAVE";
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
                        cmdDB.Parameters.AddWithValue("@NO_DPTO3", noDepto);
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
        public static bool DeleteEstacionamiento(int clave)
        {
            string cmdText = "DELETE FROM JAIV_ESTACIONAMIENTO WHERE NO_ESTACIONAMIENTO = @CLAVE";
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
