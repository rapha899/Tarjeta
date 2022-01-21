using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class RolPagosPublica
    {
        public int id { get; set; }
        public int rolPagoPublica { get; set; }
        public DateTime FechaRol { get; set; }

        //Relaciones 
        public int CurrentSolicitudid { get; set; }
        public Solicitud Solicitud { get; set; }
        //pre
        public ICollection<Prerequsitos> Prerequsitos { get; set; }
    }
}
