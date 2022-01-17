using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; } 
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }

        public int CurrentSolicitudid { get; set; }
        public Solicitud Solicitud { get; set; }


    }
}
