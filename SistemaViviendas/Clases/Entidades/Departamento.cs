using MySql.Data.MySqlClient;
using SistemaViviendas.Clases.ConectorDB;
using System.Data;
using System;

namespace SistemaViviendas.Clases.Entidades
{
    internal class Departamento
    {

        public int NoDepto { get; set; }
        public int NoRecamaras { get; set; }
        public int NoBaños { get; set; }
        public int NoPiso {  get; set; }
        public string NumeroDpto { get; set; }
        public int CveUnidad { get; set; }
        public int NoInquilino {  get; set; }

        public Departamento(int noDepto, int noRecamaras, int noBaños, int noPiso, string numeroDpto, int cveUnidad, int noInquilino)
        {
            NoDepto = noDepto;
            NoRecamaras = noRecamaras;
            NoBaños = noBaños;
            NoPiso = noPiso;
            NumeroDpto = numeroDpto;
            CveUnidad = cveUnidad;
            NoInquilino = noInquilino;
        }

        public Departamento()
        {
        }

        public static DataTable GetDepartamentoCB()
        {
            string cmdText = "SELECT NO_DPTO, NUMERO_DPTO FROM JAIV_DEPARTAMENTO ORDER BY NO_DPTO ASC";
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
                            dataSetFinal.Rows.Add((int)fila["NO_DPTO"], string.Format("Departamento {0}", (string)fila["NUMERO_DPTO"]));
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
        public static Departamento GetDepartamento(int clave)
        {
            string cmdText = "SELECT NO_RECAMARAS, NO_BANOS, NO_PISO, NUMERO_DPTO, CVE_UNIDAD1, NO_INQUILINO1 FROM JAIV_DEPARTAMENTO WHERE NO_DPTO = @CLAVE";
            MySqlConnection conn;
            DataSet dataSet = new DataSet();
            Departamento departamento = new Departamento();

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

                        departamento.NoRecamaras = (int)dataSet.Tables[0].Rows[0]["NO_RECAMARAS"];
                        departamento.NoBaños = (int)dataSet.Tables[0].Rows[0]["NO_BANOS"];
                        departamento.NoPiso = (int)dataSet.Tables[0].Rows[0]["NO_PISO"];
                        departamento.NumeroDpto = (string)dataSet.Tables[0].Rows[0]["NUMERO_DPTO"];
                        departamento.CveUnidad = (int)dataSet.Tables[0].Rows[0]["CVE_UNIDAD1"];
                        if(!string.IsNullOrEmpty(dataSet.Tables[0].Rows[0]["NO_INQUILINO1"].ToString()))
                            departamento.NoInquilino = (int)dataSet.Tables[0].Rows[0]["NO_INQUILINO1"];
                        

                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            ConectorMySQL.TermConexion(conn);
            return departamento;
        }
        public static bool NewDepartamento(int noRecamaras, int noBaños, int noPiso, string numeroDpto, int cveUnidad, int noInquilino)
        {
            string cmdText = "INSERT INTO JAIV_DEPARTAMENTO(NO_RECAMARAS, NO_BANOS, NO_PISO, NUMERO_DPTO, CVE_UNIDAD1, NO_INQUILINO1) VALUES(@NO_RECAMARAS, @NO_BANOS, @NO_PISO, @NUMERO_DPTO, @CVE_UNIDAD1, @NO_INQUILINO1)";
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
                        cmdDB.Parameters.AddWithValue("@NO_RECAMARAS", noRecamaras);
                        cmdDB.Parameters.AddWithValue("@NO_BANOS", noBaños);
                        cmdDB.Parameters.AddWithValue("@NO_PISO", noPiso);
                        cmdDB.Parameters.AddWithValue("@NUMERO_DPTO", numeroDpto);
                        cmdDB.Parameters.AddWithValue("@CVE_UNIDAD1", cveUnidad);
                        if(noInquilino == 0)
                        cmdDB.Parameters.AddWithValue("@NO_INQUILINO1", DBNull.Value);
                        else
                            cmdDB.Parameters.AddWithValue("@NO_INQUILINO1", noInquilino);
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
        public static bool UpdateDepartamentoData(int clave, int noInquilino)
        {
            string cmdText = "UPDATE JAIV_DEPARTAMENTO SET NO_INQUILINO1 = @NO_INQUILINO1 WHERE NO_DPTO = @CLAVE";
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
                        cmdDB.Parameters.AddWithValue("@NO_INQUILINO1", noInquilino);
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
        public static bool DeleteDepartamento(int clave)
        {
            string cmdText = "DELETE FROM JAIV_DEPARTAMENTO WHERE NO_DPTO = @CLAVE";
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
