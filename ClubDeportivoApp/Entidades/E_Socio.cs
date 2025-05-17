using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoApp.Entidades
{
    public class E_Socio
    {
        public string CodSocio { get; set; }
        public Boolean Carnet { get; set;  }
        public string FechaInscripcion { get; set;  }
        public Boolean Moroso { get; set;  }
    }
}
