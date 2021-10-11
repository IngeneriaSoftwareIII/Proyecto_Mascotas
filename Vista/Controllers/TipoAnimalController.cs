using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vista.Controllers
{
    public class TipoAnimalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
