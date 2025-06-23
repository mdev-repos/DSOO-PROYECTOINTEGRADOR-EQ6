using System.Data;
using ClubDeportivoApp.Datos;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using ClubDeportivoApp.Entidades;
using System.Globalization;

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
            this.BringToFront();
            this.Activate();
        }

        private void CargarDatosAutomaticos(E_Socio socio, E_CuotaMensual cuota)
        {
            // Llenar campos con datos del socio y cuota
            txtDni.Text = socio.Dni.ToString();
            txtBoxResNombre.Text = socio.Nombre;
            txtBoxResApellido.Text = socio.Apellido;
            txtBoxResCodCuota.Text = cuota.CodCuota;
            txtBoxResCod.Text = socio.CodSocio;
            txtBoxResValor.Text = cuota.ValorMensual.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR"));
            txtBoxResVencimiento.Text = cuota.Vencimiento.ToString("dd/MM/yyyy");

            cbResTipoPago.SelectedItem = "Efectivo";
            cbCuotas.Enabled = false;
            txtValorCuota.Text = txtBoxResValor.Text;

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
            txtDni.ReadOnly = true;
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
                
                query = @"SELECT c.Nombre, c.Apellido, soc.CodSocio, cuotMens.ValorMensual, cuotMens.TipoDePago, cuotMens.Vencimiento, cuotMens.CodCuotaMensual
                        FROM Clientes c INNER JOIN Socio soc ON c.Dni = soc.Dni INNER JOIN CuotaMensual cuotMens 
                        ON soc.CodSocio = cuotMens.CodSocio where c.Dni = @dni";
            
           

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

                        txtBoxResCodCuota.Text = mySqlDataReader["CodCuotaMensual"].ToString();
                        txtBoxResCod.Text = mySqlDataReader["CodSocio"].ToString();
                            
                        // Moneda Argentina
                        decimal valor = Convert.ToDecimal(mySqlDataReader["ValorMensual"]);
                        txtBoxResValor.Text = valor.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR"));

                        cbResTipoPago.Text = mySqlDataReader["TipoDePago"].ToString();
                            
                        // Fecha dd/MM/yyyy
                        if (DateTime.TryParse(mySqlDataReader["Vencimiento"].ToString(), out DateTime fecha))
                        {
                            txtBoxResVencimiento.Text = fecha.ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            txtBoxResVencimiento.Text = "Fecha inválida";
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
                if (MessageBox.Show("¿Está seguro que desea salir?", "AVISO DEL SISTEMA",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
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

                    // Guardamos el código de cuota para reutilizarlo
                    string codCuotaPagada = txtBoxResCodCuota.Text;

                    // Actualizar pago
                    string updateQuery = @"UPDATE CuotaMensual 
                                  SET Pagada = 1, 
                                      TipoDePago = @tipoPago,
                                      CantidadCuotas = @cantidadCuotas,
                                      FechaDePago = @fechaPago 
                                  WHERE CodCuotaMensual = @codCuota";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@tipoPago", cbResTipoPago.Text);

                    if (cbCuotas.SelectedItem != null)
                    {
                        int.TryParse(cbCuotas.SelectedItem.ToString(), out int cantidadCuotas);
                        updateCmd.Parameters.AddWithValue("@cantidadCuotas", cantidadCuotas);
                    }
                    
                    updateCmd.Parameters.AddWithValue("@fechaPago", DateTime.Now.ToString("dd/MM/yyyy"));
                    updateCmd.Parameters.AddWithValue("@codCuota", txtBoxResCodCuota.Text);
                    updateCmd.ExecuteNonQuery();

                    // 2. Generar nueva cuota
                    CuotaMensual cuotaDatos = new CuotaMensual();
                    string respuesta = cuotaDatos.GenerarNuevaCuota(codCuotaPagada, out string nuevaCodCuota);

                    if (respuesta == "0")
                    {
                        PagoRealizado = true;

                        // 3. Mostrar comprobante de pago
                        Datos.CuotaMensual datosCuota = new Datos.CuotaMensual();
                        E_CuotaMensual cuota = datosCuota.ObtenerCuotaCompleta(codCuotaPagada);

                        if (cuota != null)
                        {
                            Datos.Socio socioDatos = new Datos.Socio();
                            E_Socio socio = socioDatos.ObtenerSocioPorCodigo(cuota.CodSocio);

                            if (socio != null)
                            {
                                Detalle_Comprobante comprobante = new Detalle_Comprobante(socio, cuota);
                                comprobante.ShowDialog();
                            }
                        }

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

        private void cbCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCuotas.SelectedItem != null && int.TryParse(cbCuotas.SelectedItem.ToString(), out int cuotas))
            {
                if (cuotas == 1 || cuotas == 3 || cuotas == 6)
                {
                    string valorTexto = txtBoxResValor.Text;

                    string valorLimpio = valorTexto.Replace("$", "").Replace(".", "").Replace(",", ".");

                    if (decimal.TryParse(valorLimpio, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal total))
                    {
                        decimal precioCuota = total / cuotas;
                        txtValorCuota.Text = precioCuota.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR"));
                    }
                    else
                    {
                        txtValorCuota.Text = "$0,00";
                    }
                }
            }
        }

        private void cbResTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbResTipoPago.SelectedItem != null && cbResTipoPago.SelectedItem.ToString() == "Tarjeta de crédito")
            {
                cbCuotas.Enabled = true;
            }
            else
            {
                cbCuotas.Enabled = false;
                cbCuotas.SelectedIndex = 0; // Restablece el número de cuotas a 1
            }
        }

        private void cbCuotas_DropDown(object sender, EventArgs e)
        {
            if (cbResTipoPago.SelectedItem?.ToString() == "Tarjeta de Crédito")
            {
                cbCuotas.SelectedIndex = 0; // Siempre mantiene la primera opción
            }
        }

        private void btnComprobantePago_Click(object sender, EventArgs e)
        {
            //Limpiar todos los TextBox
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.Clear(); // Borra el contenido de los TextBox
                }
            }

            // Restablecer los ComboBox a su primera opción
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox cb && cb.Items.Count > 0)
                {
                    cb.SelectedIndex = 0; // Selecciona el primer elemento disponible
                }
            }
        }
    }
}
