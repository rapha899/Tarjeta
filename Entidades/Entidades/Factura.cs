using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Factura
    {
        public int id { get; set; }
        public int factura { get; set; }
        public DateTime FechaFactura { get; set; }

        //Relaciones 
        public int CurrentSolicitudid { get; set; }
        public Solicitud Solicitud { get; set; }
        //Relacion 1 a 1 
        public int Calculos_Id { get; set; }
        public Calculos Calculos { get; set; }
        //pre
        public ICollection<Prerequsitos> Prerequsitos { get; set; }
    }
}
