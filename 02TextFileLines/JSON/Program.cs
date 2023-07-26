using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;

namespace JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonMovie = @"{'Name': 'Interstellar', 'ReleaseDate': '2014-11-05T00:00:00Z', 'Genres': ['Science Fiction', 'Adventure', 'Drama']}";
            Movie movie = JsonConvert.DeserializeObject<Movie>(jsonMovie);
            Console.WriteLine("Datos de la pelicula: ");
            Console.WriteLine("Titulo: " + movie.Name);
            Console.WriteLine("Fecha: " + movie.ReleaseDate.ToString());
            Console.WriteLine("Generos: ");
            foreach (string genre in movie.Genres)
            {
                Console.WriteLine("- " + genre);
            }
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            string? solutionName = assembly.GetName().Name;
            string path = Directory.GetCurrentDirectory();
            string newPath = "";
            string[] pathArray = path.Split(new string[] { "\\" }, StringSplitOptions.None);

            foreach (string parte in pathArray)
            {
                if (parte != "bin") newPath += parte + "\\";
                else
                    if (newPath.Contains(solutionName!)) break;
                else newPath += parte + "\\";
            };
            string filePath = newPath + "\\monedas.json";
            string jsonString = File.ReadAllText(filePath);
            List<Moneda> monedas = JsonConvert.DeserializeObject<List<Moneda>>(jsonString);
            foreach (Moneda moneda in monedas)
            {
                Console.WriteLine("Nombre: " + moneda.nombre);
                Console.WriteLine("Código: " + moneda.codigo);
                Console.WriteLine("Valor en dólares: " + moneda.valorEnDolares);
                Console.WriteLine();
            }
        }
    }
}