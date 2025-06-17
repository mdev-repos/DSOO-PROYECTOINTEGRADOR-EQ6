using System.Data;
using ClubDeportivoApp.Datos;
using MySql.Data.MySqlClient;

namespace ClubDeportivoApp
{
    public partial class DetalleCliente : Form
    {
        private string dni;
        public DetalleCliente(string dni)
        {
            InitializeComponent();
            this.dni = dni;
            cargarCliente();
        }

        private void cargarCliente()
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                string query = "";
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                mySqlConnection.Open();
                string tipoQuery = @"SELECT 'socio' AS tipo FROM Socio WHERE Dni = @dni 
                     UNION 
                     SELECT 'nosocio' AS tipo FROM NoSocios WHERE Dni = @dni";

                MySqlCommand tipoCmd = new MySqlCommand(tipoQuery, mySqlConnection);
                tipoCmd.Parameters.AddWithValue("@dni", dni);

                object? result = tipoCmd.ExecuteScalar();
                string? tipo = result != null ? nombreTipoCliente(result.ToString()) : null;

                if (tipo == "Socio")
                {

                    query = @"SELECT c.Nombre, c.Apellido,c.Dni, c.Fecha_Nac, c.Direccion, c.Telefono, c.Email, c.Ficha_Medica, soc.CodSocio as Codigo, soc.Carnet, soc.FechaInscripcion, soc.Moroso
                        FROM Clientes c INNER JOIN Socio soc ON c.Dni = soc.Dni where c.Dni = @dni";
                }
                else if (tipo == "No Socio")
                {
                    query = @"SELECT c.Nombre, c.Apellido, c.Dni,c.Fecha_Nac, c.Direccion, c.Telefono, c.Email, c.Ficha_Medica, noSoc.CodNoSocio as Codigo
                    FROM Clientes c inner join NoSocios noSoc ON c.Dni = noSoc.Dni where c.Dni = @dni";
                }

                MySqlCommand comando = new MySqlCommand(query, mySqlConnection);
                comando.Parameters.AddWithValue("@Dni", dni);
                comando.CommandType = CommandType.Text;

                MySqlDataReader mySqlDataReader;
                mySqlDataReader = comando.ExecuteReader();
                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read())
                    {
                        lblCliente.Text = mySqlDataReader["Codigo"].ToString();
                        txtBoxResNombre.Text = mySqlDataReader["Nombre"].ToString();
                        txtBoxResApellido.Text = mySqlDataReader["Apellido"].ToString();
                        txtBoxResDni.Text = mySqlDataReader["Dni"].ToString();
                        txtBoxResFechaNac.Text = mySqlDataReader["Fecha_Nac"].ToString();
                        txtBoxResFichaMed.Text = convertirBooleanoEnString(mySqlDataReader["Ficha_Medica"].ToString());
                        txtBoxResDireccion.Text = mySqlDataReader["Direccion"].ToString();
                        txtBoxResTelefono.Text = mySqlDataReader["Telefono"].ToString();
                        txtBoxResEmail.Text = mySqlDataReader["Email"].ToString();
                        cBoxTipoCliente.Text = tipo;

                        if (tipo == "Socio")
                        {
                            txtBoxResCarnet.Text = convertirBooleanoEnString(mySqlDataReader["Carnet"].ToString());
                            txtBoxResMoroso.Text = convertirBooleanoEnString(mySqlDataReader["Moroso"].ToString());
                            txtBoxResFechaInscr.Text = mySqlDataReader["FechaInscripcion"].ToString();
                        }

                        modificarEstadoTextBox(tipo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }

        private string convertirBooleanoEnString(String? mySqlDataReader)
        {
            return Convert.ToInt32(mySqlDataReader) == 1 ? "Sí" : "No";
        }

        private string nombreTipoCliente(String? tipo)
        {
            return tipo.Equals("socio") ? "Socio" : "No Socio";
        }
        private void modificarEstadoTextBox(string tipo)
        {
            bool habilitar = tipo.Equals("Socio");

            txtBoxResCarnet.ReadOnly = !habilitar;
            txtBoxResCarnet.Enabled = habilitar;

            txtBoxResMoroso.ReadOnly = !habilitar;
            txtBoxResMoroso.Enabled = habilitar;

            txtBoxResFechaInscr.ReadOnly = !habilitar;
            txtBoxResFechaInscr.Enabled = habilitar;
        }

        private void cBoxTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cBoxTipoCliente.SelectedItem.ToString();
            modificarEstadoTextBox(tipo);
        }

        private void pbVolver_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Opciones>().Any())
            {
                Application.OpenForms.OfType<Opciones>().First().Show();
            }
            else
            {
                Opciones opciones = new Opciones();
                opciones.Show();
            }
            this.Close();
        }
    }
}
