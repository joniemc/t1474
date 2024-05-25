using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosBiDimencionales
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[,] miArreglo;
            Console.Write("Ingrese el numero de filas que desea: ");
            int filas = Convert.ToInt16(Console.ReadLine());
            Console.Write("Ingrese el numero de columnas que desea: ");
            int columnas = Convert.ToInt16(Console.ReadLine());

            miArreglo = new double[filas, columnas];

            Console.WriteLine("==========Lectura de Datos==========");
            for (int i = 0; i<filas; i++) {
                Console.WriteLine("Estoy en la fila: {0}", i+1);
                for (int j = 0; j<columnas; j++) {
                    Console.Write("Ingrese el valor de la fila {0} y columna {1}: ", i+1, j+1);
                    miArreglo[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            for (int i = 0; i<filas; i++)
            {
                Console.WriteLine();
                for (int j = 0; j<columnas; j++)
                {
                    Console.Write(" {0}", miArreglo[i, j]); 
                }
            }

            for (int i = 0; i<filas; i++)
            {
                for (int j = 0; j<columnas; j++)
                {
                    if (i==j) {
                        miArreglo[i, j]=0;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i<filas; i++)
            {
                Console.Write("\n");
                for (int j = 0; j<columnas; j++)
                {
                    Console.Write(" {0}", miArreglo[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
