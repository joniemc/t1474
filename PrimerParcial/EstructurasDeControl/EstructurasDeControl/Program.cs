using System;

namespace EstructurasDeControl {
    public class Program {
        public static void Main(string[] args)
        {
            double promedio = 0;
            double sumaAcumulada = 0;
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int cantidadEstudiantes = Convert.ToInt32(Console.ReadLine());

            for (int i=0;i<cantidadEstudiantes;i++) {
                Console.Write("Ingrese la calificación #{0}: ",i+1);
                double calificacon = Convert.ToDouble(Console.ReadLine());
                sumaAcumulada += calificacon;
            }

            promedio = sumaAcumulada/cantidadEstudiantes;
            Console.WriteLine("El promedio de la sección es: "+promedio);

            Console.ReadKey();
        }
    }
}