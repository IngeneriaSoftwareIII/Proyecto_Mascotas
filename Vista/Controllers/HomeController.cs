using Entidades.Entidades;
using Entidades.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Vista.Models;

namespace Vista.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDatos<Mascota, int> datosMascota;

        public HomeController(ILogger<HomeController> logger, IDatos<Mascota,int> datosMascota)
        {
            _logger = logger;
            this.datosMascota = datosMascota;
        }

        public IActionResult Index()
        {
           var listaMasccotas =  datosMascota.Obtener();
            return View(listaMasccotas);
        }

        public IActionResult Menu()
        {
            return PartialView();
        }

    }
}
