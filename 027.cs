using System;
using System.Linq; //Requiere esta librería

namespace Ejemplo {
    class Program {
        static void Main() {
            //Arreglo unidimensional
            int[] numeros = { 27, 18, 52, 42, 90, 12 };

            //Máximo, mínimo, suma
            int maximo = numeros.Max();
            int minimo = numeros.Min();
            int suma = numeros.Sum();

            //Imprime
            Console.WriteLine("Máximo: " + maximo.ToString());
            Console.WriteLine("Mínimo: " + minimo.ToString());
            Console.WriteLine("Suma: " + suma.ToString());

            Console.ReadKey();
        }
    }
}
