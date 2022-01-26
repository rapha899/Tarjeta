using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Deudas
    {
        public int id { get; set; }
        public string TipoDeuda { get; set; }
        public float monto { get; set; }
        //Realaciones
        public int CurrentSolicitudid { get; set; }
        public Solicitud Solicitud { get; set; }

    }
}
