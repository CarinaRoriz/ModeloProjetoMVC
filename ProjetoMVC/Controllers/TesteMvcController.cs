using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class TesteMvcController : Controller
    {
        public IActionResult Index()
        {
            return View("View");
        }

        public ActionResult FuncaoTeste()
        {
            var modelo = new ModeloTeste();
            return Json(modelo);
        }
    }
}