using EjemploDelegados.Medios;
using static EjemploDelegados.InventarioMedios;

namespace EjemploDelegados
{

    // Hay que crear una aplicación para 
    // el archivo de medios de una biblioteca publica
    // de modo que:
    // A-Segun el tipo de medio indique al usuario los pasos
    //   a dar para reproducir ese medio y verificar 
    //   si está en buen estado para archivarlo
    //   o bien desecharlo si está en mal estado
    // B-Crear una aplicación que permita indicar
    //   los pasos a dar independientemente del medio
    // C-Mostar el contenido del medio segun el tipo de medio.
    //      Pasar codigo indentificativo para localizarlo en la BBDDD
    //      CDs - Mostrar lista de canciones
    //      Vinilo - Mostrar lista de canciones
    //      VHS - Mostrar informacion de la pelicula

    internal class Program
    {
        static void Main(string[] args)
        {

            //++ 1-Crear instancias 

            // Crear la instancia del inventario de medios
            var inventarioMedios = new InventarioMedios();

            // Crear instancia reproductor de cassette
            var reproductorCassette = new ReproductorCassette();

            // Crear instancia Tocadiscos
            var tocaDiscos = new Tocadiscos();

            // Crear instancia reproductor VHS
            var videoVhs = new VideoVhs();


            //++ 2-Crear instancias de delegados
            ProbarMediosDelegado probarDiscosDelegado = new ProbarMediosDelegado(tocaDiscos.ProbarVinilo);
            ProbarMediosDelegado probarCintasVhsDelegado = new ProbarMediosDelegado(videoVhs.ProbarVideoVhs);
            ProbarMediosDelegado probarCassetDelegado = new ProbarMediosDelegado(reproductorCassette.ProbarCassette);
            InfoMediumDelegado informacionDiscosDelegado = new InfoMediumDelegado(tocaDiscos.ObternerCancionesVinilo);
            InfoMediumDelegado informacionCintasVhsDelegado = new InfoMediumDelegado(videoVhs.ObternerInfoPelicula);
            InfoMediumDelegado informacionCassetDelegado = new InfoMediumDelegado(reproductorCassette.ObternerCancionesCassette);

            //++ 3-Utilizar delegados
            //Probar un vinilo
            inventarioMedios.ResultadoProbarMedios(probarDiscosDelegado);
            //Probar un Casset
            inventarioMedios.ResultadoProbarMedios(probarCassetDelegado);
            //Probar un videoVhs
            inventarioMedios.ResultadoProbarMedios(probarCintasVhsDelegado);            
            //Info un vinilo
            inventarioMedios.ResultadoInfoMedios(informacionDiscosDelegado, "sdasd");
            //Info un Casset
            inventarioMedios.ResultadoInfoMedios(informacionCintasVhsDelegado, "asdas");
            //Info un videoVhs
            inventarioMedios.ResultadoInfoMedios(informacionCassetDelegado, "dsaasd");







        }
    }
}