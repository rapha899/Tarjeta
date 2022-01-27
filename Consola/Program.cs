using System;
using System.Collections.Generic;
using Entidades.Entidades;
using CargaDatos;
using ModeloDB;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
          DatosIniciales datos = new DatosIniciales();
            var listas = datos.Carga();

            //Extraer del diccionario las listas 
            var listaPeriodos = (List<Usuario>)listas["Usuarios"];

            //Grabar
           // TarjetaContex db = new TarjetaContex();
           // db.Usuarios.AddRange(listaPeriodos);
          //  db.SaveChanges();
        }
    }
}
