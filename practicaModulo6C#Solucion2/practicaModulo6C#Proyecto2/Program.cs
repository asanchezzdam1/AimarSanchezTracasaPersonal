using Entidades;

namespace practicaModulo6C_Proyecto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            bool primeraEjecucion = true;
            while (true)
            {
                if (!primeraEjecucion)
                {
                    Console.WriteLine("Pulse enter");
                    Console.ReadLine();
                    Console.Clear();
                }

                string opText = "";
                string opTextOrigen = "";
                string opTextDestino = "";
                string cantidadText = "";

                int op = -1;
                int opOrigen = -1;
                int opDestino = -1;
                int cantidad = 0;
                do
                {
                    program.menu1();
                    opText = Console.ReadLine();
                    try
                    {
                        op = Int32.Parse(opText);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Formato no valido");
                    }
                }
                while (op < 1 || op > 2);
                switch (op)
                {
                    case 1:
                        do
                        {
                            program.menu2("origen");
                            opTextOrigen = Console.ReadLine();
                            try
                            {
                                opOrigen = Int32.Parse(opTextOrigen);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Formato no valido");
                            }
                        }
                        while (opOrigen < 1 || opOrigen > 3);

                        do
                        {
                            program.menu2("destino");
                            opTextDestino = Console.ReadLine();
                            try
                            {
                                opDestino = Int32.Parse(opTextDestino);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Formato no valido");
                            }
                        }
                        while (opDestino < 1 || opDestino > 3);

                        while (true)
                        {
                            Console.WriteLine("Seleccione la cantidad a covertir (SOLO NUMEROS ENTEROS)");
                            cantidadText = Console.ReadLine();
                            try
                            {
                                cantidad = Int32.Parse(cantidadText);
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Formato no valido");
                            }
                        }
                        var moneda = new Monedas(opOrigen,opDestino, cantidad);
                        Console.WriteLine(moneda.calcular());
                        primeraEjecucion = false;
                        break;
                    case 2:
                        Console.WriteLine("Gracias por usar nuestra aplicación");
                        Environment.Exit(0);
                        break;
                }
            }
        }
        private void menu1()
        {
            Console.WriteLine("************* MENU *************");
            Console.WriteLine("* 1- Convertir                 *");
            Console.WriteLine("* 2- Salir                     *");
            Console.WriteLine("********************************");
            Console.WriteLine("Seleccione una opción: ");
        }
        private void menu2(string accion)
        {
            Console.WriteLine("************* MENU *************");
            Console.WriteLine("* 1- Euro                      *");
            Console.WriteLine("* 2- Dolar                     *");
            Console.WriteLine("* 3- Libra                     *");
            Console.WriteLine("********************************");
            Console.WriteLine("Seleccione la moneda de " + accion + ": ");
        }
    }
}