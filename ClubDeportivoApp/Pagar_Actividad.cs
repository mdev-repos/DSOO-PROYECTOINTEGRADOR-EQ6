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
    public partial class Pagar_Actividad : Form
    {
        private E_CuotaDiaria _cuotaDiaria;
        private float _valorFinal;

        public Pagar_Actividad()
        {
            InitializeComponent();
        }

        public Pagar_Actividad(E_CuotaDiaria cuotaDiaria)
        {
            InitializeComponent();
            _cuotaDiaria = cuotaDiaria;
            _valorFinal = (float)cuotaDiaria.ValorFinal;

            CargarDatosPrevios();
            ConfigurarControles();
            ConfigurarComboboxes();
        }

        private void CargarDatosPrevios()
        {
            string dni = _cuotaDiaria.CodNoSocio.Split('-')[1];

            Datos.NoSocio noSocioDatos = new Datos.NoSocio();
            E_NoSocio noSocio = noSocioDatos.BuscarNoSocioPorDni(dni);

            txtCodigoNoSocio.Text = _cuotaDiaria.CodNoSocio;
            txtNombre.Text = noSocio?.Nombre ?? "No encontrado";
            txtApellido.Text = noSocio?.Apellido ?? "No encontrado";
            txtActividad.Text = _cuotaDiaria.CodActividad;
            txtCodCuotaDiaria.Text = _cuotaDiaria.CodCuotaDiaria;
            txtImporteFinal.Text = _valorFinal.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR"));
        }

        private void ConfigurarControles()
        {
            // Hacer campos de solo lectura
            txtCodigoNoSocio.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtActividad.ReadOnly = true;
            txtCodCuotaDiaria.ReadOnly = true;
            txtImporteFinal.ReadOnly = true;
            txtValorCuota.ReadOnly = true;
        }

        private void ConfigurarComboboxes()
        {
            // Configurar tipos de pago
            cbTipoDePago.SelectedIndex = 0;

            // Configurar cuotas 
            cbCuotas.SelectedIndex = 0;
            cbCuotas.Enabled = false;

            CalcularValorCuota();
        }

        private void cbTipoDePago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CalcularValorCuota()
        {
            if (int.TryParse(cbCuotas.SelectedItem?.ToString(), out int cantCuotas) && cantCuotas > 0)
            {
                float valorCuota = _valorFinal / cantCuotas;
                txtValorCuota.Text = valorCuota.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR"));
            }
        }

        private void btnPagarActividad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbTipoDePago.Text))
            {
                MessageBox.Show("Seleccione un método de pago", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Actualizar objeto cuota
                _cuotaDiaria.TipoDePago = cbTipoDePago.Text;
                _cuotaDiaria.CantidadCuotas = int.Parse(cbCuotas.SelectedItem.ToString());
                _cuotaDiaria.FechaDePago = DateTime.Now.ToString("dd/MM/yyyy");
                _cuotaDiaria.Pagada = true;

                // Persistir en BD
                Datos.CuotaDiaria datosCuota = new Datos.CuotaDiaria();
                string resultado = datosCuota.ActualizarCuotaDiariaCompleta(_cuotaDiaria);

                if (resultado == "0") // Éxito
                {
                    // Mostrar comprobante
                    MostrarComprobante();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error al registrar el pago: {resultado}",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el pago: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void MostrarComprobante()
        {
            string dni = _cuotaDiaria.CodNoSocio.Split('-')[1];
            Datos.NoSocio noSocioDatos = new Datos.NoSocio();
            E_NoSocio noSocio = noSocioDatos.BuscarNoSocioPorDni(dni);

            if (noSocio != null)
            {
                Detalle_Comprobante_Actividad comprobante =
                    new Detalle_Comprobante_Actividad(noSocio, _cuotaDiaria);
                comprobante.ShowDialog();
            }

            MessageBox.Show("Pago registrado exitosamente",
                          "Éxito",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        private void cbTipoDePago_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Habilitar cuotas solo si es Tarjeta de Crédito
            if(cbTipoDePago.Text == "Tarjeta de Crédito" ||
               cbTipoDePago.SelectedItem.ToString() == "Tarjeta de Crédito" ||
               cbTipoDePago.SelectedIndex == 5 ||
               cbTipoDePago.Text.ToLower().Contains("crédito") ||
               cbTipoDePago.Text.ToLower().Contains("credito"))
            { cbCuotas.Enabled = true; }
            else 
            { 
                cbCuotas.Enabled = false;
                cbCuotas.SelectedIndex = 0;
            }

            CalcularValorCuota();
        }

        private void cbCuotas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CalcularValorCuota();
        }
    }
}