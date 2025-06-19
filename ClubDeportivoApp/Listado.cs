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
        private enum FiltroMorosos { Todos, VencimientoHoy };

        public Listado()
        {
            InitializeComponent();
            _socioDatos = new Socio();
            ConfigurarFormulario();
            ConfigurarDataGridView();
            dgvMorosos.DataSource = new List<dynamic>();
        }

        private void ConfigurarFormulario()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void ConfigurarDataGridView()
        {
            dgvMorosos.AutoGenerateColumns = false;
            dgvMorosos.Columns.Clear();

            // Configuración básica del grid
            dgvMorosos.BorderStyle = BorderStyle.Fixed3D;
            dgvMorosos.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvMorosos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvMorosos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 76);
            dgvMorosos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMorosos.EnableHeadersVisualStyles = false;
            dgvMorosos.RowHeadersVisible = false;
            dgvMorosos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMorosos.AllowUserToResizeColumns = true;
            dgvMorosos.AllowUserToOrderColumns = true;
            dgvMorosos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Configuración de columnas
            var columns = new[]
            {
                new DataGridViewTextBoxColumn {
                    Name = "CodSocio",
                    HeaderText = "CÓDIGO",
                    DataPropertyName = "CodSocio",
                    Width = 120,
                    DefaultCellStyle = new DataGridViewCellStyle {
                        Alignment = DataGridViewContentAlignment.MiddleCenter
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
                },
                new DataGridViewTextBoxColumn {
                    Name = "DiasVencidos",
                    HeaderText = "DÍAS VENCIDOS",
                    DataPropertyName = "DiasVencidos",
                    Width = 120,
                    DefaultCellStyle = new DataGridViewCellStyle {
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    }
                }
            };

            dgvMorosos.Columns.AddRange(columns);
            dgvMorosos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void CargarMorosos(FiltroMorosos filtro)
        {
            try
            {
                var morosos = _socioDatos.ListarSociosMorosos();

                // Aplicar filtro
                if (filtro == FiltroMorosos.VencimientoHoy)
                {
                    morosos = morosos.Where(m => m.Vencimiento.Date == DateTime.Today).ToList();

                    // Mensaje si no hay morosos con vencimiento hoy
                    if (morosos.Count == 0)
                    {
                        MessageBox.Show("No hay ningún socio con vencimiento en el día de la fecha.",
                                      "Información",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        dgvMorosos.DataSource = new List<dynamic>(); // Limpiar el DataGridView
                        return;
                    }
                }
                else // Filtro Todos
                {
                    // Mensaje si no hay morosos
                    if (morosos.Count == 0)
                    {
                        MessageBox.Show("No hay ningún socio moroso en el sistema.",
                                      "Información",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        dgvMorosos.DataSource = new List<dynamic>(); // Limpiar el DataGridView
                        return;
                    }
                }

                var datosParaMostrar = morosos.Select(m => new
                {
                    m.CodSocio,
                    m.Apellido,
                    m.Nombre,
                    m.Dni,
                    Vencimiento = m.Vencimiento.ToString("dd/MM/yyyy"),
                    DiasVencidos = (DateTime.Today - m.Vencimiento).Days > 0 ?
                                   (DateTime.Today - m.Vencimiento).Days.ToString() :
                                   (m.Vencimiento.Date == DateTime.Today ? "Hoy" : "")
                }).ToList();

                dgvMorosos.DataSource = datosParaMostrar;

                // Resaltar filas según vencimiento
                foreach (DataGridViewRow row in dgvMorosos.Rows)
                {
                    if (row.Cells["DiasVencidos"].Value != null)
                    {
                        string diasValue = row.Cells["DiasVencidos"].Value.ToString();

                        if (diasValue == "Hoy")
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                            row.DefaultCellStyle.Font = new Font(dgvMorosos.Font, FontStyle.Bold);
                        }
                        else if (!string.IsNullOrEmpty(diasValue))
                        {
                            int dias = int.Parse(diasValue);
                            if (dias > 0)
                            {
                                row.DefaultCellStyle.BackColor = Color.LightCoral;
                                if (dias > 7)
                                {
                                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                                }
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
            if (MessageBox.Show("¿Está seguro que desea salir?", "AVISO DEL SISTEMA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {               
                this.Close();
            }
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            // Carga automática ya se hace en el constructor
        }

        private void btnTodos_Click_1(object sender, EventArgs e)
        {
            CargarMorosos(FiltroMorosos.Todos);
        }

        private void btnVencimientoHoy_Click_1(object sender, EventArgs e)
        {
            CargarMorosos(FiltroMorosos.VencimientoHoy);
        }
    }
}