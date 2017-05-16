using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StartupDemo.Controllers
{
    public class TesteController : Controller
    {
        //Verbos
        [HttpGet, HttpPost]
        [Route("")]
        [Route("dashboard/tela-inicial")]
        [Route("dashboard/tela-inicial/{id:int}/{valor:guid}")]
        public IActionResult Index(int id, Guid valor)
        {
            //return View();
            //return Json("{'Nome': 'Chelder'}");
            return RedirectToAction("Teste");
        }

        public IActionResult Teste()
        {
            return View("Index");
        }
    }
}