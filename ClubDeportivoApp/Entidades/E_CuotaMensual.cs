using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoApp.Entidades
{
    internal class E_CuotaMensual
    {
        public string CodCuota { get; set; }
        public int NroCuota { get; set; }
        public DateTime Vencimiento { get; set; }
        public float ValorMensual { get; set; }
        public string TipoDePago { get; set; }

    }
}
