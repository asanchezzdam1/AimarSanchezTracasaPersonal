using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploAPI.Controllers
{

    public class Moneda
    {
        public string nombre{ get; set; }
    }

    // 1- Ruta
    //[Route("api/[controller]")]    
    [Route("api/Monedas")]

    //2-Controlador de tipo API
    [ApiController]

    public class MonedasController : ControllerBase //3-Hereda de controlador API
    {
        //Verbo Http
        [HttpGet]

        //Devuelve un ActionResult<Tipo>
        public ActionResult<IEnumerable<Moneda>> obtenerMonedas()
        {
            var lista = new List<Moneda>();
            lista.Add(new Moneda { nombre = "EUR" });

            //Devolver resultado y codigo de estado
            return Ok(lista);


        }
    }
}
