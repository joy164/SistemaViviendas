using MySql.Data.MySqlClient;
using SistemaViviendas.Clases.ConectorDB;
using System.Data;
using System;

namespace SistemaViviendas.Clases.Entidades
{
    internal class Dpto_caract_dpto
    {
        public int NoCaracteristica { get; set; }
        public int noDepto { get; set; }

        public Dpto_caract_dpto(int noCaracteristica, int noDepto)
        {
            NoCaracteristica = noCaracteristica;
            this.noDepto = noDepto;
        }

        public Dpto_caract_dpto()
        {
        }

        public static DataTable GetDptoCaractDpto()
        {
            string cmdText = "SELECT * FROM JAIV_DEPARTAMENTO_CARACTERISTICAS ORDER BY NO_CARACTERISTICA1 ASC";
            MySqlConnection conn;
            DataSet dataSet = new DataSet();

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
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            ConectorMySQL.TermConexion(conn);
            return dataSet.Tables[0];
        }
        public static bool NewDptoCaractDpto(int no_caracteristica, int no_dpto)
        {
            string cmdText = "INSERT INTO JAIV_CARACTERISTICAS_DEPTO_DEPARTAMENTO VALUES(@NO_CARACT, @NO_DPTO)";
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
                        cmdDB.Parameters.AddWithValue("@NO_CARACT", no_caracteristica);
                        cmdDB.Parameters.AddWithValue("@NO_DPTO", no_dpto);

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
        public static bool UpdateDptoCaractDptoData(int no_dpto, int no_caracteristica)
        {
            string cmdText = "UPDATE JAIV_CARACTERISTICAS_DEPTO_DEPARTAMENTO SET NO_DPTO1 = @NO_CARACT WHERE NO_DPTO1 = @NO_DPTO";
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
                        cmdDB.Parameters.AddWithValue("@NO_CARACT", no_caracteristica);
                        cmdDB.Parameters.AddWithValue("@NO_DPTO", no_dpto);

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
        public static bool DeleteDptoCaractDpto(int no_caracteristica, int no_dpto)
        {
            string cmdText = "DELETE FROM JAIV_CARACTERISTICAS_DEPTO_DEPARTAMENTO WHERE NO_CARACTERISTICA1 = @NO_CARACT AND NO_DPTO1 = @NO_DPTO";
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
                        cmdDB.Parameters.AddWithValue("@NO_CARACT", no_caracteristica);
                        cmdDB.Parameters.AddWithValue("@NO_DPTO", no_dpto);

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
