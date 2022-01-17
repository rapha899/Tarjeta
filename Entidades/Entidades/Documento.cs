using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Documento
    {
        public int Id { get; set; }  
        public int rolPago { get; set; }
        public int Factura { get; set;}

        public int CurrentSolicitudid { get; set; }
        public Solicitud Solicitud { get; set; }

    }
}
