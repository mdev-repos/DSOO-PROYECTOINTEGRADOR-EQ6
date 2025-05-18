using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubDeportivoApp.Entidades;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace ClubDeportivoApp.Datos
{
    internal class Socio
    {
        public string Nuevo_Socio(E_Socio socio)
        {
            string? salida;
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoSocio", mySqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("CodSocio", MySqlDbType.VarChar).Value = socio.CodSocio;
                comando.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = socio.Nombre;
                comando.Parameters.Add("Apellido", MySqlDbType.VarChar).Value = socio.Apellido;
                comando.Parameters.Add("Dni", MySqlDbType.Int32).Value = socio.Dni;
                comando.Parameters.Add("FechaNac", MySqlDbType.DateTime).Value = socio.FechaNac;
                comando.Parameters.Add("Direccion", MySqlDbType.VarChar).Value = socio.Direccion;
                comando.Parameters.Add("Telefono", MySqlDbType.VarChar).Value = socio.Telefono;
                comando.Parameters.Add("Email", MySqlDbType.VarChar).Value = socio.Email;
                comando.Parameters.Add("FichaMedica", MySqlDbType.Bit).Value = socio.FichaMedica;
                comando.Parameters.Add("Carnet", MySqlDbType.Bit).Value = socio.Carnet;
                comando.Parameters.Add("FechaInscripcion", MySqlDbType.VarChar).Value = socio.FechaInscripcion;
                comando.Parameters.Add("Moroso", MySqlDbType.Bit).Value = socio.Moroso;
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
                MessageBox.Show("Error al guardar socio:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public List<DTO_SocioMoroso> ListarSociosMorosos()
        {
            var lista = new List<DTO_SocioMoroso>();
            MySqlConnection conexion = null;

            try
            {
                conexion = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("ListarSociosMorosos", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                conexion.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var socioMoroso = new DTO_SocioMoroso
                    {
                        CodSocio = reader.IsDBNull("CodSocio") ? string.Empty : reader.GetString("CodSocio"),
                        Apellido = reader.IsDBNull("apellido") ? string.Empty : reader.GetString("apellido"),
                        Nombre = reader.IsDBNull("nombre") ? string.Empty : reader.GetString("nombre"),
                        Dni = reader.IsDBNull("dni") ? 0 : reader.GetInt32("dni"),
                        Vencimiento = reader.IsDBNull("Vencimiento") ? DateTime.MinValue : reader.GetDateTime("Vencimiento")
                    };

                    lista.Add(socioMoroso);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar socios morosos:\n" + ex.Message, "Error",
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