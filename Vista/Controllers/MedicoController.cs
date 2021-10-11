using Entidades.Entidades;
using Entidades.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vista.Controllers
{
    public class MedicoController : Controller
    {
        private readonly IDatos<Medico, string> _datosMedico;
        private readonly IDatos<MedicoEspecializacion, MedicoEspecializacion> _datosEspecial;

        public MedicoController(IDatos<Medico,string> datosMedico, IDatos<MedicoEspecializacion,MedicoEspecializacion> datosEspecial)
        {
            _datosMedico = datosMedico;
            _datosEspecial = datosEspecial;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListJson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Medico entidad)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Medico entidad)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(string documento)
        {
            return View();
        }

        [HttpPost]
        public IActionResult ListEspeciazacion(string documento)
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEspeciazacion(MedicoEspecializacion entidad)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteEspeciazacion(MedicoEspecializacion entidad)
        {
            return View();
        }
    }
}
