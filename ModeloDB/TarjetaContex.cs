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
        public TarjetaContex(DbContextOptions<TarjetaContex> options) 
        :base(options)
        { 
        
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             //string consqlS = "Server=DESKTOP-BFT9R9J;Database=EFCore-TarjetaDB;Trusted_Connection=True";
            //string conPG = "Host = localhost ;" +
            //  "Database = School;" +
            //   "Username = postgres;" +
            //   "Password = 12345678";
            optionsBuilder.UseSqlServer("Server=DESKTOP-BFT9R9J;Database=EFCore-TarjetaDB;Trusted_Connection=True");
        }
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            //1 a muchos 
            modelBuilder.Entity<Tarjeta>()
               .HasOne(c => c.Solicitud)
               .WithMany(m => m.Tarjetas)
               .HasForeignKey(c => c.CurrentSolicitudid);

            modelBuilder.Entity<Usuario>()
              .HasOne(c => c.Solicitud)
              .WithMany(m => m.Usuarios)
              .HasForeignKey(c => c.CurrentSolicitudid);

            modelBuilder.Entity<Deudas>()
              .HasOne(c => c.Solicitud)  
              .WithMany(m => m.Deudas)
              .HasForeignKey(c => c.CurrentSolicitudid);
            //1 a 1 
         
           //1 a 1 Factura Calculo
            modelBuilder.Entity<Calculos>()
               .HasOne(facturas => facturas.Facturas)
               .WithOne(rol => rol.Calculos)
               .HasForeignKey<Factura>(pago => pago.Calculos_Id);
            // 1 a 1 rol publico

            //muchos a muchos 
            modelBuilder.Entity<Prerequsitos>()
                .HasKey(p => new { p.RolPagoId, p.FacturaId, p.RolPagoPublicaId, p.UsuarioId });

            modelBuilder.Entity<Prerequsitos>()
            .HasOne(pre => pre.Factura)
            .WithMany(factura => factura.Prerequsitos)
            .OnDelete(DeleteBehavior.NoAction)
            .HasForeignKey(pre => pre.FacturaId);

            modelBuilder.Entity<Prerequsitos>()
          .HasOne(pre => pre.Usuario)
          .WithMany(usuario => usuario.Prerequsitos)
          .OnDelete(DeleteBehavior.NoAction)
          .HasForeignKey(pre => pre.UsuarioId);

            modelBuilder.Entity<Prerequsitos>()
            .HasOne(pre => pre.RolPagosPublica)
            .WithMany(rlp => rlp.Prerequsitos)
            .OnDelete(DeleteBehavior.NoAction)
            .HasForeignKey(pre => pre.RolPagoPublicaId);

            modelBuilder.Entity<Prerequsitos>()
          .HasOne(pre => pre.RolPago)
          .WithMany(rol => rol.Prerequsitos)
          .OnDelete(DeleteBehavior.NoAction)
          .HasForeignKey(pre => pre.RolPagoId);


        }
        //Declaracion de clases 
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarjeta> Tarjetas { get; set; }
        public DbSet<RolPago> Rol { get; set; }
        public DbSet<Deudas> Deudas { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
        public DbSet<Calculos> Calculos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<RolPagosPublica> RolPublica { get; set; }

    }
}
