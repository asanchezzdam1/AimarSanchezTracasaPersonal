namespace EjemploEventos
{
    public class RelojDigital
    {
        public RelojDigital()
        {
        }

        public void sucribir(Reloj reloj)
        {
            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;
        }

        private void Reloj_CambioSegundoEvento(object reloj, InformacionTiempoEventArgs informacionTiempo)
        {
            Console.WriteLine($"Hora Actual: {informacionTiempo.hora.ToString()}"
                               + $":{informacionTiempo.minuto.ToString()}"
                               + $":{informacionTiempo.segundo.ToString()}");
        }
    }
}