﻿using SistemaViviendas.Clases.ConectorDB;
using MySql.Data.MySqlClient;
using System.Data;
using System;

namespace SistemaViviendas.Clases.Entidades
{
    internal class Unidad
    {
        public int Clave {  get; set; }
        public string Nommbre { get; set; }
        public string Direccion {  get; set; }
        public int NumeroDeptos { get; set; }
        public char Tipo {  get; set; }


        public Unidad(int clave, string nommbre, string direccion, int numeroDeptos, char tipo)
        {
            Clave = clave;
            Nommbre = nommbre;
            Direccion = direccion;
            NumeroDeptos = numeroDeptos;
            Tipo = tipo;
        }
        public Unidad()
        {
        }

        public static DataTable GetUnidadesCB()
        {
            string cmdText = "SELECT CVE_UNIDAD, NOM_UNIDAD FROM JAIV_UNIDAD ORDER BY NOM_UNIDAD ASC";
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
                            dataSetFinal.Rows.Add((int)fila["CVE_UNIDAD"], string.Format("{0}", (string)fila["NOM_UNIDAD"]));

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
        public static Unidad GetUnidad(int clave)
        {
            string cmdText = "SELECT NOM_UNIDAD, UBIC_UNIDAD, NO_DPTOS, TIPO_UNIDAD FROM JAIV_UNIDAD WHERE CVE_UNIDAD = @CLAVE";
            MySqlConnection conn;
            DataSet dataSet = new DataSet();
            Unidad unidad = new Unidad();

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

                        unidad.Nommbre = (string)dataSet.Tables[0].Rows[0]["NOM_UNIDAD"];
                        unidad.Direccion = (string)dataSet.Tables[0].Rows[0]["UBIC_UNIDAD"];
                        unidad.NumeroDeptos = (int)dataSet.Tables[0].Rows[0]["NO_DPTOS"];
                        unidad.Tipo = (char)dataSet.Tables[0].Rows[0]["TIPO_UNIDAD"].ToString()[0];
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            ConectorMySQL.TermConexion(conn);
            return unidad;
        }
        public static bool NewUnidad(string nombre, string direccion, int numeroDeptos, char tipo)
        {
            string cmdText = "INSERT INTO JAIV_UNIDAD(UBIC_UNIDAD, NOM_UNIDAD, NO_DPTOS, TIPO_UNIDAD) VALUES(@DIR, @NOM, @NO_DPTOS, @TIPO)";
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
                        cmdDB.Parameters.AddWithValue("@DIR", direccion);
                        cmdDB.Parameters.AddWithValue("@NOM", nombre);
                        cmdDB.Parameters.AddWithValue("@NO_DPTOS", numeroDeptos);
                        cmdDB.Parameters.AddWithValue("@TIPO", tipo);

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
        public static bool UpdateUnidadData(int clave,string nombre, char tipo)
        {
            string cmdText = "UPDATE JAIV_UNIDAD SET NOM_UNIDAD = @NOM, TIPO_UNIDAD = @TIPO WHERE CVE_UNIDAD = @CLAVE";
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
                        cmdDB.Parameters.AddWithValue("@TIPO", tipo);
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
        public static bool DeleteUnidad(int clave)
        {
            string cmdText = "DELETE FROM JAIV_UNIDAD WHERE CVE_UNIDAD = @CLAVE";
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
