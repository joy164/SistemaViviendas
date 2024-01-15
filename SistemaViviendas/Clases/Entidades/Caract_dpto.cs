using MySql.Data.MySqlClient;
using SistemaViviendas.Clases.ConectorDB;
using System.Data;
using System;

namespace SistemaViviendas.Clases.Entidades
{
    internal class Caract_dpto
    {
        public int NoCaract { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Clave { get; set; }
        public float CostoExtra { get; set; }

        public Caract_dpto(int noCaract, string nombre, string descripcion, string clave, float costoExtra)
        {
            NoCaract = noCaract;
            Nombre = nombre;
            Descripcion = descripcion;
            Clave = clave;
            CostoExtra = costoExtra;
        }
        public Caract_dpto()
        {
        }

        public static DataTable GetCaractDptoCB()
        {
            string cmdText = "SELECT NO_CARACTERISTICA, NOM_CARACTERISTICA FROM JAIV_CARCTERISTICAS_DEPARTAMENTO ORDER BY NO_CARACTERISTICA ASC";
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
        public static Caract_dpto GetCaractDpto(int clave)
        {
            string cmdText = "SELECT NOM_CARACTERISTICA, DESCRIPCION, CLAVE, COSTO_EXTRA FROM JAIV_CARACTERISTICAS_DEPARTAMENTO WHERE NO_CARACTERISTICA = @CLAVE";
            MySqlConnection conn;
            DataSet dataSet = new DataSet();
            Caract_dpto caract_dpto = new Caract_dpto();

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

                        caract_dpto.Nombre = (string)dataSet.Tables[0].Rows[0]["NOM_CARACTERISTICA"];
                        caract_dpto.Descripcion = (string)dataSet.Tables[0].Rows[0]["DESCRIPCION"];
                        caract_dpto.Clave = (string)dataSet.Tables[0].Rows[0]["CLAVE"];
                        caract_dpto.CostoExtra = (float)dataSet.Tables[0].Rows[0]["COSTO_EXTRA"];
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            ConectorMySQL.TermConexion(conn);
            return caract_dpto;
        }
        public static bool NewCaractDpto(string nombre, string descripcion, string clave, float precioExtra)
        {
            string cmdText = "INSERT INTO JAIV_CARACTERISTICAS_DEPARTAMENTO(NOM_CARACTERISTICA, DESCRIPCION, CLAVE, COSTO_EXTRA) VALUES(@NOM, @DESC, @CLAVE, @COSTO)";
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
                        cmdDB.Parameters.AddWithValue("@NOM", nombre);
                        cmdDB.Parameters.AddWithValue("@DESC", descripcion);
                        cmdDB.Parameters.AddWithValue("@CLAVE", clave);
                        cmdDB.Parameters.AddWithValue("@COSTO", precioExtra);

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
        public static bool UpdateCaractDptoData(int clave, float costoExtra)
        {
            string cmdText = "UPDATE JAIV_CARACTERISTICAS_DEPARTAMENTO SET COSTO_EXTRA = @COSTO WHERE NO_CARACTERISTICA = @CLAVE";
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
                        cmdDB.Parameters.AddWithValue("@COSTO", costoExtra);
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
        public static bool DeleteCaractDpto(int clave)
        {
            string cmdText = "DELETE FROM JAIV_CARACTERISTICAS_DEPARTAMENTO WHERE NO_CARACTERISTICA = @CLAVE";
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
