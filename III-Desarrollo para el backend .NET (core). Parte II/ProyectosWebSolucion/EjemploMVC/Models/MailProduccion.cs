using EjemploMVC.Servicios;

namespace EjemploMVC.Models
{
    public class MailProduccion:IMail
    {
        public string enviarMail()
        {
            return "Producion";
        }
    }
}
