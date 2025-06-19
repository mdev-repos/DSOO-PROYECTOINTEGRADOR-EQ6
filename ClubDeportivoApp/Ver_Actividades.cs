using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivoApp.Datos;
using MySql.Data.MySqlClient;

namespace ClubDeportivoApp
{
    public partial class Ver_Actividades : Form
    {
        private readonly Datos.Actividades _actividadesDatos;

        public Ver_Actividades()
        {
            InitializeComponent();
            _actividadesDatos = new Datos.Actividades();
            ConfigurarDataGridView();
            CargarActividades();
        }

        private void ConfigurarDataGridView()
        {
            dgvActividades.AutoGenerateColumns = false;
            dgvActividades.Columns.Clear();

            // Configuración básica del grid
            dgvActividades.BorderStyle = BorderStyle.Fixed3D;
            dgvActividades.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Configuración de headers
            dgvActividades.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvActividades.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 76);
            dgvActividades.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvActividades.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvActividades.EnableHeadersVisualStyles = false;
            dgvActividades.RowHeadersVisible = false;

            // Configuración para autoajuste inteligente
            dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvActividades.AllowUserToResizeColumns = true;
            dgvActividades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Configuración de columnas
            var columns = new[]
            {
        new DataGridViewTextBoxColumn {
            Name = "colCodigo",
            HeaderText = "CÓDIGO",
            DataPropertyName = "CodActividad",
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            },
            AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells 
        },
        new DataGridViewTextBoxColumn {
            Name = "colNombre",
            HeaderText = "NOMBRE",
            DataPropertyName = "Nombre",
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleLeft
            },
            AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells 
        },
        new DataGridViewTextBoxColumn {
            Name = "colPrecio",
            HeaderText = "PRECIO",
            DataPropertyName = "Valor",
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                FormatProvider = CultureInfo.CreateSpecificCulture("es-AR"),
                Format = "C2"
            },
            AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells 
        },
        new DataGridViewTextBoxColumn {
            Name = "colHorario",
            HeaderText = "HORARIOS",
            DataPropertyName = "Horario",
            DefaultCellStyle = new DataGridViewCellStyle {
                Alignment = DataGridViewContentAlignment.MiddleLeft
            },
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        }
    };

            dgvActividades.Columns.AddRange(columns);
            dgvActividades.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void AjustarAnchoColumnas()
        {
            dgvActividades.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            int anchoTotal = dgvActividades.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            int anchoDisponible = dgvActividades.ClientSize.Width;

            if (anchoDisponible > anchoTotal && dgvActividades.Columns["colHorario"] != null)
            {
                int espacioSobrante = anchoDisponible - anchoTotal;
                dgvActividades.Columns["colHorario"].Width += espacioSobrante;
            }
        }

        private void CargarActividades()
        {
            try
            {
                var actividades = _actividadesDatos.ListarTodasLasActividades();
                dgvActividades.DataSource = actividades;

                AjustarAnchoColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar actividades:\n{ex.Message}",
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
    }
}