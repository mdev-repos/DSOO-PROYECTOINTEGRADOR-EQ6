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
    }
}
