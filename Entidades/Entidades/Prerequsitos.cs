using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Prerequsitos
    {
        public int UsuarioId { get; set; }
        public int RolPagoId { get; set; }
        public int RolPagoPublicaId { get; set; }
        public int FacturaId { get; set; }
        //Relaciones
        public Usuario Usuario { get; set; }
        public RolPago RolPago { get; set; }
        public RolPagosPublica RolPagosPublica { get; set; }
        public Factura Factura { get; set; }

    }
}
