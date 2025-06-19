using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoApp.Entidades
{
    internal class E_CuotaDiaria
    {
        public string CodCuotaDiaria { get; set; }
        public Boolean Pagada { get; set; }
        public float ValorFinal { get; set; }
        public string TipoDePago { get; set; }
        public int CantidadCuotas { get; set; }
        public string FechaDePago { get; set; }
        public string FechaDeUso { get; set; }
        public string CodNoSocio { get; set; }
        public string CodActividad {  get; set; }
    }
}
