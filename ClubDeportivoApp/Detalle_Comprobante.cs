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
using ClubDeportivoApp.Helpers;
using PuppeteerSharp;
using PuppeteerSharp.Media;

namespace ClubDeportivoApp
{
    public partial class Detalle_Comprobante : Form
    {
        private readonly E_Socio _socio;
        private readonly E_CuotaMensual _cuota;

        public Detalle_Comprobante(E_Socio socio, E_CuotaMensual cuota)
        {
            InitializeComponent();
            _socio = socio;
            _cuota = cuota;

            // Configurar todos los controles como readonly
            ConfigurarControlesReadOnly();

            // Cargar los datos en los TextBox
            CargarDatos();

            // Configuración adicional del formulario
            ConfigurarFormulario();
        }

        private void ConfigurarControlesReadOnly()
        {
            txtBoxCodSoc.ReadOnly = true;
            txtBoxNomSoc.ReadOnly = true;
            txtBoxApellSoc.ReadOnly = true;
            txtBoxDniSoc.ReadOnly = true;
            txtBoxCodPago.ReadOnly = true;
            txtBoxNumPago.ReadOnly = true;
            txtBoxVencPago.ReadOnly = true;
            txtBoxTipoPago.ReadOnly = true;
            txtBoxMontoPago.ReadOnly = true;
            txtBoxFechaPago.ReadOnly = true;
            txtCantidadCuotas.ReadOnly = true;
            txtImporteCuotas.ReadOnly = true;
        }

        private void CargarDatos()
        {
            // Datos del Socio
            txtBoxCodSoc.Text = _socio.CodSocio;
            txtBoxNomSoc.Text = _socio.Nombre;
            txtBoxApellSoc.Text = _socio.Apellido;
            txtBoxDniSoc.Text = _socio.Dni.ToString();

            // Datos de la Cuota/Pago
            txtBoxCodPago.Text = _cuota.CodCuota;
            txtBoxNumPago.Text = _cuota.NroCuota.ToString();
            txtBoxVencPago.Text = _cuota.Vencimiento.ToString("dd/MM/yyyy");
            txtBoxTipoPago.Text = _cuota.TipoDePago;
            txtBoxMontoPago.Text = _cuota.ValorMensual.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR"));
            txtBoxFechaPago.Text = _cuota.FechaDePago;
            txtCantidadCuotas.Text = _cuota.CantidadCuotas.ToString();
            float importeCuotas = _cuota.ValorMensual/_cuota.CantidadCuotas;
            txtImporteCuotas.Text = importeCuotas.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR"));
        }

        private void ConfigurarFormulario()
        {
            this.Text = $"Detalle de Comprobante - {_cuota.CodCuota}";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "AVISO DEL SISTEMA",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // TODO: Implementar generación de PDF
            MessageBox.Show($"Generando comprobante PDF para {_cuota.CodCuota}...",
                          "Exportar a PDF",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        private async void btnDescargarResumen_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.FileName = $"comprobante_{_cuota.CodCuota}.pdf";
                    saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveDialog.DefaultExt = "pdf";
                    saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string htmlContent = TemplateEngine.RenderComprobante(_socio, _cuota);

                        await new BrowserFetcher().DownloadAsync();
                        using (var browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true }))
                        using (var page = await browser.NewPageAsync())
                        {
                            await page.SetContentAsync(htmlContent);
                            await page.PdfAsync(saveDialog.FileName, new PdfOptions
                            {
                                Format = PaperFormat.A4,
                                MarginOptions = new MarginOptions
                                {
                                    Top = "20mm",
                                    Right = "20mm",
                                    Bottom = "20mm",
                                    Left = "20mm"
                                },
                                PrintBackground = true
                            });
                        }

                        MessageBox.Show($"PDF generado en:\n{saveDialog.FileName}", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar PDF:\n{ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
