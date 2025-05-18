using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoApp.Entidades
{
    internal class DTO_SocioMoroso
    {
        public string CodSocio { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public DateTime Vencimiento { get; set; } 
    }
}
