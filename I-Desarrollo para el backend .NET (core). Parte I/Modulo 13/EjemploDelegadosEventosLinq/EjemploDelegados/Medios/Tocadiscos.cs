using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados.Medios
{
    public class Tocadiscos 
    {

 
        //     bool              ()
        public bool ProbarVinilo()
        {
            Console.WriteLine("Por favor, ponga el disco en el tocadiscos");
            Console.WriteLine("Indique a continuación si ha escuchado algo S/N");
            var result = Console.ReadLine();

            // Equivale a if (result=="S")/else
            return result == "S";
        }

        public string ObternerCancionesVinilo(string codigoDeBarras)
        {

            return "Lista de canciones estan en contraportada";
        }


    }
}
