using Microsoft.AspNetCore.Mvc;

namespace PrimerMvcNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //-------------------------------- Sumar Numeros Get -----------------------------
        public IActionResult SumarNumerosGet
            (int numero1, int numero2)
        {
            ViewData["DATA"] = "La suma de " + numero1 + " + " + numero2 + " = " + (numero1+numero2);
            return View();
        }
        //-------------------------------- Sumar Numeros Post -----------------------------
        [HttpGet]
        public IActionResult SumarNumerosPost()
        {
            ViewData["NUMERO1"] = 4;
            ViewData["NUMERO2"] = 6;
            return View();
            
        }
        [HttpPost]
        public IActionResult SumarNumerosPost
            (int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewData["DATA"] = "La suma de " + numero1 + " + " + numero2 + " = " + suma;
            return View();
        }

        //-------------------------------- CojeturaCollatz -----------------------------
        [HttpGet]
        public IActionResult CojeturaCollatz()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CojeturaCollatz
            (int numero)
        {
            //  DEBEMOS DEVOLVER UN OBJETO COMPLEJO CON
            //  UNA LISTA DE NUMEROS
            List<int> numeros = new List<int>();
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                numeros.Add(numero);
            }
            //  DEVOLVER EL MODEL A LA VISTA
            return View(numeros);
        }
        //-------------------------------- Tabla Multiplicar Simple -----------------------------
        [HttpGet]
        public IActionResult TablaMultiplicarSimple()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TablaMultiplicarSimple
            (int numero)
        {
            List<int> resultados = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                resultados.Add(resultado);
            }
            return View(resultados);
        }
    }
}
