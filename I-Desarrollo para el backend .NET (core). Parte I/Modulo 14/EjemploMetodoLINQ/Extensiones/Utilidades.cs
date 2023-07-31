namespace Extensiones
{
    public static class Utilidades
    {
        public static string convertirCadena(this string cadena)
        {
            return cadena.Trim().ToUpper() + ".";
        }
        public static bool aEsMayorQueB(this int a, int b)
        {
            return a > b;
        }

        public static int obtenerAño(this DateTime dateTime)
        {
            return dateTime.Year;
        }

        public static int primeraPosicion(this List<int> lista)
        {
            return lista[0];
        }
    }
}
