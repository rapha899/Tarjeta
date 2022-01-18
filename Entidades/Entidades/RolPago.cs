using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class RolPago
    {
        public int IdRol { get; set; }  
        public int rolPago { get; set; }
        public DateTime FechaFactura { get; set; }

        //Relaciones 
        public int CurrentSolicitudid { get; set; }
        public Solicitud Solicitud { get; set; }

    }
}
