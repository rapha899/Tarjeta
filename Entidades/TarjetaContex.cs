using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entidades.Entidades;
namespace Entidades
{
    public class TarjetaContex  : DbContext
    {
         public DbSet<Usuario> Usuarios {get; set;}
         public DbSet<Tarjeta> Tarjetas { get; set; }
         public DbSet<Documento> Documentos { get; set; }
         public DbSet<Solicitud> Solicitudes { get; set; }
         
    }
}
