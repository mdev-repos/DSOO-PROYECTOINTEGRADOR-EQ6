using System.Data;
using ClubDeportivoApp.Datos;
using MySql.Data.MySqlClient;

namespace ClubDeportivoApp
{
    public partial class DetalleCliente : Form
    {
        private string dni;
        private string esSocio = "";
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
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                mySqlConnection.Open();

                MySqlCommand comando = new MySqlCommand("sp_ObtenerDatosClienteTipoActivo", mySqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@p_dni", dni);

                MySqlDataReader mySqlDataReader = comando.ExecuteReader();
                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read())
                    {
                        esSocio = mySqlDataReader["Codigo"].ToString();

                        lblCliente.Text = mySqlDataReader["Codigo"].ToString();
                        txtBoxResNombre.Text = mySqlDataReader["Nombre"].ToString();
                        txtBoxResApellido.Text = mySqlDataReader["Apellido"].ToString();
                        txtBoxResDni.Text = mySqlDataReader["Dni"].ToString();
                        dtpResFechaNac.Text = mySqlDataReader["Fecha_Nac"].ToString();
                        txtBoxResFichaMed.Text = convertirBooleanoEnString(mySqlDataReader["Ficha_Medica"].ToString());
                        txtBoxResDireccion.Text = mySqlDataReader["Direccion"].ToString();
                        txtBoxResTelefono.Text = mySqlDataReader["Telefono"].ToString();
                        txtBoxResEmail.Text = mySqlDataReader["Email"].ToString();

                        if (esSocio.StartsWith("NO"))
                        {
                            txtBoxResCarnet.Visible = false;
                            lblCarnet.Visible = false;
                            txtBoxResMoroso.Visible = false;
                            lblMoroso.Visible = false;
                            dtpResFechaInscr.Visible = false;
                            lblFechaInscr.Visible = false;
                        }
                        else
                        {
                            txtBoxResCarnet.Text = convertirBooleanoEnString(mySqlDataReader["Carnet"].ToString());
                            txtBoxResMoroso.Text = convertirBooleanoEnString(mySqlDataReader["Moroso"].ToString());
                            dtpResFechaInscr.Text = mySqlDataReader["FechaInscripcion"].ToString();
                            txtBoxResCarnet.Enabled = true;
                            txtBoxResCarnet.ReadOnly = true;
                            txtBoxResMoroso.Enabled = true;
                            txtBoxResMoroso.ReadOnly = true;
                            dtpResFechaInscr.Enabled = true;
                            dtpResFechaInscr.Enabled = true;
                        }
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

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                int fichaMedica = txtBoxResFichaMed.Text.Trim().ToLower() == "sí" ? 1 : 0;
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                mySqlConnection.Open();

                MySqlCommand comando = new MySqlCommand("sp_ActualizarClienteYTipo", mySqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("dni", txtBoxResDni.Text);

                MessageBox.Show("Datos actualizados correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarCliente();
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
    }
}
