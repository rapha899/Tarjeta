using System;
using System.Collections.Generic;
using Entidades.Entidades;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Creamos una tarjeta
            Tarjeta tarjeta = new Tarjeta()
            { 
             TarjetaId = 1,
             TarjetaName = "Visa Normal" 
            };
            Tarjeta tarjeta1 = new Tarjeta()
            {
                TarjetaId = 2,
                TarjetaName = "Visa Platinum"
            };
            Tarjeta tarjeta3 = new Tarjeta()
            {
                TarjetaId = 3,
                TarjetaName = "Visa Signature"
            };
            //Lista de Tarjetas
            List<Tarjeta> LstTarjetas = new List<Tarjeta>() {tarjeta , tarjeta1 , tarjeta3 };

            //Creamos un usuario 
            Usuario usuario = new Usuario()
            {
                IdUsuario = 1 ,
                Nombre = "Raphael",
                Apellido = "Perez",
                Cedula = 1750269969 ,
                Email = "jr.perez@itq.edu.ec"

            };
            List<Usuario> LstUsuario = new List<Usuario>() {usuario};

            //rol de pagos 
            RolPago rolPago = new RolPago()
            {
                IdRol = 1 ,
                rolPago = 1
                
            };
            //solicitud
            Solicitud solicitud = new Solicitud()
            {
                idSolicitud = 1,
                NombreEmpresa = "SA",
                FechaSolicitud = new DateTime(2022,1,18) ,
                Ingresos = 12400,
                Tarjetas = new List<Tarjeta>() {tarjeta , tarjeta1 , tarjeta3 },
                Usuarios = new List<Usuario>() { usuario}

            };
        }
    }
}
