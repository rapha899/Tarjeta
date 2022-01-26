using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Entidades;
namespace CargaDatos
{
    public class DatosIniciales
    {
        public enum ListaTipo
        {
            Tarjeta,Calculos,Deudas,Factura,Prerequisitos,RolPago, RolPagoPublica,Solicitud,Usuario
        }

        public Dictionary<string, object> Carga() {
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
            List<Tarjeta> LstTarjetas = new List<Tarjeta>() { tarjeta, tarjeta1, tarjeta3 };

            //Creamos un usuario 
            Usuario usuario = new Usuario()
            {
                id = 1,
                Nombre = "Raphael",
                Apellido = "Perez",
                Cedula = 1750269969,
                Email = "jr.perez@itq.edu.ec"

            };
            Usuario usuario2 = new Usuario()
            {
                id = 1,
                Nombre = "Jaime",
                Apellido = "Pineda",
                Cedula = 1750269967,
                Email = "jaime78@itq.edu.ec"

            };
            Usuario usuario3 = new Usuario()
            {
                id = 1,
                Nombre = "Juan Martin",
                Apellido = "Del Potro",
                Cedula = 1750269968,
                Email = "juanmartin67@itq.edu.ec"

            };
            Usuario usuario4 = new Usuario()
            {
                id = 1,
                Nombre = "Rafael",
                Apellido = "Nadal",
                Cedula = 1750269965,
                Email = "rafana@itq.edu.ec"


            };
            List<Usuario> LstUsuario = new List<Usuario>() { usuario , usuario2 ,usuario3 ,usuario4 };

            //rol de pagos usuario 1
            RolPago rolPago1 = new RolPago()
            {
                id = 1,
                rolPago = 1 ,
                monto = 3000 ,

            };
            RolPago rolPago2 = new RolPago()
            {
                id = 2,
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago3 = new RolPago()
            {
                id = 3,
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago4 = new RolPago()
            {
                id = 4,
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago5 = new RolPago()
            {
                id = 5,
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago6 = new RolPago()
            {
                id = 6,
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago7 = new RolPago()
            {
                id = 7,
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago8 = new RolPago()
            {
                id = 8,
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago9 = new RolPago()
            {
                id = 9,
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago10 = new RolPago()
            {
                id = 10,
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago11 = new RolPago()
            {
                id = 11,
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago12 = new RolPago()
            {
                id = 12,
                rolPago = 1,
                monto = 3000,

            };
            List<RolPago> LstRol = new List<RolPago>() { rolPago1,rolPago2 , rolPago3,rolPago4,rolPago5,rolPago6,rolPago7,rolPago8,rolPago9,rolPago10,rolPago11};
            //prerequsito 1 usuuario rol 
            Prerequsitos prerequsitos = new Prerequsitos()
            {
                RolPago = rolPago1
            };
            //prerequsito 1 usuuario rol 
            Prerequsitos prerequsitos2 = new Prerequsitos()
            {
                RolPago = rolPago2
            };
            //prerequsito 1 usuuario rol 
            Prerequsitos prerequsitos3 = new Prerequsitos()
            {
                RolPago = rolPago3
            };
            //prerequsito 2 usuuario rol 
            Prerequsitos prerequsitos4 = new Prerequsitos()
            {
                RolPago = rolPago4
            };
            //prerequsito 1 usuuario 
            Prerequsitos prerequsitos5 = new Prerequsitos()
            {
                RolPago = rolPago5
            };
            //prerequsito 1 usuuario 
            Prerequsitos prerequsitos6 = new Prerequsitos()
            {
                RolPago = rolPago5
            };
            //prerequsito 1 usuuario 
            Prerequsitos prerequsitos7 = new Prerequsitos()
            {
                RolPago = rolPago7
            };
            //prerequsito 1 usuuario 
            Prerequsitos prerequsitos8 = new Prerequsitos()
            {
                RolPago = rolPago8
            };
            //prerequsito 1 usuuario 
            Prerequsitos prerequsitos9 = new Prerequsitos()
            {
                RolPago = rolPago9
            };
            //prerequsito 1 usuuario 
            Prerequsitos prerequsitos10 = new Prerequsitos()
            {
                RolPago = rolPago10
            };
            //prerequsito 1 usuuario 
            Prerequsitos prerequsitos11 = new Prerequsitos()
            {
                RolPago = rolPago11
            };
            //prerequsito 1 usuuario 
            Prerequsitos prerequsitos12 = new Prerequsitos()
            {
                RolPago = rolPago12
            };
            //deudas usuario 1
            Deudas deudas = new Deudas()
            {
                TipoDeuda = "Bancaria",
                monto = 300,              
            };
            Deudas deudas1 = new Deudas()
            {
                TipoDeuda = "Prestamo Coperativa",
                monto = 2100,
            };
            // dedudas lista
            List<Deudas> LstDeudas = new List<Deudas>() { };
            //solicitud
            Solicitud solicitud = new Solicitud()
            {
                id = 1,
                NombreEmpresa = "SA",
                FechaSolicitud = new DateTime(2022, 1, 18),
                Ingresos = 12400,
                Tarjetas = new List<Tarjeta>() { tarjeta1 },
                Usuarios = new List<Usuario>() { usuario },
                Deudas = new List<Deudas>() { deudas1 , deudas}
            };

            List<Solicitud> LstSolicitudes = new List<Solicitud>() {solicitud };
            //Diccionario contiene listas
            Dictionary<string, object> dictListasDatos = new Dictionary<string, object>()
            {
                {"Usuarios", LstUsuario},
                {"Tarjetas", LstTarjetas},
                {"Deudas", LstDeudas},
                {"Rol", LstRol},
                {"Solicitudes", LstSolicitudes},

            };
            return dictListasDatos;

        }
    }
}
