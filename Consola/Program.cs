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
             id = 1,
             TarjetaName = "Visa Normal" 
            };
            Tarjeta tarjeta1 = new Tarjeta()
            {
                id = 2,
                TarjetaName = "Visa Platinum"
            };
            Tarjeta tarjeta3 = new Tarjeta()
            {
                id = 3,
                TarjetaName = "Visa Signature"
            };
            //Lista de Tarjetas
            List<Tarjeta> LstTarjetas = new List<Tarjeta>() {tarjeta , tarjeta1 , tarjeta3 };

            //Creamos un usuario 
            Usuario usuario = new Usuario()
            {
                id = 1 ,
                Nombre = "Raphael",
                Apellido = "Perez",
                Cedula = 1750269969 ,
                Email = "jr.perez@itq.edu.ec"

            };
            List<Usuario> LstUsuario = new List<Usuario>() {usuario};

            //rol de pagos 
            RolPago rolPago = new RolPago()
            {
                id = 1 ,
                rolPago = 1
                
            };
            //solicitud
            Solicitud solicitud = new Solicitud()
            {
                id = 1,
                NombreEmpresa = "SA",
                FechaSolicitud = new DateTime(2022,1,18) ,
                Ingresos = 12400,
                Tarjetas = new List<Tarjeta>() { tarjeta1 },
                Usuarios = new List<Usuario>() { usuario}
            };
        }
    }
}
