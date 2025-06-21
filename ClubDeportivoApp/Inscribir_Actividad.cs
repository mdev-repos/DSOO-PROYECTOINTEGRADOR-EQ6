using System.Data;
using System.Globalization;
using ClubDeportivoApp.Datos;
using ClubDeportivoApp.Entidades;
using MySql.Data.MySqlClient;

namespace ClubDeportivoApp
{
    public partial class Inscribir_Actividad : Form
    {
        private string nombreActividad = "";

        public Inscribir_Actividad(string codNoSocio) 
        {
            InitializeComponent();
            txtDni.Text = codNoSocio;
            txtDni.ReadOnly = true;
            btnLimpiar.Enabled = false;
            btnBuscarCliente.Enabled = false;

            CargarDatosClientesYActividad();

            txtBoxNombre.ReadOnly = true;
            txtBoxApellido.ReadOnly = true;
            txtBoxValor.ReadOnly = true;
            txtBoxHorarios.ReadOnly = true;

            // Configurar el DateTimePicker para que no permita fechas anteriores a hoy
            dtpDiaUso.MinDate = DateTime.Today;
            dtpDiaUso.Format = DateTimePickerFormat.Custom;
            dtpDiaUso.CustomFormat = "dd/MM/yyyy";
        }
        public Inscribir_Actividad()
        {
            InitializeComponent();
            txtBoxNombre.ReadOnly = true;
            txtBoxApellido.ReadOnly = true;
            txtBoxValor.ReadOnly = true;
            txtBoxHorarios.ReadOnly = true;

            // Configurar el DateTimePicker para que no permita fechas anteriores a hoy
            dtpDiaUso.MinDate = DateTime.Today;
            dtpDiaUso.Format = DateTimePickerFormat.Custom;
            dtpDiaUso.CustomFormat = "dd/MM/yyyy";
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
            comando.Parameters.AddWithValue("@p_dni", txtDni.Text);

            using (MySqlDataReader mySqlDataReader = comando.ExecuteReader())
            {
                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read())
                    {
                        txtBoxNombre.Text = mySqlDataReader["nombre"].ToString();
                        txtBoxApellido.Text = mySqlDataReader["apellido"].ToString();
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
                        // Formatear el valor como moneda argentina (C2)
                        float valor;
                        if (float.TryParse(mySqlDataReader["Valor"].ToString(), out valor))
                        {
                            txtBoxValor.Text = valor.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR"));
                        }
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
            txtBoxNombre.Clear();
            txtBoxApellido.Clear();
            cBoxActividad.Text = string.Empty;
            txtBoxValor.Clear();
            txtBoxHorarios.Clear();
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

        private int ObtenerUltimoNumeroCuota(string codNoSocio)
        {
            using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    conexion.Open();
                    string query = @"SELECT 
                            IFNULL(MAX(CAST(
                                SUBSTRING(
                                    CodCuotaDiaria, 
                                    8, 
                                    LOCATE('-', CodCuotaDiaria, 8) - 8
                                ) AS UNSIGNED
                            )), 0) AS UltimoNumero
                        FROM CuotaDiaria
                        WHERE CodNoSocio = @codNoSocio";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@codNoSocio", codNoSocio);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch
                {
                    return 0; // Si hay error, empezamos desde 0
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (string.IsNullOrEmpty(txtDni.Text) || string.IsNullOrEmpty(cBoxActividad.Text))
            {
                MessageBox.Show("Debe completar DNI y seleccionar una actividad", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtener datos básicos
                string codNoSocio = $"NOSOC-{txtDni.Text}";
                string nombreActividad = cBoxActividad.SelectedItem.ToString();

                // Generar código de actividad con prefijo
                string codActividad = $"ACT-{nombreActividad}";

                // Obtener el último número de cuota
                int ultimoNumero = ObtenerUltimoNumeroCuota(codNoSocio);
                int nuevoNumero = ultimoNumero + 1;

                // Generar código de cuota
                string codCuotaNueva = $"CUOTA-0{nuevoNumero}-{codNoSocio}";

                // Crear objeto cuota
                E_CuotaDiaria cuotaDiaria = new E_CuotaDiaria
                {
                    CodCuotaDiaria = codCuotaNueva,
                    ValorFinal = float.Parse(txtBoxValor.Text.Replace("$", "").Replace(".", "").Replace(",", "."),
                                               CultureInfo.InvariantCulture),
                    FechaDeUso = dtpDiaUso.Value.ToString("dd/MM/yyyy"),
                    CodNoSocio = codNoSocio,
                    CodActividad = $"ACT-{cBoxActividad.Text}"
                };

                // Persistir en BD
                Datos.CuotaDiaria datosCuota = new Datos.CuotaDiaria();
                string resultado = datosCuota.CrearCuotaDiariaParcial(cuotaDiaria, out string codCuotaGenerada);

                if (resultado == "0")
                {
                    // Abrir formulario de pago
                    cuotaDiaria.CodCuotaDiaria = codCuotaGenerada;
                    Form pagarActividadWdw = new Pagar_Actividad(cuotaDiaria);
                    pagarActividadWdw.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error al generar la cuota: {resultado}", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor de la actividad no es válido", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                          
        }
    }
}