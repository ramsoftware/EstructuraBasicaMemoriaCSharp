using System;

namespace Ejemplo {
    class Program {
        static void Main() {
            //Constante
            const string cadena = "abcdefghijk";

            //Se intenta cambiar la constante y da error en compilación
            cadena = "Hola Mundo";

            //Imprimiendo por consola
            Console.WriteLine(cadena);

            Console.ReadKey();
        }
    }
}