using System.Data;
using ClubDeportivoApp.Entidades;
using MySql.Data.MySqlClient;

namespace ClubDeportivoApp.Datos
{
    internal class NoSocio
    {
        public string Nuevo_NoSocio(E_NoSocio noSocio) 
        {
            string? salida;

            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoNoSocio", mySqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("CodNoSocio", MySqlDbType.VarChar).Value = noSocio.CodNoSocio;
                comando.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = noSocio.Nombre;
                comando.Parameters.Add("Apellido", MySqlDbType.VarChar).Value = noSocio.Apellido;
                comando.Parameters.Add("Dni", MySqlDbType.Int32).Value = noSocio.Dni;
                comando.Parameters.Add("FechaNac", MySqlDbType.DateTime).Value = noSocio.FechaNac;
                comando.Parameters.Add("Direccion", MySqlDbType.VarChar).Value = noSocio.Direccion;
                comando.Parameters.Add("Telefono", MySqlDbType.VarChar).Value = noSocio.Telefono;
                comando.Parameters.Add("Email", MySqlDbType.VarChar).Value = noSocio.Email;
                comando.Parameters.Add("FichaMedica", MySqlDbType.Bit).Value = noSocio.FichaMedica;
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
                MessageBox.Show("Error al registrar al No Socio:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public E_NoSocio BuscarNoSocioPorDni(string dni)
        {
            E_NoSocio noSocio = null;
            MySqlConnection conexion = null;

            try
            {
                // Validación básica del DNI
                if (string.IsNullOrWhiteSpace(dni)) return null;

                conexion = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("BuscarNoSocioPorDni", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@p_dni", dni);

                conexion.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        noSocio = new E_NoSocio
                        {
                            // Propiedades de E_NoSocio
                            CodNoSocio = reader["CodNoSocio"].ToString(),

                            // Propiedades heredadas de E_Cliente
                            Nombre = reader["nombre"].ToString(),
                            Apellido = reader["apellido"].ToString(),
                            Dni = Convert.ToInt32(reader["dni"]),
                            FechaNac = reader.IsDBNull(reader.GetOrdinal("fecha_nac")) ?
                                      DateTime.MinValue : reader.GetDateTime("fecha_nac"),
                            Direccion = reader["direccion"].ToString(),
                            Telefono = reader["telefono"].ToString(),
                            Email = reader["email"].ToString(),
                            FichaMedica = Convert.ToBoolean(reader["ficha_medica"])
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar no socio por DNI: " + ex.Message);
            }
            finally
            {
                if (conexion?.State == ConnectionState.Open)
                    conexion.Close();
            }

            return noSocio;
        }
    }
}
