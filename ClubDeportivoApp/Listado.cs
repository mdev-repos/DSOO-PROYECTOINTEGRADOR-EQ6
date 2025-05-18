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

namespace ClubDeportivoApp
{
    public partial class Listado : Form
    {
        private readonly Socio _socioDatos;

        public Listado()
        {
            InitializeComponent();
            _socioDatos = new Socio();
            ConfigurarDataGridView();
            CargarMorosos();
        }

        private void ConfigurarDataGridView()
        {
            // Limpiamos columnas auto-generadas
            dgvMorosos.AutoGenerateColumns = false;
            dgvMorosos.Columns.Clear();

            // Configuración básica del grid
            dgvMorosos.BackgroundColor = Color.Linen;
            dgvMorosos.BorderStyle = BorderStyle.None;
            dgvMorosos.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvMorosos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvMorosos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(120, 10, 90);
            dgvMorosos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMorosos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMorosos.EnableHeadersVisualStyles = false;
            dgvMorosos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvMorosos.AllowUserToResizeRows = false;
            dgvMorosos.RowHeadersVisible = false;

            // Configuración de columnas manualmente (solo las 5 solicitadas)
            var columns = new[]
            {
                new DataGridViewTextBoxColumn {
                    Name = "CodSocio",
                    HeaderText = "CÓDIGO",
                    DataPropertyName = "CodSocio",
                    Width = 120,
                    DefaultCellStyle = new DataGridViewCellStyle {
                        Alignment = DataGridViewContentAlignment.MiddleCenter,
                        BackColor = Color.Linen,
                        ForeColor = Color.Black
                    }
                },
                new DataGridViewTextBoxColumn {
                    Name = "Apellido",
                    HeaderText = "APELLIDO",
                    DataPropertyName = "Apellido",
                    Width = 180,
                    DefaultCellStyle = new DataGridViewCellStyle {
                        Alignment = DataGridViewContentAlignment.MiddleLeft
                    }
                },
                new DataGridViewTextBoxColumn {
                    Name = "Nombre",
                    HeaderText = "NOMBRE",
                    DataPropertyName = "Nombre",
                    Width = 180,
                    DefaultCellStyle = new DataGridViewCellStyle {
                        Alignment = DataGridViewContentAlignment.MiddleLeft
                    }
                },
                new DataGridViewTextBoxColumn {
                    Name = "Dni",
                    HeaderText = "DNI",
                    DataPropertyName = "Dni",
                    Width = 120,
                    DefaultCellStyle = new DataGridViewCellStyle {
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    }
                },
                new DataGridViewTextBoxColumn {
                    Name = "Vencimiento",
                    HeaderText = "VENCIMIENTO",
                    DataPropertyName = "Vencimiento",
                    Width = 150,
                    DefaultCellStyle = new DataGridViewCellStyle {
                        Alignment = DataGridViewContentAlignment.MiddleCenter,
                        Format = "dd/MM/yyyy"
                    }
                }
            };

            dgvMorosos.Columns.AddRange(columns);

            // Configurar scroll
            dgvMorosos.ScrollBars = ScrollBars.Vertical;

            // Alternar colores de filas para mejor legibilidad
            dgvMorosos.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        private void CargarMorosos()
        {
            try
            {
                var morosos = _socioDatos.ListarSociosMorosos();

                var datosParaMostrar = morosos.Select(m => new
                {
                    m.CodSocio,
                    m.Apellido,
                    m.Nombre,
                    m.Dni,
                    Vencimiento = m.Vencimiento.ToString("dd/MM/yyyy")
                }).ToList();

                dgvMorosos.DataSource = datosParaMostrar;

                // Resaltar filas según vencimiento
                foreach (DataGridViewRow row in dgvMorosos.Rows)
                {
                    if (row.Cells["Vencimiento"].Value != null)
                    {
                        var fechaStr = row.Cells["Vencimiento"].Value.ToString();
                        if (DateTime.TryParse(fechaStr, out DateTime vencimiento))
                        {
                            var diasVencidos = (DateTime.Today - vencimiento).Days;

                            if (diasVencidos == 0) // Vence hoy
                            {
                                row.DefaultCellStyle.BackColor = Color.LightYellow;
                                row.DefaultCellStyle.Font = new Font(dgvMorosos.Font, FontStyle.Bold);
                            }
                            else if (diasVencidos > 0) // Vencido
                            {
                                row.DefaultCellStyle.BackColor = Color.LightPink;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar socios morosos:\n{ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarMorosos();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            // Carga automática ya se hace en el constructor
        }
    }
}