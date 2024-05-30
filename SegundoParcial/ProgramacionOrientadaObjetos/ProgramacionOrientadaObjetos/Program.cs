using ProgramacionOrientadaObjetos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            do {
                Menu();
                opcion = Convert.ToInt16(Console.ReadLine());
                if (opcion == 1)
                {
                    Estudiante miEstudiante = new Estudiante();
                    Console.Write("Ingrese su numero de cuenta: ");
                    miEstudiante.cuenta = Console.ReadLine();
                    Console.Write("Ingrese su nombre completo: ");
                    miEstudiante.nombreCompleto = Console.ReadLine();
                    Console.Write("Ingrese su calificación: ");
                    miEstudiante.calificación = Convert.ToDouble(Console.ReadLine());

                    listaEstudiantes.Add(miEstudiante); 
                }
                else {
                    Console.WriteLine("Gracias por utilizar nuestro sistema..");
                }
            } while (opcion!=0);

            foreach (Estudiante miEstudiante in listaEstudiantes) {
                Console.WriteLine(miEstudiante.ToString());
            }

            Console.ReadKey();
        }
        private static void Menu() {
            Console.WriteLine("=============MENU=============\n" +
                "1. Para registrar un estudiante\n" +
                "0. Para Salir");
            Console.Write("Elija una opción: ");
        }
    }
}
