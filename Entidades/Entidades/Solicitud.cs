using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Solicitud
    {
        public int idSolicitud { get; set; }
        public int Ingresos { get; set; }
        public string NombreEmpresa { get; set; }
        public string TipoEmpresa { get; set; }
        public DateTime FechaSolicitud { get; set; }

        //Relaciones 
        public ICollection <Tarjeta> Tarjetas { get; set;}
        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<RolPago> RolPagos { get; set; }
        public ICollection<FacturaRuc> facturaRucs { get; set; }

    }
}
