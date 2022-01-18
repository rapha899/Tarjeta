using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entidades.Entidades;
namespace ModeloDB
{
    public class TarjetaContex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             string consqlS = "Server=DESKTOP-BFT9R9J;Database=EFCore-TarjetaDB;Trusted_Connection=True";
            //string conPG = "Host = localhost ;" +
                         //  "Database = School;" +
                        //   "Username = postgres;" +
                        //   "Password = 12345678";
            optionsBuilder.UseSqlServer(consqlS);
        }
        //Declaracion de clases 
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarjeta> Tarjetas { get; set; }
        public DbSet<RolPago> Rol { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
        public DbSet<FacturaRuc> Facturas { get; set; }

        //Configuracion de clases 
    }
}
