using System.Data;
using ClubDeportivoApp.Datos;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using ClubDeportivoApp.Entidades;

namespace ClubDeportivoApp
{
    public partial class Pagar : Form
    {
        private bool _esModoInscripcion;
        public bool PagoRealizado { get; private set; }

        // Constructor original (para búsqueda manual)
        public Pagar()
        {
            InitializeComponent();
            ConfigurarVentana();
        }

        // Constructor para inscripción (con parámetros)
        public Pagar(E_Socio socio, E_CuotaMensual cuota) : this()
        {
            _esModoInscripcion = true;
            CargarDatosAutomaticos(socio, cuota);
            BloquearBusqueda();
        }

        private void ConfigurarVentana()
        {
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
            this.Activate();
        }

        private void CargarDatosAutomaticos(E_Socio socio, E_CuotaMensual cuota)
        {
            // Llenar campos con datos del socio y cuota
            txtBoxResNombre.Text = socio.Nombre;
            txtBoxResApellido.Text = socio.Apellido;
            txtBoxResCodCuota.Text = cuota.CodCuota;
            txtBoxResCod.Text = socio.CodSocio;
            txtBoxResValor.Text = cuota.ValorMensual.ToString("F2");
            txtBoxResVencimiento.Text = cuota.Vencimiento.ToString("yyyy-MM-dd");

            // Deshabilitar campos (excepto tipo de pago)
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt && txt != txtDni)
                {
                    txt.ReadOnly = true;
                }
            }
        }

        private void BloquearBusqueda()
        {
            // Ocultar elementos de búsqueda
            txtDni.Visible = false;
            btnBuscarCliente.Visible = false;
            label1.Text = "PAGO DE CUOTA DE INSCRIPCIÓN";
            this.Text = "Pago de inscripción";
            pbVolver.Visible = false; // Ocultar botón volver en modo inscripción
        }


        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (_esModoInscripcion) return;

            MySqlConnection mySqlConnection = new MySqlConnection();
            try
            {
                string query;
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                mySqlConnection.Open();
                string tipoQuery = @"SELECT 'socio' AS tipo FROM Socio WHERE Dni = @dni 
                     UNION 
                     SELECT 'nosocio' AS tipo FROM NoSocios WHERE Dni = @dni";

                MySqlCommand tipoCmd = new MySqlCommand(tipoQuery, mySqlConnection);
                tipoCmd.Parameters.AddWithValue("@dni", txtDni.Text);

                object? result = tipoCmd.ExecuteScalar();
                string? tipo = result != null ? result.ToString() : null;

                if (tipo == null)
                {
                    MessageBox.Show("El cliente no está registrado como socio ni como no socio.");
                    return;
                }

                if (tipo == "socio")
                {

                    query = @"SELECT c.Nombre, c.Apellido, soc.CodSocio, cuotMens.ValorMensual, cuotMens.TipoDePago, cuotMens.Vencimiento, cuotMens.CodCuotaMensual
                        FROM Clientes c INNER JOIN Socio soc ON c.Dni = soc.Dni INNER JOIN CuotaMensual cuotMens 
                        ON soc.CodSocio = cuotMens.CodSocio where c.Dni = @dni";
                }
                else if (tipo == "nosocio")
                {
                    query = @"SELECT c.Nombre, c.Apellido,noSoc.CodNoSocio, cuotDia.ValorFinal, cuotDia.TipoDePago, cuotDia.CodCuotaDiaria
                    FROM Clientes c inner join NoSocios noSoc ON c.Dni = noSoc.Dni inner join Actividades act 
                    ON noSoc.CodNoSocio = act.CodNoSocio inner join CuotaDiaria cuotDia ON cuotDia.CodNoSocio 
                    = noSoc.CodNoSocio where c.Dni = @dni";
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado como socio ni no socio.");
                    return;
                }

                MySqlCommand comando = new MySqlCommand(query, mySqlConnection);
                comando.Parameters.AddWithValue("@Dni", txtDni.Text);
                comando.CommandType = CommandType.Text;


                MySqlDataReader mySqlDataReader;
                mySqlDataReader = comando.ExecuteReader();
                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read())
                    {
                        txtBoxResNombre.Text = mySqlDataReader["Nombre"].ToString();
                        txtBoxResApellido.Text = mySqlDataReader["Apellido"].ToString();

                        if (tipo == "socio")
                        {
                            txtBoxResCodCuota.Text = mySqlDataReader["CodCuotaMensual"].ToString();
                            txtBoxResCod.Text = mySqlDataReader["CodSocio"].ToString();
                            txtBoxResValor.Text = mySqlDataReader["ValorMensual"].ToString();
                            cbResTipoPago.Text = mySqlDataReader["TipoDePago"].ToString();
                            txtBoxResVencimiento.Text = mySqlDataReader["Vencimiento"].ToString();
                        }
                        else if (tipo == "nosocio")
                        {
                            txtBoxResCodCuota.Text = mySqlDataReader["CodCuotaDiaria"].ToString();
                            txtBoxResCod.Text = mySqlDataReader["CodNoSocio"].ToString();
                            txtBoxResValor.Text = mySqlDataReader["ValorFinal"].ToString();
                            cbResTipoPago.Text = mySqlDataReader["TipoDePago"].ToString();
                            txtBoxResVencimiento.Text = "No posee.";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro el cliente.", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pbVolver_Click(object sender, EventArgs e)
        {
            if (!_esModoInscripcion)
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

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_esModoInscripcion)
            {
                e.Handled = !char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) || txtDni.Text.Length >= 12);
            }
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbResTipoPago.Text))
            {
                MessageBox.Show("Seleccione un método de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Actualizar cuota actual como pagada
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    // Actualizar pago
                    string updateQuery = @"UPDATE CuotaMensual 
                                  SET Pagada = 1, 
                                      TipoDePago = @tipoPago, 
                                      FechaDePago = @fechaPago 
                                  WHERE CodCuotaMensual = @codCuota";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@tipoPago", cbResTipoPago.Text);
                    updateCmd.Parameters.AddWithValue("@fechaPago", DateTime.Now.ToString("yyyy-MM-dd"));
                    updateCmd.Parameters.AddWithValue("@codCuota", txtBoxResCodCuota.Text);
                    updateCmd.ExecuteNonQuery();

                    // 2. Generar nueva cuota
                    CuotaMensual cuotaDatos = new CuotaMensual();
                    string respuesta = cuotaDatos.GenerarNuevaCuota(txtBoxResCodCuota.Text, out string nuevaCodCuota);

                    if (respuesta == "0")
                    {
                        PagoRealizado = true;
                        MessageBox.Show($"Pago registrado. Nueva cuota generada: {nuevaCodCuota}",
                                      "Éxito",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Pago registrado pero hubo un error al generar la nueva cuota",
                                      "Advertencia",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
