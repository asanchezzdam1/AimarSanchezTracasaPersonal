using EjemploMvcConversor.Models;
using EjemploMvcConversor.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjemploMvcConversor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioMonedas repositorioMonedas;

        public HomeController(ILogger<HomeController> logger, IRepositorioMonedas repositorioMonedas)
        {
            _logger = logger;
            this.repositorioMonedas = repositorioMonedas;
        }

        public IActionResult Index()
        {

            _logger.LogInformation("Estoy en el index");
            IEnumerable<Moneda> lista = repositorioMonedas.ObtenerMonedas();    

            return View(lista);
        }

        public IActionResult Privacy()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}