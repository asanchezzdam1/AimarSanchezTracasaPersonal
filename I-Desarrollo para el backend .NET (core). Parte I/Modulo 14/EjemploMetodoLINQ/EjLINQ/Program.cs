using EjLinq;

namespace EjLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ejemplo = new EjemploBasico();
            ejemplo.Ejecutar();

            var ejemploOperador1 = new EjemploOperador1();
            ejemploOperador1.Ejecutar();
        }
    }
}