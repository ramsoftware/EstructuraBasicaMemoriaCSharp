using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejemplo {
    class Program {
        static void Main() {
            //Una cadena
            string[] Cadenas = { "gato", "perro", "avestruz", "toro", "ballena", "kakapo" };

            /* Se ordena usando Linq
             * Invierte el orden */
            IEnumerable<string> resultado = Cadenas.Reverse();
            Console.WriteLine("Invierte el orden");
            foreach (string valor in resultado) {
                Console.WriteLine("[" + valor + "] ");
            }

            Console.ReadKey();
        }
    }
}