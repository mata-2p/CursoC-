using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraAplicacionWeb.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Index()
        {
            return View();
        }

        public string mensaje()
        {
            return "Bienvenido al Curso APS.NET  MVC";
        }

        public string saludo(string nombre)
        {
            return "Hola como estas : "+ nombre;
        }

        public string saludoCompleto(string nombre, string apellido)
        {
            return "Hola como estas : " + nombre +" "+ apellido;
        }

    }
}