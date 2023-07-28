namespace EjemploEventos
{
    public class InformacionTiempoEventArgs
    {
        public int hora { get; set; }
        public int minuto{ get; set; }
        public int segundo { get; set; }
        public InformacionTiempoEventArgs(int hora, int minuto, int segundo)
        {
            this.hora = hora;
            this.minuto = minuto;
            this.segundo = segundo;
        }
    }
}