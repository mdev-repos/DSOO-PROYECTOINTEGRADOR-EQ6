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
using PuppeteerSharp.Media;
using PuppeteerSharp;

namespace ClubDeportivoApp
{
    public partial class Detalle_Comprobante_Actividad : Form
    {
        private readonly E_NoSocio _noSocio;
        private readonly E_CuotaDiaria _cuotaDiaria;

        public Detalle_Comprobante_Actividad()
        {
            InitializeComponent();
        }

        public Detalle_Comprobante_Actividad(E_NoSocio noSocio, E_CuotaDiaria cuotaDiaria)
        {
            InitializeComponent();
            _noSocio = noSocio;
            _cuotaDiaria = cuotaDiaria;
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

        private async void btnDescargarResumen_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.FileName = $"comprobante_actividad_{_cuotaDiaria.CodCuotaDiaria}.pdf";
                    saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveDialog.DefaultExt = "pdf";
                    saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string htmlContent = TemplateEngine.RenderComprobanteActividad(_noSocio, _cuotaDiaria);

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
