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
    public partial class Comprobantes : Form
    {
        public Comprobantes()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "AVISO DEL SISTEMA",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBuscarComprobantes_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDniInput.Text, out int dni) || txtDniInput.Text.Length < 7)
            {
                MessageBox.Show("Ingrese un DNI válido (7-8 dígitos)", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!VerificarSocioExiste(dni, out string codSocio, out string nombre, out string apellido))
            {
                MessageBox.Show("No se encontró un socio con ese DNI", "Aviso",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtBoxResCod.Text = codSocio;
            txtBoxResNombre.Text = nombre;
            txtBoxResApellido.Text = apellido;

            CargarComprobantes(codSocio);
        }

        private bool VerificarSocioExiste(int dni, out string codSocio, out string nombre, out string apellido)
        {
            codSocio = string.Empty;
            nombre = string.Empty;
            apellido = string.Empty;

            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT s.CodSocio, c.Nombre, c.Apellido 
                            FROM Socio s 
                            JOIN Clientes c ON s.Dni = c.dni 
                            WHERE c.dni = @dni";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@dni", dni);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            codSocio = reader["CodSocio"].ToString();
                            nombre = reader["Nombre"].ToString();
                            apellido = reader["Apellido"].ToString();
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al verificar socio: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        private void CargarComprobantes(string codSocio)
        {
            try
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    string query = @"SELECT 
                            CodCuotaMensual AS CodCuota,
                            DATE_FORMAT(Vencimiento, '%d/%m/%Y') AS FechaVencimiento,
                            ValorMensual AS Monto,
                            DATE_FORMAT(FechaDePago, '%d/%m/%Y') AS FechaPago,
                            TipoDePago
                            FROM CuotaMensual
                            WHERE CodSocio = @codSocio AND Pagada = 1
                            ORDER BY FechaDePago DESC";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@codSocio", codSocio);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvComprobantes.DataSource = table;

                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron comprobantes para este socio.", "Información",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar comprobantes: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvComprobantes.Visible = false;
            dgvComprobantes.AutoGenerateColumns = false;
            dgvComprobantes.Columns.Clear();

            dgvComprobantes.BorderStyle = BorderStyle.Fixed3D;
            dgvComprobantes.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvComprobantes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvComprobantes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 76);
            dgvComprobantes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvComprobantes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvComprobantes.EnableHeadersVisualStyles = false;
            dgvComprobantes.RowHeadersVisible = false;
            dgvComprobantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComprobantes.ColumnHeadersHeight = 35;

            DataGridViewTextBoxColumn colCodCuota = new DataGridViewTextBoxColumn();
            colCodCuota.Name = "CodCuota";
            colCodCuota.HeaderText = "CÓDIGO CUOTA";
            colCodCuota.DataPropertyName = "CodCuota";
            colCodCuota.Width = 230; 
            colCodCuota.DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            DataGridViewTextBoxColumn colFechaVencimiento = new DataGridViewTextBoxColumn();
            colFechaVencimiento.Name = "FechaVencimiento";
            colFechaVencimiento.HeaderText = "VENCIMIENTO";
            colFechaVencimiento.DataPropertyName = "FechaVencimiento";
            colFechaVencimiento.Width = 135;
            colFechaVencimiento.DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            DataGridViewTextBoxColumn colMonto = new DataGridViewTextBoxColumn();
            colMonto.Name = "Monto";
            colMonto.HeaderText = "MONTO";
            colMonto.DataPropertyName = "Monto";
            colMonto.Width = 110;
            colMonto.DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Format = "C2"
            };

            DataGridViewTextBoxColumn colFechaPago = new DataGridViewTextBoxColumn();
            colFechaPago.Name = "FechaPago";
            colFechaPago.HeaderText = "FECHA PAGO";
            colFechaPago.DataPropertyName = "FechaPago";
            colFechaPago.Width = 130;
            colFechaPago.DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            DataGridViewTextBoxColumn colTipoPago = new DataGridViewTextBoxColumn();
            colTipoPago.Name = "TipoDePago";
            colTipoPago.HeaderText = "TIPO PAGO";
            colTipoPago.DataPropertyName = "TipoDePago";
            colTipoPago.Width = 80;
            colTipoPago.DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            DataGridViewButtonColumn colVerDetalle = new DataGridViewButtonColumn();
            colVerDetalle.Name = "VerDetalle";
            colVerDetalle.HeaderText = "DETALLE";
            colVerDetalle.Text = "Ver Detalle";
            colVerDetalle.UseColumnTextForButtonValue = true;
            colVerDetalle.Width = 130;
            colVerDetalle.FlatStyle = FlatStyle.Flat;
            colVerDetalle.DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(70, 130, 180),
                ForeColor = Color.White
            };
            colVerDetalle.CellTemplate.Style.BackColor = Color.FromArgb(70, 130, 180);

            dgvComprobantes.Columns.Add(colCodCuota);
            dgvComprobantes.Columns.Add(colFechaVencimiento);
            dgvComprobantes.Columns.Add(colMonto);
            dgvComprobantes.Columns.Add(colFechaPago);
            dgvComprobantes.Columns.Add(colTipoPago);
            dgvComprobantes.Columns.Add(colVerDetalle);

            dgvComprobantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvComprobantes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            dgvComprobantes.CellClick += (sender, e) =>
            {
                if (e.ColumnIndex == dgvComprobantes.Columns["VerDetalle"].Index && e.RowIndex >= 0)
                {
                    string codCuota = dgvComprobantes.Rows[e.RowIndex].Cells["CodCuota"].Value.ToString();
                    MostrarDetalleComprobante(codCuota);
                }
            };

            dgvComprobantes.DataBindingComplete += (sender, e) =>
            {
                if (dgvComprobantes.Rows.Count > 0)
                {
                    dgvComprobantes.Visible = true;

                    int totalWidth = dgvComprobantes.Width;
                    int usedWidth = 0;

                    foreach (DataGridViewColumn column in dgvComprobantes.Columns)
                    {
                        if (column != colTipoPago)
                            usedWidth += column.Width;
                    }

                    colTipoPago.Width = totalWidth - usedWidth;
                    dgvComprobantes.Refresh();
                }
            };
        }

        private void MostrarDetalleComprobante(string codCuota)
        {
            try
            {
                Datos.CuotaMensual cuotaDatos = new Datos.CuotaMensual();
                E_CuotaMensual cuota = cuotaDatos.ObtenerCuotaCompleta(codCuota);

                if (cuota == null)
                {
                    MessageBox.Show("No se encontró la cuota seleccionada", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Datos.Socio socioDatos = new Datos.Socio();
                E_Socio socio = socioDatos.ObtenerSocioPorCodigo(cuota.CodSocio);

                if (socio == null)
                {
                    MessageBox.Show("No se encontró el socio asociado a la cuota", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Detalle_Comprobante detalleForm = new Detalle_Comprobante(socio, cuota);
                detalleForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar detalle: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
