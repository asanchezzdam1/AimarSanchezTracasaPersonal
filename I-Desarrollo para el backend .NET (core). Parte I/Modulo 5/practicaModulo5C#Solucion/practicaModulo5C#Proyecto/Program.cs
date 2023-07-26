using Entidades;
namespace practicaModulo5C_Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculos generico = new Vehiculos();
            Vehiculos vehiculo1 = new Vehiculos("Juan","Kia",new DateTime(2017,09,29), Vehiculos.Etiqueta.c);
            Vehiculos vehiculo2 = new Vehiculos("Nerea","Opel",new DateTime(2008,12,26), Vehiculos.Etiqueta.b);
            Vehiculos vehiculo3 = new Vehiculos("Ibai","Ford",new DateTime(1993,09,29), Vehiculos.Etiqueta.sinEtiqueta);
            Vehiculos vehiculo4 = new Vehiculos("Pedro","Seat",new DateTime(2014,01,12), Vehiculos.Etiqueta.b);
            Vehiculos vehiculo5 = new Vehiculos("Amaia","Toyota",new DateTime(2020,01,12), Vehiculos.Etiqueta.eco);
            Vehiculos vehiculo6 = new Vehiculos("Daniel","Tesla",new DateTime(2023,05,25), Vehiculos.Etiqueta.cero);

            var lista = new List<Vehiculos>();
            lista.Add(vehiculo1);
            lista.Add(vehiculo2);
            lista.Add(vehiculo3);
            lista.Add(vehiculo4);
            lista.Add(vehiculo5);
            lista.Add(vehiculo6);
            
            foreach (var vehiculo in lista)
            {
                Console.WriteLine(generico.calcularInpuestos(vehiculo));  
            }
        }
    }
}