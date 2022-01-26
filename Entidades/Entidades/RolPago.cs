using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class RolPago
    {
        public int id { get; set; }  
        public int rolPago { get; set; }
        public float monto { get; set; }
        public DateTime FechaRol { get; set; }

        //Relaciones 
        public int CurrentSolicitudid { get; set; }
        public Solicitud Solicitud { get; set; }
        //pre
        public ICollection<Prerequsitos> Prerequsitos { get; set; }


    }
}
