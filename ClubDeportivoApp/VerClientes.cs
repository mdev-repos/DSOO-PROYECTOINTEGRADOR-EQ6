using System.Data;
using ClubDeportivoApp.Datos;
using MySql.Data.MySqlClient;

namespace ClubDeportivoApp
{
    public partial class VerClientes : Form
    {
        private Boolean isBuscar = false;
        public VerClientes()
        {
            InitializeComponent();
            CargarDatosClientes();
        }

        private void CargarDatosClientes()
        {
            try
            {
                string query;
                MySqlConnection mySqlConnection = Conexion.getInstancia().CrearConexion();
                mySqlConnection.Open();

                if (!isBuscar)
                {
                    query = @"SELECT Nombre, Apellido, Dni FROM Clientes";
                }
                else
                {
                    query = @"SELECT Nombre, Apellido, Dni FROM Clientes WHERE Dni = @dni";
                }

                MySqlCommand comando = new MySqlCommand(query, mySqlConnection);

                if (isBuscar)
                {
                    comando.Parameters.AddWithValue("@dni", txtDni.Text);
                }

                comando.CommandType = CommandType.Text;

                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                if (tabla.Rows.Count == 0)
                {
                    DataTable tablaMensaje = new DataTable();
                    tablaMensaje.Columns.Add("Mensaje");
                    tablaMensaje.Rows.Add("No hay clientes inscriptos aún.");
                    dgvClientes.DataSource = tablaMensaje;
                }
                else
                {
                    dgvColumnaVerMas(tabla);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void dgvColumnaVerMas(DataTable tabla)
        {
            dgvClientes.DataSource = tabla;

            if (!dgvClientes.Columns.Contains("VerMas"))
            {
                DataGridViewButtonColumn btnVerMas = new DataGridViewButtonColumn();
                btnVerMas.Name = "VerMas";
                btnVerMas.Text = "Ver más info";
                btnVerMas.UseColumnTextForButtonValue = true;
                btnVerMas.FlatStyle = FlatStyle.Flat;
                dgvClientes.Columns.Add(btnVerMas);
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.Columns[e.ColumnIndex].Name == "VerMas" && e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
                string dni = fila.Cells["Dni"].Value?.ToString() ?? "";

                DetalleCliente detallesForm = new DetalleCliente(dni);
                detallesForm.ShowDialog();
            }
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

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) || txtDni.Text.Length >= 12);

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            isBuscar = !string.IsNullOrWhiteSpace(txtDni.Text);
            CargarDatosClientes();
        }

        private void btnComprobantePago_Click(object sender, EventArgs e)
        {
            isBuscar = false;
            CargarDatosClientes();
        }
    }
}
