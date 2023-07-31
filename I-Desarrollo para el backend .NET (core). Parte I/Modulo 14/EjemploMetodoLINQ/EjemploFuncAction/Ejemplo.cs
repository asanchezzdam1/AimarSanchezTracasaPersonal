using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFuncAction
{
    internal class Ejemplo
    {
        internal void ejemploAction()
        {
            testAction(accion, 1);

            //Llamar a testAction escribiendo la expresion lambda como parametro entre los dos parentesis
            testAction((x) => Console.WriteLine($"En el metodo Accion: {x}"), 1);

            //crear una variable que almacene la accion

            Action<int> accion2 = (x) =>
            {
                Console.WriteLine($"En el metodo Accion: {x}");
            };

            //llama a testAction usando la varible
            testAction(accion2, 2);

            //Lista de accione

            List<Action<int>>actions = new List<Action<int>>();
            actions.Add(accion2);
            actions.Add(accion);

            foreach (Action<int> action in actions)
            {

            }

        }

        //Metodo que recibe un Action<int> y un int
        public void testAction(Action<int> action, int num)
        {
            action(num);
        }

        public void accion(int num)
        {
            Console.WriteLine($"En el metodo Accion: {num}");
        }


        internal void ejemploDelegados1()
        {

            // Expresión Lambda mediante Func<>

            Func<string> holaMundoExpresion =

                // Parametros
                ()
                // Operador Lambda
                =>
                // Delegado / Método anónimo / Expresión
                "Hola Mundo !!!!!!";

            Console.WriteLine(holaMundoExpresion);
            Console.WriteLine(holaMundoExpresion());

            // Expresion Lambda mediante Bloque Func<>
            Func<string> holaMundoBloque =

                // Parametros
                ()
                // Operador Lambda
                =>
                // Delegado / Método anónimo 
                {

                    var cadena = "Hola Mundo !!!!";
                    return cadena;
                };

            Console.WriteLine(holaMundoBloque());

            //Crear una expresion lambda que sume dos numeros

            Func<int, int, int> suma = (int a, int b) =>
            {
                return a + b;
            };
            Console.WriteLine(suma(2, 9));

        }
    }
}
