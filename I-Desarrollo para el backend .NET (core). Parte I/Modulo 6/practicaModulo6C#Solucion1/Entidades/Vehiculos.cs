
namespace Entidades
{
    public class Vehiculos
    {
        public int anoCompra { get; set; }
        public string color { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }

        public Vehiculos(int anoCompra, string color)
        {
            this.anoCompra = anoCompra;
            this.color = color;
        }
        public Vehiculos(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }
        public Vehiculos(int anoCompra, string color, string marca, string modelo)
        {
            this.anoCompra = anoCompra;
            this.color = color;
            this.marca = marca;
            this.modelo = modelo;
        }
    }
}
