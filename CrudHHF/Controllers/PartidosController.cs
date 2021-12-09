using CrudHHF.Data;
using CrudHHF.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudHHF.Controllers
{
    [Authorize(Roles = "Jugador, SuperAdmin")]
    public class PartidosController : Controller
    {
        
        private readonly ApplicationDbContext _context;

        public PartidosController(ApplicationDbContext context)
        {
            _context = context;
        }
        //Http Get Index
        public IActionResult Index()
        {
            
            IEnumerable<Partido> listPartidos = _context.Partido;
            return View(listPartidos);
        }

        //Http Get Create
        public IActionResult Crear()
        {
            return View();
        }

        //Http Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Partido partido)
        {
            if (ModelState.IsValid)
            {
                _context.Partido.Add(partido);
                _context.SaveChanges();

                TempData["mensaje"] = "El partido se ha creado correctamente";

                return RedirectToAction("Index");

            }
            return View();
        }

        //Http Get Editar
        public IActionResult Editar(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            //Obtener partido

            var partido = _context.Partido.Find(id);

            if(partido == null)
            {
                return NotFound();
            }

            return View(partido);
        }

        //Http Post Editar
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Editar(Partido partido)
        {
            if (ModelState.IsValid)
            {
                _context.Partido.Update(partido);
                _context.SaveChanges();

                TempData["mensaje"] = "El partido se ha modificado correctamente";

                return RedirectToAction("Index");

            }
            return View();
        }

        //Http Get Eliminar
        public IActionResult Eliminar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Obtener partido

            var partido = _context.Partido.Find(id);

            if (partido == null)
            {
                return NotFound();
            }

            return View(partido);
        }

        //Http Post Eliminar
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult EliminarPartido(int? id)
        {
            //Obtener el partido por id
            var partido = _context.Partido.Find(id);

            if (partido == null)
            {
                return NotFound();
            }


             _context.Partido.Remove(partido);
             _context.SaveChanges();

             TempData["mensaje"] = "El partido se ha eliminado correctamente";

             return RedirectToAction("Index");

        }
    }
}

