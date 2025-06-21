using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ClubDeportivoApp.Entidades;
using System.Globalization;


namespace ClubDeportivoApp.Helpers
{
    public static class TemplateEngine
    {
        public static string RenderComprobante(E_Socio socio, E_CuotaMensual cuota)
        {
            string templateFolder = Path.Combine(Application.StartupPath, "Resources", "Templates", "Comprobante");
            string assetsFolder = Path.Combine(Application.StartupPath, "Resources", "Templates", "Assets");

            // Leer todos los archivos
            string html = File.ReadAllText(Path.Combine(templateFolder, "comprobante.html"));
            string css = File.ReadAllText(Path.Combine(templateFolder, "styles.css"));
            string logoBase64 = Convert.ToBase64String(File.ReadAllBytes(Path.Combine(assetsFolder, "logo.png")));
            string iconBase64 = Convert.ToBase64String(File.ReadAllBytes(Path.Combine(assetsFolder, "Icon-Pagado.png")));

            // Reemplazar recursos
            html = html
                .Replace("<link href=\"./Resources/Templates/Comprobante/styles.css\" rel=\"stylesheet\">",
                        $"<style>{css}</style>")
                .Replace("src=\"./Resources/Templates/Assets/logo.png\"",
                        $"src=\"data:image/png;base64,{logoBase64}\"")
                .Replace("src=\"./Resources/Templates/Assets/Icon-Pagado.png\"",
                        $"src=\"data:image/png;base64,{iconBase64}\"");

            float importePorCuota = cuota.ValorMensual / cuota.CantidadCuotas;

            return html
                .Replace("{{codCuota}}", cuota.CodCuota)
                .Replace("{{codSocio}}", socio.CodSocio)
                .Replace("{{nombre}}", socio.Nombre)
                .Replace("{{apellido}}", socio.Apellido)
                .Replace("{{dni}}", socio.Dni.ToString())
                .Replace("{{nroCuota}}", cuota.NroCuota.ToString())
                .Replace("{{vencimiento}}", cuota.Vencimiento.ToString("dd/MM/yyyy"))
                .Replace("{{monto}}", cuota.ValorMensual.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR")))
                .Replace("{{tipoPago}}", cuota.TipoDePago)
                .Replace("{{fechaPago}}", DateTime.Parse(cuota.FechaDePago).ToString("dd/MM/yyyy"))
                .Replace("{{cantidadCuotas}}", cuota.CantidadCuotas.ToString())
                .Replace("{{importeCuota}}", importePorCuota.ToString("C2", CultureInfo.CreateSpecificCulture("es-AR")));
        }

        public static string RenderComprobanteActividad(E_NoSocio noSocio, E_CuotaDiaria cuota)
        {
            string templateFolder = Path.Combine(Application.StartupPath, "Resources", "Templates", "ComprobanteActividad");
            string assetsFolder = Path.Combine(Application.StartupPath, "Resources", "Templates", "Assets");

            // Leer todos los archivos
            string html = File.ReadAllText(Path.Combine(templateFolder, "comprobante_actividad.html"));
            string css = File.ReadAllText(Path.Combine(templateFolder, "styles.css"));
            string logoBase64 = Convert.ToBase64String(File.ReadAllBytes(Path.Combine(assetsFolder, "logo.png")));
            string iconBase64 = Convert.ToBase64String(File.ReadAllBytes(Path.Combine(assetsFolder, "Icon-Pagado.png")));

            // Reemplazar recursos
            html = html
                .Replace("<link href=\"./Resources/Templates/ComprobanteActividad/styles.css\" rel=\"stylesheet\">",
                        $"<style>{css}</style>")
                .Replace("src=\"./Resources/Templates/Assets/logo.png\"",
                        $"src=\"data:image/png;base64,{logoBase64}\"")
                .Replace("src=\"./Resources/Templates/Assets/Icon-Pagado.png\"",
                        $"src=\"data:image/png;base64,{iconBase64}\"");

            string importePorCuota = cuota.CantidadCuotas > 1 ?
                ((decimal)cuota.ValorFinal / cuota.CantidadCuotas).ToString("C2", CultureInfo.CreateSpecificCulture("es-AR")) :
                "N/A";

            string nombreActividad = cuota.CodActividad.StartsWith("ACT-") ?
                cuota.CodActividad.Substring(4) :
                cuota.CodActividad;

            return html
                .Replace("{{codCuota}}", cuota.CodCuotaDiaria)
                .Replace("{{codNoSocio}}", noSocio.CodNoSocio)
                .Replace("{{nombre}}", noSocio.Nombre)
                .Replace("{{apellido}}", noSocio.Apellido)
                .Replace("{{dni}}", noSocio.Dni.ToString())
                .Replace("{{actividad}}", nombreActividad)
                .Replace("{{fechaUso}}", cuota.FechaDeUso)
                .Replace("{{monto}}", ((decimal)cuota.ValorFinal).ToString("C2", CultureInfo.CreateSpecificCulture("es-AR")))
                .Replace("{{tipoPago}}", cuota.TipoDePago)
                .Replace("{{fechaPago}}", cuota.FechaDePago)
                .Replace("{{cantidadCuotas}}", cuota.CantidadCuotas.ToString())
                .Replace("{{importeCuota}}", importePorCuota);
        }
    }
}