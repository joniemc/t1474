using System;
using System.Timers;

namespace ClaseArreglos01 {
    public class Program {
        public static void Main(string[] args)
        {
            int[] numerosEnteros;

            Console.Write("Ingrese el tamaño del arreglo: ");
            int lengthArray = Convert.ToInt16(Console.ReadLine());

            numerosEnteros = new int[lengthArray];

            Console.WriteLine();
            Console.WriteLine("=========Lectura de datos=========");
            for (int i=0; i<numerosEnteros.Length; i++) {
                Console.Write("Ingrese el elemento #{0}: ",i+1);
                numerosEnteros[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("=========Resultado=========");
            foreach (int numero in numerosEnteros) {
                Console.WriteLine("{0}",numero);
            }

            Console.WriteLine();
            Console.WriteLine("=========Tratamiento de datos=========");
            for (int i = 0; i<numerosEnteros.Length; i++)
            {
                if (numerosEnteros[i]%2==0)
                {
                    Console.WriteLine("El numero {0} es par", numerosEnteros[i]);
                    numerosEnteros[i] = 0;
                }
                else if (numerosEnteros[i]%2!=0){
                    Console.WriteLine("El numero {0} es impar", numerosEnteros[i]);
                    numerosEnteros[i] = 1;
                }
                
            }

            Console.WriteLine("=========Resultado 2=========");
            foreach (int numero in numerosEnteros)
            {
                Console.WriteLine("{0}", numero);
            }
            Console.WriteLine();
            Console.WriteLine("=========Analisis=========");
            Console.WriteLine("El primer elemento del arreglo es: {0}",numerosEnteros[0]);
            Console.WriteLine("El ultimo elemento del arreglo es: {0}", numerosEnteros[numerosEnteros.Length-1]);
            Console.WriteLine("El tamaño del arreglo es: {0}", numerosEnteros.Length);
             
            Console.ReadKey();
        }
    }
}