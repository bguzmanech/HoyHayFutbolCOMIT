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
    [Authorize(Roles = "Organizador, SuperAdmin")]
    public class OrganizadoresController : Controller
    {

        private readonly ApplicationDbContext _context;

        public OrganizadoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Http Get Index
        public IActionResult Index()
        {
            IEnumerable<Organizador> listOrganizadores = _context.Organizador;
            return View(listOrganizadores);
        }

        //Http Get Crear
        public IActionResult Crear()
        {
            return View();
        }

        //Http Post Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Organizador organizador)
        {
            if(ModelState.IsValid)
            {
                _context.Organizador.Add(organizador);
                _context.SaveChanges();

                TempData["mensaje"] = "El torneo se ha creado correctamente";
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

            //Obtener torneo
            var torneo = _context.Organizador.Find(id);

            if(torneo == null)
            {
                return NotFound();
            }

            return View(torneo);
        }

        //Http Post Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Organizador organizador)
        {
            if (ModelState.IsValid)
            {
                _context.Organizador.Update(organizador);
                _context.SaveChanges();

                TempData["mensaje"] = "El torneo se ha modificado correctamente";
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

            //Obtener torneo
            var torneo = _context.Organizador.Find(id);

            if (torneo == null)
            {
                return NotFound();
            }

            return View(torneo);
        }

        //Http Post Eliminar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EliminarTorneo(int? id)
        {

            //Obtener el torneo por id
            var torneo = _context.Organizador.Find(id);

            if(torneo == null)
            {
                return NotFound();
            }

            
            _context.Organizador.Remove(torneo);
            _context.SaveChanges();

            TempData["mensaje"] = "El torneo se ha eliminado correctamente";
            return RedirectToAction("Index");
           
           
        }
    }
}
