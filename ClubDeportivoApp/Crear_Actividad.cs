using System.Data;
using ClubDeportivoApp.Datos;
using ClubDeportivoApp.Entidades;
using MySql.Data.MySqlClient;

namespace ClubDeportivoApp
{
    public partial class Crear_Actividad : Form
    {
        public Crear_Actividad()
        {
            InitializeComponent();
            ConfigurarControlesIniciales();
        }

        private void ConfigurarControlesIniciales()
        {
            // Configuración inicial basada en el RadioButton seleccionado
            if (rbtCrear.Checked)
            {
                btnModificar.Enabled = false;
                btnBuscarActividad.Enabled = false;
                txtCodigo.ReadOnly = true;
                btnCrearActividad.Enabled = true;
            }
            else
            {
                btnCrearActividad.Enabled = false;
            }
        }

        private void btnVolverActividad_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas volver?",
                                             "Confirmación",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtActividad_TextChanged(object sender, EventArgs e)
        {
            if (rbtCrear.Checked && !string.IsNullOrWhiteSpace(txtActividad.Text))
            {
                // Generar código automático solo en modo creación
                txtCodigo.Text = "ACT-" + txtActividad.Text.Replace(" ", "-");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
            txtActividad.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtHorarios.Text = string.Empty;

            if (rbtCrear.Checked)
            {
                txtCodigo.ReadOnly = true;
            }
        }

        private void btnCrearActividad_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtActividad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtHorarios.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar formato del precio
            if (!float.TryParse(txtPrecio.Text, out float precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número válido mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string respuesta;
                E_Actividad actividad = new E_Actividad();
                actividad.CodActividad = txtCodigo.Text;
                actividad.Nombre = txtActividad.Text;
                actividad.Valor = float.Parse(txtPrecio.Text);
                actividad.Horario = txtHorarios.Text;

                Datos.Actividades actividadDatos = new Datos.Actividades();
                respuesta = actividadDatos.Nueva_Actividad(actividad);
                bool esNumero = int.TryParse(respuesta, out int codigo);
                if (esNumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("La actividad ya existe", "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"La actividad {actividad.Nombre} se registró con éxito con el código número: {actividad.CodActividad} " + respuesta,
                                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear actividad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtActividad.Clear();
            txtPrecio.Clear();
            txtHorarios.Clear();
            btnModificar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection();

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtActividad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtHorarios.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar formato del precio
            if (!float.TryParse(txtPrecio.Text, out float precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número válido mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lógica para modificar la actividad
            try
            {
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                mySqlConnection.Open();
                
                string query = @"UPDATE Actividades 
                 SET Nombre = @nombre, Valor = @valor, Horario = @horario 
                 WHERE CodActividad = @codigo";

                using (mySqlConnection)
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtActividad.Text.Trim());
                        cmd.Parameters.AddWithValue("@valor", precio); // ya validado como float
                        cmd.Parameters.AddWithValue("@horario", txtHorarios.Text.Trim());
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text.Trim());

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Actividad modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ninguna actividad con ese código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar actividad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void btnBuscarActividad_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection();

            string codActividad = txtCodigo.Text.Trim();

            if (string.IsNullOrWhiteSpace(codActividad) || !codActividad.StartsWith("ACT-"))
            {
                MessageBox.Show("Por favor ingrese un código válido, debe comenzar con 'ACT-'.");
                return;
            }
            try
            {
                mySqlConnection = Conexion.getInstancia().CrearConexion();
                mySqlConnection.Open();
                string query = "SELECT Nombre, Valor, Horario FROM Actividades WHERE CodActividad = @codigo";

                using(mySqlConnection)
                {
                    //conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codActividad);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtActividad.Text = reader.IsDBNull(reader.GetOrdinal("Nombre"))
                                    ? string.Empty
                                    : reader.GetString(reader.GetOrdinal("Nombre"));

                                txtPrecio.Text = reader.IsDBNull(reader.GetOrdinal("Valor"))
                                    ? "0.00"
                                    : reader.GetDouble(reader.GetOrdinal("Valor")).ToString("F2");

                                txtHorarios.Text = reader.IsDBNull(reader.GetOrdinal("Horario"))
                                    ? string.Empty
                                    : reader.GetString(reader.GetOrdinal("Horario"));
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ninguna actividad con ese código.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar actividad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, backspace y decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbtCrear_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtCrear.Checked)
            {
                btnModificar.Enabled = false;
                btnBuscarActividad.Enabled = false;
                txtCodigo.ReadOnly = true;
                btnCrearActividad.Enabled = true;

                // Limpiar campos al cambiar de modo
                btnLimpiar_Click(sender, e);
            }
        }

        private void rbtModificar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtModificar.Checked)
            {
                btnCrearActividad.Enabled = false;
                btnModificar.Enabled = true;
                btnBuscarActividad.Enabled = true;
                txtCodigo.ReadOnly = false; // Habilitado para buscar

                // Limpiar campos al cambiar de modo
                btnLimpiar_Click(sender, e);
            }
        }
    }
}