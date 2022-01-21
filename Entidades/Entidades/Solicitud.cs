using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Solicitud
    {
        public int id{ get; set; }
        public int Ingresos { get; set; }
        public string NombreEmpresa { get; set; }
        public string TipoEmpresa { get; set; }
        public DateTime FechaSolicitud { get; set; }

        //Relaciones 
        public ICollection <Tarjeta> Tarjetas { get; set;}
        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<Deudas> Deudas { get; set; }

        // public ICollection<FacturaRuc> facturaRucs { get; set; }

    }
}
