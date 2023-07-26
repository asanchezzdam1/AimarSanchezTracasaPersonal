using Entidades;

namespace practicaModulo6C_Proyecto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano1 = 0;
            int ano2 = 0;

            //Pedir datos vehiculo 1
            Console.WriteLine("**********************************************");
            Console.WriteLine("Datos vehiculo 1");
            Console.WriteLine("Introduzca el año de matriculación: ");
            string ano1Text = Console.ReadLine();
            Console.WriteLine("Introduzca el color: ");
            string color1 = Console.ReadLine();
            //Pedir datos vehiculo 2
            Console.WriteLine("**********************************************");
            Console.WriteLine("Datos vehiculo 2");
            Console.WriteLine("Introduzca la marca: ");
            string marca1 = Console.ReadLine();
            Console.WriteLine("Introduzca el modelo: ");
            string modelo1 = Console.ReadLine();
            //Pedir datos vehiculo 3
            Console.WriteLine("**********************************************");
            Console.WriteLine("Datos vehiculo 3");
            Console.WriteLine("Introduzca el año de matriculación: ");
            string ano2Text = Console.ReadLine();
            Console.WriteLine("Introduzca el color: ");
            string color2 = Console.ReadLine();
            Console.WriteLine("Introduzca la marca: ");
            string marca2 = Console.ReadLine();
            Console.WriteLine("Introduzca el modelo: ");
            string modelo2 = Console.ReadLine();
            Console.WriteLine("**********************************************");

            try
            {
                ano1 = int.Parse(ano1Text); 
            }
            catch (Exception)
            {
                ano1 = 0;
            }            
            try
            {
                ano2 = int.Parse(ano2Text); 
            }
            catch (Exception)
            {
                ano2 = 0;
            }

            var vehiculo1 = new Vehiculos(ano1, color1);
            var vehiculo2 = new Vehiculos(marca1, modelo1);
            var vehiculo3 = new Vehiculos(ano2, color2,
                                         marca2, modelo2);
        
            Console.WriteLine("\nLos vehiculos creados son los siguientes:");
            Console.WriteLine("Vehiculo 1, constructor que recibe año de compra y color");
            Console.WriteLine("Año de matriculación: " + vehiculo1.anoCompra + "\nColor: " + vehiculo1.color);
            Console.WriteLine("Vehiculo 2, constructor que recibe la marca y modelo");
            Console.WriteLine("Marca: " + vehiculo2.marca + "\nModelo: " + vehiculo2.modelo);
            Console.WriteLine("Vehiculo 3, constructor que recibe todos los parametros");
            Console.WriteLine("Año de matriculación: "
                                + vehiculo3.anoCompra
                                + "\nColor: "
                                + vehiculo3.color
                                + "\nMarca: "
                                + vehiculo3.marca
                                + "\nModelo: "
                                + vehiculo3.modelo);
        }
    }
}