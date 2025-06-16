using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ClubDeportivoApp.Entidades;


namespace ClubDeportivoApp.Helpers
{
    public static class TemplateEngine
    {
        public static string RenderComprobante(E_Socio socio, E_CuotaMensual cuota)
        {
            string templateFolder = Path.Combine(Application.StartupPath, "Resources", "Templates", "Comprobante");

            // Leer todos los archivos
            string html = File.ReadAllText(Path.Combine(templateFolder, "comprobante.html"));
            string css = File.ReadAllText(Path.Combine(templateFolder, "styles.css"));
            string logoBase64 = Convert.ToBase64String(File.ReadAllBytes(Path.Combine(templateFolder, "Assets", "logo.png")));
            string iconBase64 = Convert.ToBase64String(File.ReadAllBytes(Path.Combine(templateFolder, "Assets", "Icon-Pagado.png")));

            // Reemplazar recursos
            html = html
                .Replace("<link href=\"./Resources/Templates/Comprobante/styles.css\" rel=\"stylesheet\">",
                        $"<style>{css}</style>")
                .Replace("src=\"./Resources/Templates/Comprobante/Assets/logo.png\"",
                        $"src=\"data:image/png;base64,{logoBase64}\"")
                .Replace("src=\"./Resources/Templates/Comprobante/Assets/Icon-Pagado.png\"",
                        $"src=\"data:image/png;base64,{iconBase64}\"");

            // Reemplazar variables
            return html
                .Replace("{{codCuota}}", cuota.CodCuota)
                .Replace("{{codSocio}}", socio.CodSocio)
                .Replace("{{nombre}}", socio.Nombre)
                .Replace("{{apellido}}", socio.Apellido)
                .Replace("{{dni}}", socio.Dni.ToString())
                .Replace("{{nroCuota}}", cuota.NroCuota.ToString())
                .Replace("{{vencimiento}}", cuota.Vencimiento.ToString("dd/MM/yyyy"))
                .Replace("{{monto}}", cuota.ValorMensual.ToString("C2"))
                .Replace("{{tipoPago}}", cuota.TipoDePago)
                .Replace("{{fechaPago}}", DateTime.Parse(cuota.FechaDePago).ToString("yyyy/MM/dd"));
        }
    }
}
