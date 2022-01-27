using Microsoft.AspNetCore.Mvc;
using ModeloDB;
using System.Collections;
using Entidades.Entidades;
using System.Collections.Generic;

namespace WebApp.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly TarjetaContex db;

        public UsuariosController(TarjetaContex db) { 
        this.db = db;
        
        }
        //listar usuarios 
    

        public IActionResult Index()
        {
            IEnumerable <Usuario>listaUsuarios = db.Usuarios;
            return View(listaUsuarios);
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
