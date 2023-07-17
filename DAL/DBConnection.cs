using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
    public static class DBConnection
    {
        private static readonly string StrCadenaConexion = @"Data Source=.;Initial Catalog=PROYECTO_ING;User ID=sa;Password=9526";

        //private static string StrCadenaConexion = ConfigurationManager.ConnectionStrings["cnnString"]?.ConnectionString;
        /// <summary>
        /// Ejecuta un procedmiento almacenado
        /// </summary>
        /// <param name="StorageProcedure">Nombre del Procedimiento Alamcenado</param>
        /// <param name="Parameters">Lista de Parámetros</param>
        /// <returns>El resultado de los datos en un List<T></returns>
        public static List<T> ExecuteStorageProcedure<T>(string StorageProcedure, List<DBParameter> Parameters)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(StrCadenaConexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(StorageProcedure, cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (DBParameter parameter in Parameters)
                        {
                            cmd.Parameters.AddWithValue(parameter.ParameterName, parameter.ParameterValue);
                        }

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            var results = new List<T>();

                            while (dr.Read())
                            {
                                var item = Activator.CreateInstance<T>();

                                foreach (var prop in typeof(T).GetProperties())
                                {
                                    var val = dr[prop.Name];
                                    if (val != DBNull.Value)
                                    {
                                        prop.SetValue(item, val);
                                    }
                                }

                                results.Add(item);
                            }

                            return results;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// Ejecuta un procedmiento almacenado
        /// </summary>
        /// <param name="StorageProcedure">Nombre del Procedimiento Alamcenado</param>
        /// <param name="Parameters">Lista de Parámetros</param>
        /// <returns>El resultado de los datos en un List<T></returns>
        public static List<T> ExecuteStorageProcedure<T>(string StorageProcedure)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(StrCadenaConexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(StorageProcedure, cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            var results = new List<T>();

                            while (dr.Read())
                            {
                                var item = Activator.CreateInstance<T>();

                                foreach (var prop in typeof(T).GetProperties())
                                {
                                    var val = dr[prop.Name];
                                    if (val != DBNull.Value)
                                    {
                                        prop.SetValue(item, val);
                                    }
                                }

                                results.Add(item);
                            }

                            return results;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Ejecuta un procedmiento almacenado
        /// </summary>
        /// <param name="StorageProcedure">Nombre del Procedimiento Alamcenado</param>
        /// <param name="Parameters">Lista de Parámetros</param>
        public static void ExecuteStorageProcedure(string StorageProcedure, List<DBParameter> Parameters)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(StrCadenaConexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(StorageProcedure, cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (DBParameter parameter in Parameters)
                        {
                            cmd.Parameters.AddWithValue(parameter.ParameterName, parameter.ParameterValue);
                        }
                        cmd.ExecuteReader();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Ejecuta un procedmiento almacenado
        /// </summary>
        /// <param name="StorageProcedure">Nombre del Procedimiento Alamcenado</param>
        /// <param name="Parameters">Lista de Parámetros</param>
        public static string ExecuteScalarProcedure(string StorageProcedure, List<DBParameter> Parameters)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(StrCadenaConexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(StorageProcedure, cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (DBParameter parameter in Parameters)
                        {
                            cmd.Parameters.AddWithValue(parameter.ParameterName, parameter.ParameterValue);
                        }
                        return cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


    }

    public class DBParameter
    {
        public string ParameterName { get; set; }
        public object ParameterValue { get; set; }

    }


}
