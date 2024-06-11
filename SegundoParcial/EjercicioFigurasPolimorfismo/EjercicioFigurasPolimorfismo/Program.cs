using EjercicioFigurasPolimorfismo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFigurasPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura[] listarFiguras = new Figura[2];

            for (int i=0;i<listarFiguras.Length;i++) {
                Console.WriteLine("1. Para Triangulo\n2. Para Circulo");
                Console.Write("seleccione la opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el color: ");
                string color = Console.ReadLine();
                if (opcion ==1) {
                    Console.Write("Ingrese la base: ");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura: ");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    Triangulo triangulo = new Triangulo(color,baseTriangulo,altura);
                    listarFiguras[i] = triangulo;
                }
                else if (opcion ==2) {
                    Console.Write("Ingrese el radio del circulo: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    Circulo circulo = new Circulo(color,radio);
                    listarFiguras[i] = circulo;
                }
                else
                {
                    Console.WriteLine("Opción Invalida..");
                }
                

            }

            foreach (Figura figura in listarFiguras) {
                Console.WriteLine(figura.ToString());
            }

            Console.ReadKey();
        }

    }
}
