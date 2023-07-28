using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEventos
{
    public class Reloj
    {
        //Delegado
        public delegate void CambioSegundoDelegado(object reloj, InformacionTiempoEventArgs informacionTiempo);

        //evento
        public event CambioSegundoDelegado CambioSegundoEvento;

        public Reloj()
        {
            
        }

        private int segundo;
        public void inciarReloj()
        {
            DateTime dateTime;
            for (; ; )
            {
                Thread.Sleep(100);

                dateTime = DateTime.Now;
                if (dateTime.Second != segundo)
                {
                    //Console.WriteLine(segundo);
                    var informacionTiempo = new InformacionTiempoEventArgs(dateTime.Hour, dateTime.Minute, dateTime.Second);

                    //Lanzar evento
                    if (CambioSegundoEvento != null) CambioSegundoEvento(this, informacionTiempo);
                }
                segundo = dateTime.Second;
            }
        }
    }
}
