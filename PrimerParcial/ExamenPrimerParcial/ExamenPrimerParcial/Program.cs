using System;

namespace ExamenPrimerParcial {
    public class Program {
        public static void Main(string[] args)
        {
            int opcion;
            do {
                MenuPrincipal();
                opcion = Convert.ToInt16(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        Ejercicio1();
                        break;
                    case 2:
                        Ejercicio2();
                        break;
                    case 3:
                        Ejercicio3();
                        break;
                    case 4:
                        Console.WriteLine("Gracias por realizar su examen..");
                        break;
                    default:
                        break;
                }
            } while (opcion!=4);
        }
        public static void MenuPrincipal() {
            Console.WriteLine("================MENU================");
            Console.WriteLine("1. Numeros mayores o menores que 7");
            Console.WriteLine("2. Calcular promedio de ventas por dependiente");
            Console.WriteLine("3. Identificar vocales");
            Console.WriteLine("4. Salir");
        }
        public static void Ejercicio1() {
            int numeroEntero;
            int contadorEsMayorQue7=0;
            int contadorEsMenorQue7 = 0;
            do {
                Console.Write("Ingrese un numero entero entre 1 y 9 o presione -1 para salir: ");
                numeroEntero = Convert.ToInt32(Console.ReadLine());

                if (numeroEntero >= 7 && numeroEntero <=9)
                {
                    contadorEsMayorQue7++;
                }
                else if (numeroEntero < 7 && numeroEntero >= 1)
                {
                    contadorEsMenorQue7++;
                }
                else if (numeroEntero == -1) {
                    Console.WriteLine("Fin del programa... ");
                }
                else
                {
                    Console.WriteLine("El numero debe estar entre 1 y 9 ");
                }

            } while (numeroEntero!=-1);

            Console.WriteLine("La cantidad de numeros menores que 7 son: "+contadorEsMenorQue7);
            Console.WriteLine("la cantidad de numeros mayores que 7 son: "+contadorEsMayorQue7);
            
        }

        public static void Ejercicio2() {
            //variables globales
            double ventasVendedorA=0;
            double ventasVendedorB = 0;
            double ventasVendedorC = 0;
            
            int contVendedorA = 0;
            int contVendedorB = 0;
            int contVendedorC = 0;

            string opcion = string.Empty;
            do {
                Console.Write("Elija el codigo de dependiente (-A,B o C-) o presione F: ");
                opcion = Console.ReadLine();
                Console.Write("Ingrese el monto total a pagar: ");
                double venta = Convert.ToDouble(Console.ReadLine());
                switch (opcion.ToUpper()) {
                    case "A":
                        contVendedorA++;
                        ventasVendedorA+= venta;
                        break;
                    case "B":
                        contVendedorB++;
                        ventasVendedorB+= venta;
                        break;
                    case "C":
                        contVendedorC++;
                        ventasVendedorC+= venta;
                        break;
                    case "F":
                        Console.WriteLine("=========Estado de resultados=========\n" +
                            "Promedio de ventas vendedor A: {0}" +
                            "\nPromedio de ventas vendedor B: {1}" +
                            "\nPromedio de ventas vendedor C: {2}",CalcularPromedio(ventasVendedorA,contVendedorA), 
                            CalcularPromedio(ventasVendedorB, contVendedorB), 
                            CalcularPromedio(ventasVendedorC, contVendedorC));
                        Console.WriteLine("Gracias por usar nuestro sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción invalida");
                        break;
                }
            } while (!opcion.Equals("F"));
        }
        public static double CalcularPromedio(double venta, int numeroVentas) {
            return venta/numeroVentas;
        }

        public static void Ejercicio3() {
            Console.Write("Presione una letra: ");
            string letra = Console.ReadLine();

            switch (letra.ToUpper()) {
                case "A":
                case "E":
                case "I":
                case "O":
                case "U":
                    Console.WriteLine("Es vocal");
                    break;
                default:
                    Console.WriteLine("No es vocal");
                    break;
            }

            if (letra.ToUpper().Equals("A")||letra.ToUpper().Equals("E")
                ||letra.ToUpper().Equals("I")||letra.ToUpper().Equals("O")
                ||letra.ToUpper().Equals("U"))
            {
                Console.WriteLine("Es vocal desde el if...");
            }
            else {
                Console.WriteLine("No es vocal desde el else...");
            }
        }
    }
}