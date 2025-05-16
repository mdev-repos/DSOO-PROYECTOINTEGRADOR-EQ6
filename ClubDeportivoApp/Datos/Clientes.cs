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
    internal class Clientes
    {
        public string Nuevo_Cliente(E_Cliente cliente)
        {
            string? salida;

            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoCliente", mySqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = cliente.Nombre;
                comando.Parameters.Add("Apellido", MySqlDbType.VarChar).Value = cliente.Apellido;
                comando.Parameters.Add("Dni", MySqlDbType.Int32).Value = cliente.Dni;
                comando.Parameters.Add("FechaNac", MySqlDbType.DateTime).Value = cliente.FechaNac;
                comando.Parameters.Add("Direccion", MySqlDbType.VarChar).Value = cliente.Direccion;
                comando.Parameters.Add("Telefono", MySqlDbType.VarChar).Value = cliente.Telefono;
                comando.Parameters.Add("Email", MySqlDbType.VarChar).Value = cliente.Email;
                comando.Parameters.Add("FichaMedica", MySqlDbType.Bit).Value = cliente.FichaMedica;
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                mySqlConnection.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al guardar cliente:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                salida = ex.Message;
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open) { 
                    mySqlConnection.Close(); 
                }
            }
            return salida;
        }
    }
}
