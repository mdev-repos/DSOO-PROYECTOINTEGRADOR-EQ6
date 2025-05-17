using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using ClubDeportivoApp.Entidades;
using MySql.Data.MySqlClient;

namespace ClubDeportivoApp.Datos
{
    internal class Usuario
    {
        // Método para crear hash de contraseña (usando SHA256)
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool ValidarUsuario(string username, string password)
        {
            bool resultado = false;
            MySqlConnection mySqlConnection = new MySqlConnection();

            try
            {
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                string sql = "SELECT password_hash FROM usuarios WHERE username = @username AND activo = 1";

                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                comando.Parameters.AddWithValue("@username", username);

                mySqlConnection.Open();
                string storedHash = comando.ExecuteScalar()?.ToString();

                if (!string.IsNullOrEmpty(storedHash))
                {
                    string inputHash = HashPassword(password);
                    resultado = storedHash.Equals(inputHash);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario:\n" + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }

            return resultado;
        }

        public string CrearUsuario(E_Usuario usuario)
        {
            string salida;
            MySqlConnection mySqlConnection = new MySqlConnection();

            try
            {
                usuario.PasswordHash = HashPassword(usuario.PasswordHash); // Asumimos que PasswordHash contiene la contraseña en texto plano al crear

                mySqlConnection = Conexion.getInstancia().CrearConexion();
                string sql = @"INSERT INTO usuarios (username, password_hash, rol) 
                              VALUES (@username, @password_hash, @rol)";

                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                comando.Parameters.AddWithValue("@username", usuario.Username);
                comando.Parameters.AddWithValue("@password_hash", usuario.PasswordHash);
                comando.Parameters.AddWithValue("@rol", usuario.Rol);

                mySqlConnection.Open();
                int filasAfectadas = comando.ExecuteNonQuery();

                salida = filasAfectadas > 0 ? "Usuario creado correctamente" : "No se pudo crear el usuario";
            }
            catch (MySqlException ex) when (ex.Number == 1062) // Duplicado
            {
                salida = "El nombre de usuario ya existe";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear usuario:\n" + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public E_Usuario ObtenerUsuarioPorUsername(string username)
        {
            E_Usuario usuario = null;
            MySqlConnection mySqlConnection = new MySqlConnection();

            try
            {
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                string sql = "SELECT id, username, rol, fecha_creacion, activo FROM usuarios WHERE username = @username";

                MySqlCommand comando = new MySqlCommand(sql, mySqlConnection);
                comando.Parameters.AddWithValue("@username", username);

                mySqlConnection.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new E_Usuario
                    {
                        Id = reader.GetInt32("id"),
                        Username = reader.GetString("username"),
                        Rol = reader.GetString("rol"),
                        FechaCreacion = reader.GetDateTime("fecha_creacion"),
                        Activo = reader.GetBoolean("activo")
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener usuario:\n" + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }

            return usuario;
        }

        public void InicializarUsuarioAdmin()
        {
            Usuario usuarioDatos = new Usuario();
            var usuario = usuarioDatos.ObtenerUsuarioPorUsername("admin");

            if (usuario == null)
            {
                E_Usuario admin = new E_Usuario
                {
                    Username = "admin",
                    PasswordHash = "admin123", // Esto se hasheará al crear
                    Rol = "admin"
                };
                usuarioDatos.CrearUsuario(admin);
            }
        }
    }
}
