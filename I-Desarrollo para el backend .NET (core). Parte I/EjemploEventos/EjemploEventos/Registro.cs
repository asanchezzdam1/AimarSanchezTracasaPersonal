namespace EjemploEventos
{
    public class Registro
    {
        public Registro()
        {
        }

        public void sucribir(Reloj reloj)
        {
            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;
        }

        int i = 0;
        private void Reloj_CambioSegundoEvento(object reloj, InformacionTiempoEventArgs informacionTiempo)
        {

            if (i == 10)
            {
                DateTime dateTime = DateTime.Now;
                Console.WriteLine("Fecha y hora del registro: " 
                    + dateTime.Year + "/" 
                    + dateTime.Month + "/" 
                    + dateTime.Day + " " 
                    + informacionTiempo.hora.ToString() + ":" 
                    + informacionTiempo.minuto.ToString() + ":" 
                    + informacionTiempo.segundo.ToString());
                i = 0;
            }
            i++;
        }
    }
}