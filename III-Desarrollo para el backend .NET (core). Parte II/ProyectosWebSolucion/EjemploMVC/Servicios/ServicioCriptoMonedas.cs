using EjemploMVC.Models;

namespace EjemploMVC.Servicios
{
    public class ServicioCriptoMonedas:IServicioMonedas
    {

        public List<Moneda> Monedas { get; set; }


        public List<Moneda> ObtenerMonedas()
        {
            return Monedas;
        }
    }
}
