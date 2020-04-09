using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SegundoEjercicio.Controllers
{
    public class HomeController : Controller
    {
        private Calculadora c;
        // GET: Home
        public ActionResult Index()
        {
            int resultado = c.Sumar(10, 200);
            ViewBag.resultado = resultado;
            return View();
        }

        public ActionResult Duplicar(int id)
        {

            int resultado = id * 2;
            ViewBag.id = id;
            ViewBag.resultado = resultado;
            return View();
        }
    }
}