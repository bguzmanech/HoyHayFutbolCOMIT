using CrudHHF.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudHHF.Controllers
{
    public class JugadoresController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
