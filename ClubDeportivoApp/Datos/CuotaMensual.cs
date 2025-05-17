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
        public string Nueva_Cuota(E_CuotaMensual cuota)
        {
            string? salida;
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevaCuota", mySqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("CodCuota", MySqlDbType.VarChar).Value = cuota.CodCuota;
                comando.Parameters.Add("NroCuota", MySqlDbType.Int32).Value = cuota.NroCuota;
                comando.Parameters.Add("Vencimiento", MySqlDbType.DateTime).Value = cuota.Vencimiento;
                comando.Parameters.Add("ValorMensual", MySqlDbType.Float).Value = cuota.ValorMensual;
                comando.Parameters.Add("TipoDePago", MySqlDbType.VarChar).Value = cuota.TipoDePago;
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
