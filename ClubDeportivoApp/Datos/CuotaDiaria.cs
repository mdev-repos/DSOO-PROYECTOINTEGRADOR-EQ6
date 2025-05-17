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
        public string NuevaCuotaDiaria(E_CuotaDiaria cuota)
        {
            string? salida;
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevaCuotaDiaria", mySqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("CodCuotaDiaria", MySqlDbType.VarChar).Value = cuota.CodCuotaDiaria;
                comando.Parameters.Add("ValorFinal", MySqlDbType.Float).Value = cuota.ValorFinal;
                comando.Parameters.Add("TipoDePago", MySqlDbType.String).Value = cuota.TipoDePago;
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                mySqlConnection.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la cuota:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
