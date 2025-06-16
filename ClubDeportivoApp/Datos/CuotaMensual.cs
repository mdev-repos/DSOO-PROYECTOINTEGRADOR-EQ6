using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubDeportivoApp.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace ClubDeportivoApp.Datos
{
    internal class CuotaMensual
    {
        public string GenerarPrimerCuota(E_CuotaMensual cuota)
        {
            string salida;
            MySqlConnection conexion = new MySqlConnection();

            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("GenerarPrimerCuota", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("p_CodCuota", cuota.CodCuota);
                comando.Parameters.AddWithValue("p_NroCuota", cuota.NroCuota);
                comando.Parameters.AddWithValue("p_Vencimiento", cuota.Vencimiento);
                comando.Parameters.AddWithValue("p_ValorMensual", cuota.ValorMensual);
                comando.Parameters.AddWithValue("p_CodSocio", cuota.CodSocio);

                MySqlParameter ParCodigo = new MySqlParameter("rta", MySqlDbType.Int32);
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);

                conexion.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }

            return salida;
        }

        public string GenerarNuevaCuota(string codCuotaActual, out string nuevaCodCuota)
        {
            string salida;
            nuevaCodCuota = string.Empty;
            MySqlConnection conexion = new MySqlConnection();

            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("GenerarNuevaCuota", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("p_CodCuotaActual", codCuotaActual);

                // Parámetros de salida
                comando.Parameters.Add("p_NuevaCodCuota", MySqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                comando.Parameters.Add("rta", MySqlDbType.Int32).Direction = ParameterDirection.Output;

                conexion.Open();
                comando.ExecuteNonQuery();

                nuevaCodCuota = comando.Parameters["p_NuevaCodCuota"].Value.ToString();
                salida = comando.Parameters["rta"].Value.ToString();
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }

            return salida;
        }

        public E_CuotaMensual ObtenerCuotaCompleta(string codCuota)
        {
            E_CuotaMensual cuota = null;
            MySqlConnection conexion = null;

            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerCuotaCompleta", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@p_codCuota", codCuota);

                conexion.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    cuota = new E_CuotaMensual
                    {
                        CodCuota = reader["CodCuotaMensual"].ToString(),
                        NroCuota = reader.GetInt32("NroCuota"),
                        Vencimiento = reader.GetDateTime("Vencimiento"),
                        ValorMensual = reader.GetFloat("ValorMensual"),
                        Pagada = reader.GetBoolean("Pagada"),
                        TipoDePago = reader["TipoDePago"].ToString(),
                        FechaDePago = reader["FechaDePago"].ToString(),
                        CodSocio = reader["CodSocio"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener cuota: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return cuota;
        }
    }
}
