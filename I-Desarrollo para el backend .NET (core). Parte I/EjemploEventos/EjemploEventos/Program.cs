namespace EjemploEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1- crear instancia del reloj interno (Publicador)
            var reloj = new Reloj();

            // 2- Crear un reloj digital y nos suscribimos (Subcriptor)
            var relojDigital = new RelojDigital();
            relojDigital.sucribir(reloj);

            //Ejercicio:
            //Crear un log o un registro que guarde cada 10 segundos la fecha y hora
            var log = new Registro();
            log.sucribir(reloj);


            // 3- Poner en marcha el reloj
            reloj.inciarReloj();

        }
    }
}