using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practica.Models;

namespace practica.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string user,string dui,FormCollection collection)
        {
            if(user=="Juan Perez" && dui=="1234567-8") return RedirectToAction("./calcular");
            return HttpNotFound();

        }
        public ActionResult Calcular()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calcular(string nombre, string valorHora, string antiguedad, string horasTrabajadas, FormCollection collection)
        {


            return RedirectToAction("./Resultado", routeValues: new { nombre, valorHora,antiguedad,horasTrabajadas});
        }
        public ActionResult Resultado(string nombre, string valorHora, string antiguedad, string horasTrabajadas)
        {
           
            Datos datos = new Datos();
            datos.nombre = nombre;
            datos.valorHora = valorHora;
            datos.Antiguedad = antiguedad;
            datos.horasTrabajadas = horasTrabajadas;
            return View(datos);
        }

    }
}