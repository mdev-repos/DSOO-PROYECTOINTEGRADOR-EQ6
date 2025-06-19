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

        public List<E_Actividad> ListarTodasLasActividades()
        {
            var lista = new List<E_Actividad>();
            MySqlConnection conexion = null;

            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("ListarTodasLasActividades", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                conexion.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var actividad = new E_Actividad
                    {
                        CodActividad = reader.IsDBNull("Código") ? string.Empty : reader.GetString("Código"),
                        Nombre = reader.IsDBNull("Nombre") ? string.Empty : reader.GetString("Nombre"),
                        Valor = reader.IsDBNull("Precio") ? 0 : Convert.ToSingle(reader.GetDecimal("Precio")),
                        Horario = reader.IsDBNull("Horarios") ? string.Empty : reader.GetString("Horarios")
                    };

                    lista.Add(actividad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar actividades:\n" + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return lista;
        }
    }
}
