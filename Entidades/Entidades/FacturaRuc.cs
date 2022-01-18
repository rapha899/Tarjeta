using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class FacturaRuc
    {
        public int IdFactura { get; set; }
        public int Factura  { get; set; }
        public DateTime FechaFactura { get; set; }

        //relacion 
        public int CurrentSolicitudid { get; set; }
        public Solicitud Solicitud { get; set; }
    }
}
