using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Tarjeta
    {
        public string TarjetaId { get; set; }
        public string TarjetaName { get; set; }

        public int CurrentSolicitudid { get; set; }
        public Solicitud Solicitud { get; set; }
    }
}
