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
using ClubDeportivoApp.Entidades;

namespace ClubDeportivoApp
{
    public partial class Detalle_Comprobante_Actividad : Form
    {
        public Detalle_Comprobante_Actividad()
        {
            InitializeComponent();
        }

        public Detalle_Comprobante_Actividad(E_NoSocio noSocio, E_CuotaDiaria cuotaDiaria)
        {
            InitializeComponent();
            CargarDatosComprobante(noSocio, cuotaDiaria);
            ConfigurarControles();
        }

        private void CargarDatosComprobante(E_NoSocio noSocio, E_CuotaDiaria cuotaDiaria)
        {
            // Datos del No Socio
            txtCodNoSocio.Text = noSocio.CodNoSocio;
            txtDni.Text = noSocio.Dni.ToString();
            txtNombre.Text = noSocio.Nombre;
            txtApellido.Text = noSocio.Apellido;

            // Datos de la Cuota Diaria
            txtCodigoCuotaDiaria.Text = cuotaDiaria.CodCuotaDiaria;
            txtValorFinal.Text = ((decimal)cuotaDiaria.ValorFinal).ToString("C2", CultureInfo.CreateSpecificCulture("es-AR"));
            txtTipoDePago.Text = cuotaDiaria.TipoDePago;
            txtFechaDePago.Text = cuotaDiaria.FechaDePago;
            txtCantidadCuotas.Text = cuotaDiaria.CantidadCuotas.ToString();

            // Calcular valor de cada cuota
            if (cuotaDiaria.CantidadCuotas > 1)
            {
                decimal valorCuota = (decimal)cuotaDiaria.ValorFinal / cuotaDiaria.CantidadCuotas;
                txtImporteCuota.Text = valorCuota.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR"));
            }
            else
            {
                txtImporteCuota.Text = "N/A";
            }

            // Procesar código de actividad (quitar "ACT-" inicial)
            txtActividad.Text = cuotaDiaria.CodActividad.StartsWith("ACT-") ?
                               cuotaDiaria.CodActividad.Substring(4) :
                               cuotaDiaria.CodActividad;

            txtFechaDeUso.Text = cuotaDiaria.FechaDeUso;
        }

        private void ConfigurarControles()
        {
            // Configurar todos los TextBox como de solo lectura
            txtCodNoSocio.ReadOnly = true;
            txtDni.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtCodigoCuotaDiaria.ReadOnly = true;
            txtValorFinal.ReadOnly = true;
            txtTipoDePago.ReadOnly = true;
            txtFechaDePago.ReadOnly = true;
            txtCantidadCuotas.ReadOnly = true;
            txtImporteCuota.ReadOnly = true;
            txtActividad.ReadOnly = true;
            txtFechaDeUso.ReadOnly = true;

            
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
