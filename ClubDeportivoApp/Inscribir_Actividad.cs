using System.Data;
using ClubDeportivoApp.Datos;
using MySql.Data.MySqlClient;

namespace ClubDeportivoApp
{
    public partial class Inscribir_Actividad : Form
    {
        private string nombreActividad = "";
        public Inscribir_Actividad()
        {
            InitializeComponent();
        }

        private void CargarDatosClientesYActividad()
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                mySqlConnection.Open();

                CargarDatosCliente(mySqlConnection);
                CargarActividades(mySqlConnection);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void CargarDatosCliente(MySqlConnection mySqlConnection)
        {
            MySqlCommand comando = new MySqlCommand("BuscarNoSocioPorDni", mySqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dni", txtDni.Text);

            using (MySqlDataReader mySqlDataReader = comando.ExecuteReader())
            {
                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read())
                    {
                        txtBoxNombre.Text = mySqlDataReader["Nombre"].ToString();
                        txtBoxApellido.Text = mySqlDataReader["Apellido"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el cliente.", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarActividades(MySqlConnection mySqlConnection)
        {
            cBoxActividad.Items.Clear();
            MySqlCommand comando = new MySqlCommand("ObtenerNombresActividades", mySqlConnection);
            comando.CommandType = CommandType.StoredProcedure;

            using (MySqlDataReader mySqlDataReader = comando.ExecuteReader())
            {
                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read())
                    {
                        cBoxActividad.Items.Add(mySqlDataReader["Nombre"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No hay actividades.", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cBoxActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreActividad = cBoxActividad.SelectedItem.ToString();
            using (MySqlConnection mySqlConnection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    mySqlConnection.Open();
                    ObtenerDatosActividades(mySqlConnection);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos de la actividad: " + ex.Message);
                }
            }
        }

        private void ObtenerDatosActividades(MySqlConnection mySqlConnection)
        {
            MySqlCommand comando = new MySqlCommand("ObtenerDatosActividades", mySqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("nombre", nombreActividad);

            using (MySqlDataReader mySqlDataReader = comando.ExecuteReader())
            {
                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read())
                    {
                        txtBoxValor.Text = mySqlDataReader["Valor"].ToString();
                        txtBoxHorarios.Text = mySqlDataReader["Horario"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro informacion.", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDni.Clear();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            CargarDatosClientesYActividad();
        }

        private void pbVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "AVISO DEL SISTEMA",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) || txtDni.Text.Length >= 12);
        }
    }
}
