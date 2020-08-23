using System;

namespace Ejemplo {
    class Program {
        static void Main() {
            //Funciones de números
            int numero = 41514;
            Console.WriteLine(numero.ToString() + " es impar: " + EsImpar(numero).ToString());
            Console.WriteLine(numero.ToString() + " es par: " + EsPar(numero).ToString());
            Console.WriteLine(numero.ToString() + " total de cifras: " + TotalCifras(numero).ToString());
            Console.WriteLine(numero.ToString() + " sus dos últimas cifras: " + Retornadosultimascifras(numero).ToString());
            Console.WriteLine(numero.ToString() + " su antepenúltima cifra: " + AntepenultimaCifra(numero).ToString());
            Console.WriteLine(numero.ToString() + " su penúltima cifra: " + PenultimaCifra(numero).ToString());
            Console.WriteLine(numero.ToString() + " su última cifra: " + UltimaCifra(numero).ToString());
            Console.WriteLine(numero.ToString() + " la cifra más alta: " + LaCifraMasAlta(numero).ToString());
            Console.WriteLine(numero.ToString() + " la cifra más baja: " + LaCifraMasBaja(numero).ToString());
            Console.WriteLine(numero.ToString() + " total de cifras iguales a 5 es: " + Cifrashalladas(numero, 5).ToString());
            Console.WriteLine(numero.ToString() + " al invertirlo es: " + InvierteNumero(numero).ToString());
            Console.WriteLine(numero.ToString() + " es palíndromo: " + EsPalindromo(numero).ToString());
            Console.WriteLine(numero.ToString() + " tercera cifra es: " + CifraPosicion(numero, 3).ToString());
            Console.WriteLine(numero.ToString() + " primera cifra es: " + PrimeraCifra(numero).ToString());
            Console.WriteLine(numero.ToString() + " la suma de las cifras es: " + SumaCifras(numero).ToString());
            Console.WriteLine(numero.ToString() + " la suma de las cifras pares es: " + SumaCifrasPares(numero).ToString());
            Console.WriteLine(numero.ToString() + " la suma de las cifras impares es: " + SumaCifrasImpares(numero).ToString());
            Console.WriteLine(numero.ToString() + " la multiplicación de las cifras es: " + MultiplicaCifras(numero).ToString());
            Console.WriteLine(numero.ToString() + " la multiplicación de las cifras pares es: " + MultiplicaCifrasPares(numero).ToString());
            Console.WriteLine(numero.ToString() + " la multiplicación de las cifras impares es: " + MultiplicaCifrasImpares(numero).ToString());
            Console.WriteLine(numero.ToString() + " todas las cifras son pares: " + TodasCifrasPares(numero).ToString());
            Console.WriteLine(numero.ToString() + " todas las cifras son impares: " + TodasCifrasImpares(numero).ToString());
            Console.WriteLine(numero.ToString() + " total cifras pares: " + TotalCifrasPares(numero).ToString());
            Console.WriteLine(numero.ToString() + " total cifras impares: " + TotalCifrasImpares(numero).ToString());
            Console.WriteLine(numero.ToString() + " solo hay cifras menores o iguales a 5: " + SoloCifrasMenorIgual(numero, 5).ToString());
            Console.WriteLine(numero.ToString() + " solo hay cifras mayores o iguales a 5: " + SoloCifrasMayorIgual(numero, 5).ToString());
            Console.WriteLine(numero.ToString() + " usa distintas cifras: " + DistintasCifras(numero).ToString());
            Console.WriteLine(numero.ToString() + " usa distintas cifras pares: " + DistintasCifrasPares(numero).ToString());
            Console.WriteLine(numero.ToString() + " usa distintas cifras impares: " + DistintasCifrasImPares(numero).ToString());
            Console.WriteLine(numero.ToString() + " extrayendo cifras pares: " + NumeroSoloPares(numero).ToString());
            Console.WriteLine(numero.ToString() + " extrayendo cifras impares: " + NumeroSoloImpares(numero).ToString());
            Console.ReadKey();
        }

        // Retorna true si un número es impar
        static bool EsImpar(int numero) {
            return numero % 2 == 1;
        }

        // Retorna true si un número es par
        static bool EsPar(int numero) {
            return numero % 2 == 0;
        }

        // Retorna el número de cifras de un número
        static int TotalCifras(int numero) {
            int copia = numero;
            int cuenta = 0;
            while (copia != 0) {
                cuenta++;
                copia /= 10;
            }
            return cuenta;
        }

        // Retorna las dos últimas cifras del número
        static int Retornadosultimascifras(int numero) {
            return numero % 100;
        }

        // Retorna la antepenúltima cifra de un número entero
        static int AntepenultimaCifra(int numero) {
            return (numero / 100) % 10;
        }

        // Retorna la penúltima cifra de un número entero
        static int PenultimaCifra(int numero) {
            return (numero / 10) % 10;
        }

        // Retorna la última cifra de un número entero
        static int UltimaCifra(int numero) {
            return numero % 10;
        }

        // Retorna la cifra más alta
        static int LaCifraMasAlta(int numero) {
            int copia = numero;
            int cifra = 0;
            while (copia != 0) {
                if (copia % 10 > cifra) cifra = copia % 10;
                copia /= 10;
            }
            return cifra;
        }

        // Retorna la cifra más baja
        static int LaCifraMasBaja(int numero) {
            if (numero == 0) return 0;
            int copia = numero;
            int cifra = 9;
            while (copia != 0) {
                if (copia % 10 < cifra) cifra = copia % 10;
                copia /= 10;
            }
            return cifra;
        }

        // Dice cuántas cifras de determinado número hay en el número enviado
        static int Cifrashalladas(int numero, int cifra) {
            int copia = numero;
            int acumula = 0;
            while (copia != 0) {
                if (copia % 10 == cifra) acumula++;
                copia /= 10;
            }
            return acumula;
        }

        // Invierte un número
        static int InvierteNumero(int numero) {
            int copia = numero;
            int multiplica = (int)Math.Pow(10, TotalCifras(copia) - 1);
            int acumula = 0;
            while (copia != 0) {
                int cifra = copia % 10;
                acumula += cifra * multiplica;
                multiplica /= 10;
                copia /= 10;
            }
            return acumula;
        }

        // Retorna true si el número es palíndromo
        static bool EsPalindromo(int numero) {
            if (numero == InvierteNumero(numero)) return true;
            return false;
        }

        //Retorna la cifra de una determinada posición
        static int CifraPosicion(int numero, int posicion) {
            int copia = InvierteNumero(numero);
            int pos = 1;
            while (copia != 0) {
                int cifra = copia % 10;
                if (pos == posicion) return cifra;
                copia /= 10;
                pos++;
            }
            return 0;
        }

        // Retorna la primera cifra de un número
        static int PrimeraCifra(int numero) {
            return CifraPosicion(numero, 1);
        }

        // Retorna la sumatoria de las cifras de un número
        static int SumaCifras(int numero) {
            int copia = numero;
            int acumula = 0;
            while (copia != 0) {
                int cifra = copia % 10;
                acumula += cifra;
                copia /= 10;
            }
            return acumula;
        }

        // Retorna la sumatoria de las cifras pares de un número
        static int SumaCifrasPares(int numero) {
            int copia = numero;
            int acumula = 0;
            while (copia != 0) {
                int cifra = copia % 10;
                if (cifra % 2 == 0) acumula += cifra;
                copia /= 10;
            }
            return acumula;
        }

        // Retorna la sumatoria de las cifras impares de un número
        static int SumaCifrasImpares(int numero) {
            int copia = numero;
            int acumula = 0;
            while (copia != 0) {
                int cifra = copia % 10;
                if (cifra % 2 != 0) acumula += cifra;
                copia /= 10;
            }
            return acumula;
        }

        // Retorna el producto de las cifras de un número
        static int MultiplicaCifras(int numero) {
            if (numero == 0) return 0;
            int copia = numero;
            int acumula = 1;
            while (copia != 0) {
                int cifra = copia % 10;
                acumula *= cifra;
                copia /= 10;
            }
            return acumula;
        }

        // Retorna el producto de las cifras pares de un número
        static int MultiplicaCifrasPares(int numero) {
            int copia = numero;
            int acumula = 1;
            bool HayPar = false;
            while (copia != 0) {
                int cifra = copia % 10;
                if (cifra % 2 == 0) {
                    acumula *= cifra;
                    HayPar = true;
                }
                copia /= 10;
            }
            if (HayPar) return acumula;
            return 0;
        }

        // Retorna el producto de las cifras impares de un número
        static int MultiplicaCifrasImpares(int numero) {
            int copia = numero;
            int acumula = 1;
            bool HayImpar = false;
            while (copia != 0) {
                int cifra = copia % 10;
                if (cifra % 2 != 0) {
                    acumula *= cifra;
                    HayImpar = true;
                }
                copia /= 10;
            }
            if (HayImpar) return acumula;
            return 0;
        }

        // Retorna true si todas las cifras son pares
        static bool TodasCifrasPares(int numero) {
            int copia = numero;
            while (copia != 0) {
                int cifra = copia % 10;
                if (cifra % 2 != 0) return false;
                copia /= 10;
            }
            return true;
        }

        // Retorna true si todas las cifras son impares
        static bool TodasCifrasImpares(int numero) {
            int copia = numero;
            if (copia == 0) return false;
            while (copia != 0) {
                int cifra = copia % 10;
                if (cifra % 2 == 0) return false;
                copia /= 10;
            }
            return true;
        }

        // Retorna el número de cifras pares
        static int TotalCifrasPares(int numero) {
            int copia = numero;
            int acumula = 0;
            while (copia != 0) {
                int cifra = copia % 10;
                if (cifra % 2 == 0) acumula++;
                copia /= 10;
            }
            return acumula;
        }

        // Retorna el número de cifras impares
        static int TotalCifrasImpares(int numero) {
            int copia = numero;
            int acumula = 0;
            while (copia != 0) {
                int cifra = copia % 10;
                if (cifra % 2 != 0) acumula++;
                copia /= 10;
            }
            return acumula;
        }

        // Retorna true si el número tiene sólo cifras menores o iguales a cifra
        static bool SoloCifrasMenorIgual(int numero, int cifra) {
            int copia = numero;
            while (copia != 0) {
                if (copia % 10 > cifra) return false;
                copia /= 10;
            }
            return true;
        }

        // Retorna true si el número tiene sólo cifras mayores o iguales a cifra
        static bool SoloCifrasMayorIgual(int numero, int cifra) {
            int copia = numero;
            while (copia != 0) {
                if (copia % 10 < cifra) return false;
                copia /= 10;
            }
            return true;
        }

        // Retorna true si todas las cifras son distintas
        static bool DistintasCifras(int numero) {
            for (int cifra = 0; cifra <= 9; cifra++) {
                int copia = numero;
                int cuenta = 0;
                while (copia != 0) {
                    if (copia % 10 == cifra) cuenta++;
                    if (cuenta > 1) return false;
                    copia /= 10;
                }
            }
            return true;
        }

        // Retorna si todas las cifras pares son distintas
        static bool DistintasCifrasPares(int numero) {
            for (int cifra = 0; cifra <= 8; cifra += 2) {
                int copia = numero;
                int cuenta = 0;
                while (copia != 0) {
                    if (copia % 10 == cifra) cuenta++;
                    if (cuenta > 1) return false;
                    copia /= 10;
                }
            }
            return true;
        }

        // Retorna si todas las cifras impares son distintas
        static bool DistintasCifrasImPares(int numero) {
            for (int cifra = 1; cifra <= 9; cifra += 2) {
                int copia = numero;
                int cuenta = 0;
                while (copia != 0) {
                    if (copia % 10 == cifra) cuenta++;
                    if (cuenta > 1) return false;
                    copia /= 10;
                }
            }
            return true;
        }

        //Retorna un número con solo las cifras pares
        static int NumeroSoloPares(int numero) {
            int copia = numero;
            int acumula = 0;
            int posicion = 1;
            while (copia != 0) {
                int cifra = copia % 10;
                if (cifra % 2 == 0) {
                    acumula += posicion * cifra;
                    posicion *= 10;
                }
                copia /= 10;
            }
            return acumula;
        }

        //Retorna un número con solo las cifras impares
        static int NumeroSoloImpares(int numero) {
            int copia = numero;
            int acumula = 0;
            int posicion = 1;
            while (copia != 0) {
                int cifra = copia % 10;
                if (cifra % 2 != 0) {
                    acumula += posicion * cifra;
                    posicion *= 10;
                }
                copia /= 10;
            }
            return acumula;
        }
    }
}
