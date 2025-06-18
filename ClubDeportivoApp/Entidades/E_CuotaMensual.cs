using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubDeportivoApp.Datos;

namespace ClubDeportivoApp.Entidades
{
    public class E_CuotaMensual
    {
        public string CodCuota { get; set; }
        public int NroCuota { get; set; }
        public DateTime Vencimiento { get; set; }
        public float ValorMensual { get; set; }
        public Boolean Pagada { get; set; }
        public string TipoDePago { get; set; }
        public int CantidadCuotas { get; set; }
        public string FechaDePago { get; set; }
        public string CodSocio { get; set; }

    }
}
