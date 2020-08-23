using System;
using System.Diagnostics;

namespace Ejemplo {
    class Program {
        static void Main() {
            //Limite de todos los arreglos
            int Limite = 10;

            //Arreglos
            int[,] bidimensional = new int[Limite, Limite];
            int[,,] tridimensional = new int[Limite, Limite, Limite];
            int[,,,] cuatrodimensiones = new int[Limite, Limite, Limite, Limite];
            int[,,,,] cincodimensiones = new int[Limite, Limite, Limite, Limite, Limite];

            //Medidor de tiempos
            Stopwatch cronometro = new Stopwatch();

            //Llenando un arreglo bidimensional
            int valor = 0;
            cronometro.Reset();
            cronometro.Start();
            for (int a = 0; a < bidimensional.GetLength(0); a++)
                for (int b = 0; b < bidimensional.GetLength(1); b++)
                    bidimensional[a, b] = valor++;
            long TBidim = cronometro.ElapsedTicks;

            //Llenando un arreglo tridimensional
            valor = 0;
            cronometro.Reset();
            cronometro.Start();
            for (int a = 0; a < tridimensional.GetLength(0); a++)
                for (int b = 0; b < tridimensional.GetLength(1); b++)
                    for (int c = 0; c < tridimensional.GetLength(2); c++)
                        tridimensional[a, b, c] = valor++;
            long TTridim = cronometro.ElapsedTicks;

            //Llenando un arreglo de cuatro dimensiones
            valor = 0;
            cronometro.Reset();
            cronometro.Start();
            for (int a = 0; a < cuatrodimensiones.GetLength(0); a++)
                for (int b = 0; b < cuatrodimensiones.GetLength(1); b++)
                    for (int c = 0; c < cuatrodimensiones.GetLength(2); c++)
                        for (int d = 0; d < cuatrodimensiones.GetLength(3); d++)
                            cuatrodimensiones[a, b, c, d] = valor++;
            long TCuatrodim = cronometro.ElapsedTicks;

            //Llenando un arreglo de cinco dimensiones
            valor = 0;
            cronometro.Reset();
            cronometro.Start();
            for (int a = 0; a < cincodimensiones.GetLength(0); a++)
                for (int b = 0; b < cincodimensiones.GetLength(1); b++)
                    for (int c = 0; c < cincodimensiones.GetLength(2); c++)
                        for (int d = 0; d < cincodimensiones.GetLength(3); d++)
                            for (int e = 0; e < cincodimensiones.GetLength(4); e++)
                                cincodimensiones[a, b, c, d, e] = valor++;
            long TCincodim = cronometro.ElapsedTicks;

            //Imprime los tiempos
            Console.WriteLine("Tiempo arreglo bidimensional: " + TBidim.ToString());
            Console.WriteLine("Tiempo arreglo tridimensional: " + TTridim.ToString());
            Console.WriteLine("Tiempo arreglo cuatro dimensiones: " + TCuatrodim.ToString());
            Console.WriteLine("Tiempo arreglo cinco dimensiones: " + TCincodim.ToString());

            Console.ReadKey();
        }
    }
}
