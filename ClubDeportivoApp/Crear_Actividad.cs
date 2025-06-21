using System.Data;
using ClubDeportivoApp.Datos;
using ClubDeportivoApp.Entidades;
using MySql.Data.MySqlClient;

namespace ClubDeportivoApp
{
    public partial class Crear_Actividad : Form
    {
        private string _codigoOriginal; // Para guardar el código original en MODO modificación
        private bool _actividadEncontrada = false; 

        public Crear_Actividad()
        {
            InitializeComponent();
            ConfigurarControlesIniciales();
        }

        private void ConfigurarControlesIniciales()
        {
            // Estado inicial
            txtCodigo.Enabled = false;
            txtActividad.Enabled = false;
            txtPrecio.Enabled = false;
            txtHorarios.Enabled = false;
            btnBuscarActividad.Enabled = false;
            btnCrearActividad.Enabled = false;
            btnModificar.Enabled = false;
            btnLimpiar.Enabled = true;

            LimpiarCampos();
        }

        private void rbtCrear_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtCrear.Checked)
            {
                ConfigurarControlesIniciales();
                txtActividad.Enabled = true;
                txtPrecio.Enabled = true;
                txtHorarios.Enabled = true;
                btnCrearActividad.Enabled = true;
                txtActividad.Focus();
            }
        }

        private void rbtModificar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtModificar.Checked)
            {
                ConfigurarControlesIniciales();
                txtCodigo.Enabled = true;
                txtCodigo.ReadOnly = false;
                btnBuscarActividad.Enabled = true;
                txtCodigo.Focus();
            }
        }

        private void btnBuscarActividad_Click(object sender, EventArgs e)
        {
            string codActividad = txtCodigo.Text.Trim();

            if (string.IsNullOrWhiteSpace(codActividad) || !codActividad.StartsWith("ACT-"))
            {
                MessageBox.Show("Por favor ingrese un código válido, debe comenzar con 'ACT-'.");
                return;
            }

            try
            {
                using (MySqlConnection mySqlConnection = Conexion.getInstancia().CrearConexion())
                {
                    mySqlConnection.Open();
                    string query = "SELECT Nombre, Valor, Horario FROM Actividades WHERE CodActividad = @codigo";

                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codActividad);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _codigoOriginal = codActividad;
                                _actividadEncontrada = true;

                                txtCodigo.Enabled = false;
                                txtCodigo.ReadOnly = true;

                                txtActividad.Text = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                                txtPrecio.Text = reader.IsDBNull(1) ? "0.00" : reader.GetDouble(1).ToString("F2");
                                txtHorarios.Text = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);

                                txtActividad.Enabled = true;
                                txtPrecio.Enabled = true;
                                txtHorarios.Enabled = true;
                                btnModificar.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ninguna actividad con ese código.",
                                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar actividad: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearActividad_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                E_Actividad actividad = new E_Actividad
                {
                    CodActividad = txtCodigo.Text,
                    Nombre = txtActividad.Text,
                    Valor = float.Parse(txtPrecio.Text),
                    Horario = txtHorarios.Text
                };

                Datos.Actividades actividadDatos = new Datos.Actividades();
                string respuesta = actividadDatos.Nueva_Actividad(actividad);

                if (respuesta == "1")
                {
                    MessageBox.Show("La actividad ya existe", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Actividad '{actividad.Nombre}' creada correctamente con código: {actividad.CodActividad}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimpiar_Click(sender, e); // Usamos el método original
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear actividad: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos() || !_actividadEncontrada) return;

            try
            {
                string nuevoCodigo = "ACT-" + txtActividad.Text.Trim().Replace(" ", "").ToUpper();

                using (MySqlConnection mySqlConnection = Conexion.getInstancia().CrearConexion())
                {
                    mySqlConnection.Open();
                    string query = @"UPDATE Actividades 
                                   SET CodActividad = @nuevoCodigo, 
                                       Nombre = @nombre, 
                                       Valor = @valor, 
                                       Horario = @horario 
                                   WHERE CodActividad = @codigoOriginal";

                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@nuevoCodigo", nuevoCodigo);
                        cmd.Parameters.AddWithValue("@nombre", txtActividad.Text.Trim());
                        cmd.Parameters.AddWithValue("@valor", float.Parse(txtPrecio.Text));
                        cmd.Parameters.AddWithValue("@horario", txtHorarios.Text.Trim());
                        cmd.Parameters.AddWithValue("@codigoOriginal", _codigoOriginal);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show($"Actividad '{txtActividad.Text}' modificada correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnLimpiar_Click(sender, e); 
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar la actividad.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar actividad: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtActividad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtHorarios.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!float.TryParse(txtPrecio.Text, out float precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número válido mayor a cero",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtActividad.Clear();
            txtPrecio.Clear();
            txtHorarios.Clear();
            _codigoOriginal = string.Empty;
            _actividadEncontrada = false;
        }

        private void txtActividad_TextChanged(object sender, EventArgs e)
        {
            if (rbtCrear.Checked || rbtModificar.Checked && !string.IsNullOrWhiteSpace(txtActividad.Text))
            {
                string codigoGenerado = "ACT-" + txtActividad.Text.Trim().Replace(" ", "").ToUpper();
                txtCodigo.Text = codigoGenerado;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ConfigurarControlesIniciales();

            if (rbtCrear.Checked)
            {
                rbtCrear_CheckedChanged_1(sender, e);
            }
            else if (rbtModificar.Checked)
            {
                rbtModificar_CheckedChanged_1(sender, e);
            }
        }

        private void btnVolverActividad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que deseas volver?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}