using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivoApp.Datos;
using ClubDeportivoApp.Entidades;
using MySql.Data.MySqlClient;

namespace ClubDeportivoApp
{
    public partial class Baja_Socio : Form
    {
        public Baja_Socio()
        {
            InitializeComponent();
            btnReincorporar.Enabled = false;
            btnBaja.Enabled = false;
        }

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            Datos.Socio socioDatos = new Datos.Socio();

            if (!int.TryParse(txtDniInput.Text, out int dni) || txtDniInput.Text.Length < 7)
            {
                MessageBox.Show("Ingrese un DNI válido (7-8 dígitos)", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                String codSocio = $"SOC-{txtDniInput.Text}";
                E_Socio socio = socioDatos.ObtenerSocioPorCodigo(codSocio);

                if (socio == null)
                {
                    MessageBox.Show("No se encontró ningún socio asociado al DNI provisto", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    txtDniInput.ReadOnly = true;
                    txtCodCliente.Text = socio.CodSocio;
                    txtNombreCliente.Text = socio.Nombre;
                    txtApellidoCliente.Text = socio.Apellido;

                    if (socio.Activo)
                    {
                        txtEstadoCliente.Text = "ACTIVO";
                        btnReincorporar.Enabled = false;
                        btnBaja.Enabled = true;
                    }
                    else
                    {
                        txtEstadoCliente.Text = "INACTIVO";
                        btnReincorporar.Enabled = true;
                        btnBaja.Enabled = false;
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "AVISO DEL SISTEMA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodCliente.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtEstadoCliente.Text = "";
            txtDniInput.Text = "";
            txtDniInput.ReadOnly = false;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDniInput.Text))
            {
                MessageBox.Show("Ingrese un DNI válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Datos.Socio socioDatos = new Datos.Socio();
                Datos.CuotaMensual cuotaMensualDatos = new Datos.CuotaMensual();
                string socioDNI = txtDniInput.Text;
                string codSocio = $"SOC-{socioDNI}";

                // Obtener Socio
                E_Socio socio = socioDatos.ObtenerSocioPorCodigo(codSocio);
                if (socio == null)
                {
                    MessageBox.Show("No se encontró el socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener Cuota no pagada
                E_CuotaMensual cuota = cuotaMensualDatos.ObtenerCuotaPorSocio(socio.CodSocio, false);
                if (cuota == null)
                {
                    MessageBox.Show("No se encontró cuota pendiente para este socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // 1. Actualizar vencimiento de la cuota (sumar 100 años)
                        string updateCuotaQuery = @"UPDATE CuotaMensual 
                                      SET Vencimiento = @vencimiento
                                      WHERE CodCuotaMensual = @codCuota";

                        MySqlCommand updateCuotaCmd = new MySqlCommand(updateCuotaQuery, conn, transaction);
                        updateCuotaCmd.Parameters.AddWithValue("@vencimiento", DateTime.Now.AddYears(100));
                        updateCuotaCmd.Parameters.AddWithValue("@codCuota", cuota.CodCuota);
                        updateCuotaCmd.ExecuteNonQuery();

                        // 2. Dar de baja al socio (ACTIVO = FALSE)
                        string updateSocioQuery = @"UPDATE Socio 
                                      SET Activo = @activo
                                      WHERE CodSocio = @codSocio";

                        MySqlCommand updateSocioCmd = new MySqlCommand(updateSocioQuery, conn, transaction);
                        updateSocioCmd.Parameters.AddWithValue("@activo", false);
                        updateSocioCmd.Parameters.AddWithValue("@codSocio", socio.CodSocio);
                        updateSocioCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Baja de socio exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error al procesar la baja: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReincorporar_Click(object sender, EventArgs e)
        {
            Datos.Socio socioDatos = new Datos.Socio();
            Datos.CuotaMensual cuotaMensualDatos = new Datos.CuotaMensual();
            String socioDNI = txtDniInput.Text;
            Boolean pagada = false;

            // Obtener Socio
            E_Socio socio = socioDatos.ObtenerSocioPorCodigo($"SOC-{socioDNI}");

            // Obtener Cuota
            E_CuotaMensual cuota = cuotaMensualDatos.ObtenerCuotaPorSocio(socio.CodSocio, pagada);

            // Definir el Vencimiento de la cuota con fecha de hoy.
            cuota.Vencimiento = DateTime.Now;

            // Actualizar Cuota en BBDD
            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    // Actualizar vencimiento
                    string updateQuery = @"UPDATE CuotaMensual 
                                      SET Vencimiento = @vencimiento
                                      WHERE CodCuotaMensual = @codCuota";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@vencimiento", cuota.Vencimiento);
                    updateCmd.Parameters.AddWithValue("@codCuota", cuota.CodCuota);
                    updateCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el vencimiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // LOGICA DE PAGO
            //APERTURA DE UNA VENTANA PAGAR CON LOS DATOS DE LA CUOTA 
            Pagar formPago = new Pagar(socio, cuota);
            formPago.ShowDialog();

            //RETORNO DEL AREA DE PAGO. MENSAJE DE EXITO EN LA REINCORPORACION
            if (formPago.PagoRealizado)
            {
                // Modificar Socio (ACTIVO = TRUE)
                socio.Activo = true;
                this.Close();
            }

            // Actualizar en BBDD
            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    // Actualizar vencimiento
                    string updateQuery = @"UPDATE Socio 
                                      SET Activo = @activo
                                      WHERE CodSocio = @codSocio";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@activo", socio.Activo);
                    updateCmd.Parameters.AddWithValue("@codSocio", socio.CodSocio);
                    updateCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar al Socio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (MessageBox.Show("REINCORPORACION DE SOCIO EXITOSA", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();

            }

            this.Close();

        }
    }
}
