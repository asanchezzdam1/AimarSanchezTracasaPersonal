using EjemploMVC.Servicios;

namespace EjemploMVC.Models
{
    public class MailDesarrollo:IMail
    {
        public string enviarMail()
        {
            return "Desarrollo";
        }
    }
}
