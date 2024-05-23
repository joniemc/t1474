using System;

namespace EjercicioClaseFarmacia02 {
    public class Program {
        public static void Main(string[] args) {
            //Valores de entrada
            int opcion;
            int tipoCliente;
            double calculoTotalVentaConDescuento;

            //Variables que almacenan la suma acumulada de las ventas por tipo de cliente
            double totalVentasClienteConReceta = 0;
            double totalVentasTerceraEdad = 0;
            double totalVentasEmpleados = 0;
            double totalVentasOtrosClientes = 0;

            //Variables que hacen el conteo de ventas por tipo de cliente
            int contClienteConReceta = 0;
            int contTerceraEdad = 0;
            int contEmpleados = 0;
            int contOtrosClientes = 0;

            do
            {
                //MenuPrincipal();

                MenuAutoGenerado();

                opcion = Convert.ToInt16(Console.ReadLine());

                if (opcion==1)
                {
                    Console.WriteLine();
                    MenuRegitraraVenta();
                    tipoCliente = Convert.ToInt16(Console.ReadLine());

                    switch (tipoCliente)
                    {
                        case 1:
                            CalcularVentasConDescuentoEmpleados(ref totalVentasEmpleados, ref contEmpleados);
                            break;
                        case 2:
                            calculoTotalVentaConDescuento = LecturaVentaTotal()*0.85;
                            totalVentasClienteConReceta += calculoTotalVentaConDescuento;
                            contClienteConReceta++;
                            Console.WriteLine("El monto total con descuento aplicado es: L. "+calculoTotalVentaConDescuento);
                            Console.WriteLine();
                            break;
                        case 3:
                            calculoTotalVentaConDescuento = LecturaVentaTotal()*0.75;
                            totalVentasTerceraEdad += calculoTotalVentaConDescuento;
                            contTerceraEdad++;
                            Console.WriteLine();
                            Console.WriteLine("El monto total con descuento aplicado es: L. "+calculoTotalVentaConDescuento);
                            break;
                        case 4:
                            double ventaTotal = LecturaVentaTotal();
                            totalVentasOtrosClientes += ventaTotal;
                            contOtrosClientes++;
                            Console.WriteLine("El monto total con descuento aplicado es: L. "+ventaTotal);
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("Opción invalida...");
                            Console.WriteLine();
                            break;
                    }

                }
                else if (opcion==2)
                {
                    Console.WriteLine("======CIERRE DEL DIA======");
                    Console.WriteLine("Promedio de ventas para empleados: L. "+CalcularPromedioVentasPorTipoCliente(totalVentasEmpleados, contEmpleados));
                    Console.WriteLine("Promedio de ventas para clientes con receta: L. "+CalcularPromedioVentasPorTipoCliente(totalVentasClienteConReceta, contClienteConReceta));
                    Console.WriteLine("Promedio de ventas para tecera edad: L. "+CalcularPromedioVentasPorTipoCliente(totalVentasTerceraEdad, contTerceraEdad));
                    Console.WriteLine("Promedio de ventas para otros clientes: L. "+CalcularPromedioVentasPorTipoCliente(totalVentasOtrosClientes, contOtrosClientes));
                }
                else
                {
                    Console.WriteLine("Opción invalida...");
                }


            } while (opcion!=2);

            Console.ReadKey();
        }

        public static void MenuAutoGenerado()
        {
            Console.WriteLine("===============Menu===============");
            Console.WriteLine("1. Registrar una venta");
            Console.WriteLine("2. Registrar el cierre diario");
            Console.Write("Seleccione una opción: ");
        }

        private static void CalcularVentasConDescuentoEmpleados(ref double totalVentasEmpleados, ref int contEmpleados)
        {
            double calculoTotalVentaConDescuento = LecturaVentaTotal()*0.70;
            totalVentasEmpleados += calculoTotalVentaConDescuento;
            contEmpleados++;
            Console.WriteLine("El monto total con descuento aplicado es: L. "+calculoTotalVentaConDescuento);
            Console.WriteLine();
        }

        public static void MenuPrincipal() {
            Console.WriteLine("===============Menu===============");
            Console.WriteLine("1. Registrar una venta");
            Console.WriteLine("2. Registrar el cierre diario");
            Console.Write("Seleccione una opción: ");
        }
        public static void MenuRegitraraVenta() {
            Console.WriteLine("===============Registrar una venta===============");
            Console.WriteLine("1. Empleado");
            Console.WriteLine("2. Cliente con receta");
            Console.WriteLine("3. Cliente de tercera edad");
            Console.WriteLine("4. Cualquier otro cliente");
            Console.Write("Seleccione una opción: ");
        }
        public static double LecturaVentaTotal() {
            Console.Write("Ingrese el monto total de la venta: L. ");
            double miVenta = Convert.ToDouble(Console.ReadLine());
            return miVenta;
        }
        public static double CalcularPromedioVentasPorTipoCliente(double totalVentasDiarias, int cantidadVentasDiarias) {
            if (cantidadVentasDiarias>0)
            {
                return totalVentasDiarias/cantidadVentasDiarias;
            }

            return 0;
        }
    }
}