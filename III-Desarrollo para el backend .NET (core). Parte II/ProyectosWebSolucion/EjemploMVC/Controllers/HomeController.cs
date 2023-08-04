using EjemploMVC.Models;
using EjemploMVC.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjemploMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServicioMonedas servicioMonedas;
        private readonly IMail servicioMail;

        public HomeController(ILogger<HomeController> logger, IServicioMonedas servicioMonedas, IMail servicioMail)
        {
            _logger = logger;
            this.servicioMonedas = servicioMonedas;
            this.servicioMail = servicioMail;
        }

        public IActionResult Index()
        {

            _logger.LogInformation("Estoy en el index");
            //var serviciomonedas = new ServicioMonedas();
            //var serviciomonedas = new ServicioCriptoMonedas();
            //IServicioMonedas serviciomonedas = new ServicioCriptoMonedas();
            var lista = this.servicioMonedas.ObtenerMonedas();

            return View();
        }

        public IActionResult Privacy()
        {

            //var serviciomonedas = new ServicioMonedas();
            //var serviciomonedas = new ServicioCriptoMonedas();
            //IServicioMonedas serviciomonedas = new ServicioCriptoMonedas();
            // var lista = this.servicioMonedas.ObtenerMonedas();
            var des = this.servicioMail.enviarMail();
            _logger.LogInformation("Enviar correo a: " + des);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}