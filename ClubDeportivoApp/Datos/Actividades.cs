using System.Data;
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
                MySqlCommand comando = new MySqlCommand("NuevoCliente", mySqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Cod_Actividad", MySqlDbType.VarChar).Value = actividad.CodActividad;
                comando.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = actividad.Nombre;
                comando.Parameters.Add("Valor", MySqlDbType.Float).Value = actividad.Valor;
                comando.Parameters.Add("Horario", MySqlDbType.VarChar).Value = actividad.Horario;
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
