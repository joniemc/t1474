using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesGenericas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listarNombres = new List<string>();
            List<double> listarNotas = new List<double>();
            int opcion = 0;
            do {
                Console.WriteLine("Seleccione una opción: \n" +
                    "1. Ingresar Datos\n" +
                    "0. Salir");
                opcion = Convert.ToInt16(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Ingrese el nombre: ");
                    string nombre = Console.ReadLine();
                    listarNombres.Add(nombre);
                    Console.Write("Ingrese la calificación: ");
                    double calificacion = Convert.ToDouble(Console.ReadLine());
                    listarNotas.Add(calificacion);
                }
                else if (opcion==0)
                {
                    Console.WriteLine("Gracias por utilizar nuestro sistema...");
                }
                else {
                    Console.WriteLine("Opción invalida...");  
                }
            } while (opcion!=0);

            for (int i = 0; i<listarNombres.Count; i++) {
                Console.WriteLine("{0} -- {1}",listarNombres.ElementAt(i), listarNotas.ElementAt(i));
            }

            Console.ReadKey();
        }
    }
}
