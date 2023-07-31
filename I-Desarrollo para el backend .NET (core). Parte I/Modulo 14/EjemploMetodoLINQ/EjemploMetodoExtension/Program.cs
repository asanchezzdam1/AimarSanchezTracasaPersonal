using Extensiones;
namespace EjemploMetodoExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var juan = "JuAN lOpEz".convertirCadena();
            var luis = "lUiS MaRTinEz".convertirCadena();

            var saludo = "Hola Mundo !!!!!";

            var convertir = saludo.convertirCadena();

            var fecha = DateTime.Now;
            var ano = fecha.obtenerAño();

            var a = 1;
            var b = 2;

            if (a.aEsMayorQueB(b)) Console.WriteLine("Es mayor el numero A");
            else Console.WriteLine("Es menor el numero A");

            var lista  = new List<int>() { 1,2,3,4,5,6};

            var primero = lista.primeraPosicion();
        }
    }
}