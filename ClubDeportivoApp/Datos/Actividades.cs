﻿using System.Data;
using ClubDeportivoApp.Entidades;
using MySql.Data.MySqlClient;

namespace ClubDeportivoApp.Datos
{
    internal class Actividades
    {
        public string Nueva_Actividad(E_Actividad actividad)
        {
            string? salida;

            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevaActividad", mySqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("CodActividad", MySqlDbType.VarChar).Value = actividad.CodActividad;
                comando.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = actividad.Nombre;
                comando.Parameters.Add("Valor", MySqlDbType.Float).Value = actividad.Valor;
                comando.Parameters.Add("Horario", MySqlDbType.VarChar).Value = actividad.Horario;
                MySqlParameter parCodigo = new MySqlParameter();
                parCodigo.ParameterName = "rta";
                parCodigo.MySqlDbType = MySqlDbType.Int32;
                parCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parCodigo);
                mySqlConnection.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(parCodigo.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la actividad:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                salida = ex.Message;
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
            return salida;
        }      
    }
}
