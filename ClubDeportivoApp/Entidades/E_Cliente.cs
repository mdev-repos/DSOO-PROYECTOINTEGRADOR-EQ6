using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoApp.Entidades
{
    public class E_Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public DateTime FechaNac { get; set; }
        public string Direccion{ get; set; }
        public string Telefono{ get; set; }
        public string Email{ get; set; }
        public Boolean FichaMedica{ get; set; }
    }
}
