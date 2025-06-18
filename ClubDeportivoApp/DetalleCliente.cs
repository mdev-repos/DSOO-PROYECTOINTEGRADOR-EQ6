using System.Data;
using ClubDeportivoApp.Datos;
using MySql.Data.MySqlClient;

namespace ClubDeportivoApp
{
    public partial class DetalleCliente : Form
    {
        private string dni;
        string? tipo = "";
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
                        tipo = mySqlDataReader["TipoCliente"].ToString();
                        
                        lblCliente.Text = mySqlDataReader["Codigo"].ToString();
                        txtBoxResNombre.Text = mySqlDataReader["Nombre"].ToString();
                        txtBoxResApellido.Text = mySqlDataReader["Apellido"].ToString();
                        txtBoxResDni.Text = mySqlDataReader["Dni"].ToString();
                        dtpResFechaNac.Text = mySqlDataReader["Fecha_Nac"].ToString();
                        txtBoxResFichaMed.Text = convertirBooleanoEnString(mySqlDataReader["Ficha_Medica"].ToString());
                        txtBoxResDireccion.Text = mySqlDataReader["Direccion"].ToString();
                        txtBoxResTelefono.Text = mySqlDataReader["Telefono"].ToString();
                        txtBoxResEmail.Text = mySqlDataReader["Email"].ToString();
                        cBoxTipoCliente.Text = tipo;

                        if (tipo == "Socio")
                        {
                            txtBoxResCarnet.Text = convertirBooleanoEnString(mySqlDataReader["Carnet"].ToString());
                            txtBoxResMoroso.Text = convertirBooleanoEnString(mySqlDataReader["Moroso"].ToString());
                            dtpResFechaInscr.Text = mySqlDataReader["FechaInscripcion"].ToString();
                        }
                    }
                    modificarEstadoTextBox();
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

        private void modificarEstadoTextBox()
        {
            bool habilitar = tipo.Equals("Socio");

            txtBoxResCarnet.Visible = habilitar;
            lblCarnet.Visible = habilitar;
            txtBoxResMoroso.Visible = habilitar;
            lblMoroso.Visible = habilitar;
            dtpResFechaInscr.Visible = habilitar;
            lblFechaInscr.Visible = habilitar;
        }

        private void cBoxTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo = cBoxTipoCliente.SelectedItem.ToString();
            modificarEstadoTextBox();
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

                comando.Parameters.AddWithValue("@p_dni", Convert.ToInt32(txtBoxResDni.Text));
                comando.Parameters.AddWithValue("@p_nombre", txtBoxResNombre.Text.Trim());
                comando.Parameters.AddWithValue("@p_apellido", txtBoxResApellido.Text.Trim());
                comando.Parameters.AddWithValue("@p_fecha_nac", DateTime.Parse(dtpResFechaNac.Text));
                comando.Parameters.AddWithValue("@p_direccion", txtBoxResDireccion.Text.Trim());
                comando.Parameters.AddWithValue("@p_telefono", txtBoxResTelefono.Text.Trim());
                comando.Parameters.AddWithValue("@p_email", txtBoxResEmail.Text.Trim());
                comando.Parameters.AddWithValue("@p_ficha_medica", fichaMedica);
                comando.Parameters.AddWithValue("@p_nuevo_tipo_cliente", tipo);

                comando.ExecuteNonQuery();

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
