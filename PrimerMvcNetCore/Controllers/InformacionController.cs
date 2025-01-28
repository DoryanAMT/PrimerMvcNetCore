using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //  VAMOSA RECIBIR DOS PARAMETROS
        public IActionResult VistaControllerGet
            (string saludo, /*System.Nullable<int>*/int? year)
        {
            if (year != null)
            {
                ViewData["DATA"] = "Hola " + saludo + " en el año " + year;
            }
            else
            {
                ViewData["DATA"] = "Aquí no tenemos tiempo";
            }
            //  PARA COMPROBAR QUE LOS HEMOS RECIBIDO,
            //  GUARDAMOS LOS PARAMETROS EN ViewData
            //  PAR VER LA INFORMACION
            //ViewData["DATA"] = "Hola " + saludo + " en el año " + year;
            return View();
        }
        public IActionResult ControladorVista()
        {
            //  VAMOS A ENVIAR INFOMRACION SIMPLE A NUESTRA VISTA
            ViewData["NOMBRE"] = "Alumno";
            ViewData["EDAD"] = 24;
            ViewBag.DiaSemana = "Lunes";
            return View();
        }
        public IActionResult ControladorVistaModel()
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Email = "alumno@email.com";
            persona.Edad = 27;
            return View( persona );
        }
        //  POST RECUPERA NAME COMO REFERENCIA DEL INPUT
        //  CAPTURAMOS LA VISTA DE VistaControllerPost
        [HttpPost]
        public IActionResult VistaControllerPost
            //(string nombre, string email, int edad)
            (Persona persona, string aficiones)
        {
            ViewData["DATA"] = 
                "Nombre: " + persona.Nombre
                + ", Email: " + persona.Email
                + ", Edad: " + persona.Edad
                + ", Aficiones: " + aficiones;
            return View();
        }
        //  PARA PODER VER LA VISTA DE VistaControllerPost TAMBIEN NECESITAMOS UN POST
        [HttpGet]
        public IActionResult VistaControllerPost()
        {
            return View();
        }
    }
}
