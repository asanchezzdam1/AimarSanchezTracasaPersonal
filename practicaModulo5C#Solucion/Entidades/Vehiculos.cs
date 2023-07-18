
namespace Entidades
{
    public class Vehiculos
    {
        public enum Etiqueta
        {
            cero,
            eco,
            c,
            b,
            sinEtiqueta
        }
        public Vehiculos()
        {
            
        }
        public Vehiculos(string propietario,string marca, DateTime fechaMatriculacion, Etiqueta etiqueta)
        {
            this.propietario = propietario;
            this.marca = marca;
            this.fechaMatriculacion = fechaMatriculacion;
            this.etiqueta = etiqueta;
        }
        public string propietario { get; set; }
        public string marca { get; set; }
        public DateTime fechaMatriculacion { get; set; }
        public Etiqueta etiqueta { get; set; }

        public string calcularInpuestos(Vehiculos vehiculo)
        {
            DateTime fechaActual = DateTime.Now;
            double precioBase = 1000;
            double anosAntiguedad = (fechaActual.Year - vehiculo.fechaMatriculacion.Year);
            if(anosAntiguedad < 0) anosAntiguedad = 0;
            double totalDePorcentajes = 0;
            switch (vehiculo.etiqueta)
            {
                case Etiqueta.cero:
                    totalDePorcentajes = 0;
                    break;
                case Etiqueta.eco:
                    totalDePorcentajes = 5;
                    break;
                case Etiqueta.c:
                    totalDePorcentajes = 10;
                    break;
                case Etiqueta.b:
                    totalDePorcentajes = 15;
                    break;
                case Etiqueta.sinEtiqueta:
                    totalDePorcentajes = 25;
                    break;
            }
            string mes = "";
            switch (vehiculo.fechaMatriculacion.Month)
            {
                case 1:
                    mes = "Enero";
                    break;
                case 2:
                    mes = "Febrero";
                    break;
                case 3:
                    mes = "Marzo";
                    break;
                case 4:
                    mes = "Abril";
                    break;
                case 5:
                    mes = "Mayo";
                    break;
                case 6:
                    mes = "Junio";
                    break;
                case 7:
                    mes = "Julio";
                    break;
                case 8:
                    mes = "Agosto";
                    break;
                case 9:
                    mes = "Septiembre";
                    break;
                case 10:
                    mes = "Octubre";
                    break;
                case 11:
                    mes = "Noviembre";
                    break;
                case 12:
                    mes = "Diciembre";
                    break;
            }
            totalDePorcentajes += anosAntiguedad;
            double totalDeInpuestos = precioBase + (precioBase * (totalDePorcentajes / 100));
            return "El vehiculo de la marca " 
                    + vehiculo.marca 
                    + ", matriculado el " 
                    + vehiculo.fechaMatriculacion.Day + " de " 
                    + mes + " del " 
                    + vehiculo.fechaMatriculacion.Year 
                    + " tiene que pagar " 
                    + totalDeInpuestos + " euros en concepto de inpuestos de circulación.";
        }
    }
}
