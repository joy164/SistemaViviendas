using MySql.Data.MySqlClient;
using SistemaViviendas.Clases.ConectorDB;
using System;
using System.Data;

namespace SistemaViviendas.Clases.Entidades
{
    internal class Renta
    {
        public int CveRenta { get; set; }
        public DateTime FechaPago {  get; set; }
        public string FormaPago { get; set; }
        public float PagoRealizado { get; set; }
        public float Mensualidad { get; set; }
        public int NoDepto { get; set; }

        public Renta(int cveRenta, DateTime fechaPago, string formaPago, float pagoRealizado, float mensualidad, int noDepto)
        {
            CveRenta = cveRenta;
            FechaPago = fechaPago;
            FormaPago = formaPago;
            PagoRealizado = pagoRealizado;
            Mensualidad = mensualidad;
            NoDepto = noDepto;
        }

        public Renta()
        {
        }

        public static DataTable GetRentaCB()
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
        public static Renta GetRenta(int clave)
        {
            string cmdText = "SELECT FECHA_PAGO, FORMA_PAGO, PAGO_REALIZADO, MENSUALIDAD, NO_DPTO2 FROM JAIV_RENTA WHERE CVE_RENTA = @CLAVE";
            MySqlConnection conn;
            DataSet dataSet = new DataSet();
            Renta renta = new Renta();

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

                        renta.FechaPago= (DateTime)dataSet.Tables[0].Rows[0]["FECHA_PAGO"];
                        renta.FormaPago = (string)dataSet.Tables[0].Rows[0]["FORMA_PAGO"];
                        renta.PagoRealizado = (float)dataSet.Tables[0].Rows[0]["PAGO_REALIZADO"];
                        renta.Mensualidad = (float)dataSet.Tables[0].Rows[0]["MENSUALIDAD"];
                        renta.NoDepto = (int)dataSet.Tables[0].Rows[0]["NO_DPTO2"];

                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            ConectorMySQL.TermConexion(conn);
            return renta;
        }
        public static bool NewRenta(DateTime fechaPago, string formaPago, float pagoRealizado, float mensualidad, int noDepto)
        {
            string cmdText = "INSERT INTO JAIV_RENTA(FECHA_PAGO, FORMA_PAGO, PAGO_REALIZADO, MENSUALIDAD, NO_DPTO2) VALUES(@FECHA_PAGO, @FORMA_PAGO, @PAGO_REALIZADO, @MENSUALIDAD, @NO_DPTO2)";
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
                        cmdDB.Parameters.AddWithValue("@FECHA_PAGO", fechaPago);
                        cmdDB.Parameters.AddWithValue("@FORMA_PAGO", formaPago);
                        cmdDB.Parameters.AddWithValue("@PAGO_REALIZADO", pagoRealizado);
                        cmdDB.Parameters.AddWithValue("@MENSUALIDAD", mensualidad);
                        cmdDB.Parameters.AddWithValue("@NO_DPTO2", noDepto);

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
        public static bool UpdateRentaData(int clave, float menusalidad)
        {
            string cmdText = "UPDATE JAIV_RENTA SET MENSUALIDAD = @MENSUALIDAD WHERE CVE_RENTA = @CLAVE";
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
                        cmdDB.Parameters.AddWithValue("@MENSUALIDAD", menusalidad);
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
        public static bool DeleteRenta(int clave)
        {
            string cmdText = "DELETE FROM JAIV_RENTA WHERE CVE_RENTA = @CLAVE";
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
