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
    internal class CuotaDiaria
    {
        public string CrearCuotaDiariaParcial(E_CuotaDiaria cuota, out string codCuotaGenerada)
        {
            string salida;
            codCuotaGenerada = string.Empty;
            MySqlConnection conexion = null;

            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("CrearCuotaDiariaParcial", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada (solo los necesarios según el nuevo procedure)
                comando.Parameters.Add("p_CodCuotaDiaria", MySqlDbType.VarChar, 50).Value = cuota.CodCuotaDiaria;
                comando.Parameters.Add("p_ValorFinal", MySqlDbType.Float).Value = cuota.ValorFinal;
                comando.Parameters.Add("p_FechaDeUso", MySqlDbType.VarChar, 10).Value = cuota.FechaDeUso;
                comando.Parameters.Add("p_CodNoSocio", MySqlDbType.VarChar, 50).Value = cuota.CodNoSocio;
                comando.Parameters.Add("p_CodActividad", MySqlDbType.VarChar, 50).Value = cuota.CodActividad;

                // Parámetro de salida
                MySqlParameter parRta = new MySqlParameter
                {
                    ParameterName = "rta",
                    MySqlDbType = MySqlDbType.Int32,
                    Direction = ParameterDirection.Output
                };
                comando.Parameters.Add(parRta);

                conexion.Open();
                comando.ExecuteNonQuery();

                // Obtener resultado
                salida = parRta.Value != DBNull.Value ? parRta.Value.ToString() : "1";
                codCuotaGenerada = cuota.CodCuotaDiaria;
            }
            catch (Exception ex)
            {
                salida = $"Error al crear cuota: {ex.Message}";
                codCuotaGenerada = string.Empty;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return salida;
        }

        public string ActualizarCuotaDiariaCompleta(E_CuotaDiaria cuota)
        {
            string salida;
            MySqlConnection conexion = null;

            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarCuotaDiariaCompleta", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada con tipos exactos
                comando.Parameters.Add("p_CodCuotaDiaria", MySqlDbType.VarChar, 50).Value = cuota.CodCuotaDiaria;
                comando.Parameters.Add("p_TipoDePago", MySqlDbType.VarChar, 50).Value = cuota.TipoDePago;
                comando.Parameters.Add("p_CantidadCuotas", MySqlDbType.Int32).Value = cuota.CantidadCuotas;
                comando.Parameters.Add("p_FechaDePago", MySqlDbType.VarChar, 10).Value = cuota.FechaDePago;

                // Parámetro de salida
                MySqlParameter parRta = new MySqlParameter
                {
                    ParameterName = "rta",
                    MySqlDbType = MySqlDbType.Int32,
                    Direction = ParameterDirection.Output
                };
                comando.Parameters.Add(parRta);

                conexion.Open();
                comando.ExecuteNonQuery();

                salida = parRta.Value != DBNull.Value ? parRta.Value.ToString() : "1";
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return salida;
        }
    }
}
