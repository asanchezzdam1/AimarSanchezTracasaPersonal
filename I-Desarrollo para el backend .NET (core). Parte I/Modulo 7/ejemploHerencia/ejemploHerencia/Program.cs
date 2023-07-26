namespace ejemploHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear empleados
            Empleado empleado = new Empleado("Aitor");
            Trabajador trabajador = new Trabajador("Uxue");
            Trabajador trabajador1 = new Trabajador("Aimar", "Mañana", false);
            Trabajador trabajador2 = new Trabajador("Julen", "Noche", true, "Conasa");
            Administrador administrador = new Administrador("Alain");
            Administrador administrador1 = new Administrador("Amaia", false);
            Administrador administrador2 = new Administrador("Beñat", true, 23);
            //Crear una lista de empleados
            var empleados = new List<Empleado>();
            //Añadir los empleados a la lista
            empleados.Add(empleado);
            empleados.Add(trabajador);
            empleados.Add(trabajador1);
            empleados.Add(trabajador2);
            empleados.Add(administrador);
            empleados.Add(administrador1);
            empleados.Add(administrador2);
            //Consulta sql en c# que separa los empleados que su nombre empiezan por j
            var resultado = from emp in empleados where emp.nombre.ToLower().StartsWith("j") orderby emp.nombre ascending select emp;
            //Bucle que recorre la consulta anterior y llama a la funcion CalculoVacaciones()
            foreach(var emp  in resultado)
                emp.CalculoVacaciones();
            //ToString de los empleados
            foreach (var emp in empleados)
                Console.WriteLine(emp.ToString());

            //Capturar extepción
            try
            {
                if (administrador2.plaza)
                {
                    Console.WriteLine(administrador2.PlazaParking());
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            //Creamos otro empleado y lo añadimos a la lista
            Administrador administrador3 = new Administrador("Julene", false);
            empleados.Add(administrador3);
            //Hacemos otra consulta sql
            var resultado1 = from emp in empleados where emp.nombre.ToLower().StartsWith("j") orderby emp.nombre ascending select emp;
            //Bucle que recorre la consulta anterior y llama a la funcion CalculoVacaciones() y muestra el ToString()
            foreach (var emp in resultado1)
            {
                emp.CalculoVacaciones();
                Console.WriteLine(emp.ToString());
            }
            Externo externo = new Externo("Xabi", "Conasa");
            empleados.Add(externo);
            foreach(var emp in empleados)
            {
                var tipo = emp.GetType().Name;
                switch(tipo) 
                {
                    case "Trabajador":
                        //TODO: Mostrar turno
                        var tbj = (Trabajador)emp;
                        Console.WriteLine(tbj.turno);  
                        break;
                    case "Administrador":
                        //TODO: Mostrar plaza parking
                        var admin = (Administrador)emp;
                        try
                        {
                            if(admin.plaza) Console.WriteLine(admin.PlazaParking());
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "Externo":
                        var ext = (Externo)emp;
                        Console.WriteLine(ext.empresa);
                        break;
                }
            }
        }
    }
}