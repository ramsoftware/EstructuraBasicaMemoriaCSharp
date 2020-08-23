using System;

namespace Ejemplo {
    class Program {
        static void Main() {
            //Arreglo unidimensional
            string[] cadenas = { "def", "agh", "abc", "efg", "bcd", "klm", "iao", "hñu" };

            //Ordena el arreglo
            Array.Sort(cadenas);

            //Recorre el arreglo y lo imprime
            foreach(string texto in cadenas) {
                Console.WriteLine(texto);
            }

            Console.ReadKey();
        }
    }
}