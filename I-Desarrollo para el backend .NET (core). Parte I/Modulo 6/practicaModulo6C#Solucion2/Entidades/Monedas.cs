
namespace Entidades
{
    public class Monedas
    {
        const double eurosDolar = 1.12;
        const double eurosLibra = 0.87;
        const double dolarEuros = 0.89;
        const double dolarLibra = 0.77;
        const double libraEuros = 1.15;
        const double libraDolar = 1.29;
        public enum Moneda
        {
            Euro,
            Dolar,
            Libra
        }
        public int monedaOrigen { get; set; }
        public int monedaDestino { get; set; }
        public int cantidad { get; set; }
        public Moneda origen { get; set; }
        public Moneda destino { get; set; }

        public Monedas(int monedaOrigen, int monedaDestino, int cantidad)
        {
            this.monedaOrigen = monedaOrigen;
            this.monedaDestino = monedaDestino;
            this.cantidad = cantidad;
        }
        public string calcular()
        {
            double resultado = 0;
            switch (monedaOrigen)
            {
                case 1:
                    origen = Moneda.Euro;
                    break;
                case 2:
                    origen = Moneda.Dolar;
                    break;
                case 3:
                    origen = Moneda.Libra;
                    break;
            }
            switch (monedaDestino)
            {
                case 1:
                    destino = Moneda.Euro;
                    break;
                case 2:
                    destino = Moneda.Dolar;
                    break;
                case 3:
                    destino = Moneda.Libra;
                    break;
            }
            if (origen != destino)
            {
                if (origen == Moneda.Euro)
                {
                    if (destino == Moneda.Dolar) resultado = cantidad * eurosDolar;
                    else resultado = cantidad * eurosLibra;
                }
                else if (origen == Moneda.Dolar)
                {
                    if (destino == Moneda.Euro) resultado = cantidad * dolarEuros;
                    else resultado = cantidad * dolarLibra;
                }
                else
                {
                    if (destino == Moneda.Euro) resultado = cantidad * libraEuros;
                    else resultado = cantidad * libraDolar;
                }
            }
            else return "Error en la conversion";
            return "La moneda de origen es: " + origen + " y de destino " + destino + ".\nEl total de la conversión son " + resultado + monedaDestino;
        }
    }
}
