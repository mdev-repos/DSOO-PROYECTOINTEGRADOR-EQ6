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
            dgvMorosos.EnableHeadersVisualStyles = false;
            dgvMorosos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvMorosos.AllowUserToResizeRows = false;

            // Configuración de columnas manualmente
            var columns = new[]
            {
                new DataGridViewTextBoxColumn {
                    Name = "CodSocio",
                    HeaderText = "CÓDIGO",
                    DataPropertyName = "CodSocio",
                    Width = 100
                },
                new DataGridViewTextBoxColumn {
                    Name = "Apellido",
                    HeaderText = "APELLIDO",
                    DataPropertyName = "Apellido",
                    Width = 150
                },
                new DataGridViewTextBoxColumn {
                    Name = "Nombre",
                    HeaderText = "NOMBRE",
                    DataPropertyName = "Nombre",
                    Width = 150
                },
                new DataGridViewTextBoxColumn {
                    Name = "Dni",
                    HeaderText = "DNI",
                    DataPropertyName = "Dni",
                    Width = 100
                },
                new DataGridViewTextBoxColumn {
                    Name = "NroCuota",
                    HeaderText = "CUOTA N°",
                    DataPropertyName = "NroCuota",
                    Width = 80
                },
                new DataGridViewTextBoxColumn {
                    Name = "Valor",
                    HeaderText = "VALOR",
                    DataPropertyName = "Valor",
                    Width = 100
                },
                new DataGridViewTextBoxColumn {
                    Name = "Vencimiento",
                    HeaderText = "VENCIMIENTO",
                    DataPropertyName = "Vencimiento",
                    Width = 120
                },
                new DataGridViewTextBoxColumn {
                    Name = "DiasVencidos",
                    HeaderText = "DÍAS VENCIDOS",
                    DataPropertyName = "DiasVencidos",
                    Width = 120
                }
            };

            dgvMorosos.Columns.AddRange(columns);

            // Configurar scroll
            dgvMorosos.ScrollBars = ScrollBars.Vertical;
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
                    NroCuota = m.CuotaVencida.NroCuota,
                    Valor = m.CuotaVencida.ValorMensual.ToString("C2"),
                    Vencimiento = m.CuotaVencida.Vencimiento.ToString("dd/MM/yyyy"),
                    DiasVencidos = (DateTime.Today - m.CuotaVencida.Vencimiento).Days
                }).ToList();

                dgvMorosos.DataSource = datosParaMostrar;

                // Resaltar filas según días vencidos
                foreach (DataGridViewRow row in dgvMorosos.Rows)
                {
                    if (row.Cells["DiasVencidos"].Value != null)
                    {
                        int dias = Convert.ToInt32(row.Cells["DiasVencidos"].Value);
                        if (dias > 30)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                            row.DefaultCellStyle.Font = new Font(dgvMorosos.Font, FontStyle.Bold);
                        }
                        else if (dias > 0)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
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
    }
}
