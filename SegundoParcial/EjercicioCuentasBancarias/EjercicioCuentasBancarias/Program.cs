using EjercicioCuentasBancarias.Config;
using EjercicioCuentasBancarias.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuentasBancarias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            int opcionMenuP = 0;
            int opcionMenuCC = 0;

            do {
                DatabaseConnection ejemplo = new DatabaseConnection();
                List<Usuario> usuarios = ejemplo.ExecuteSQL("select * from tbl_usuario");

                foreach (Usuario usuario in usuarios) {
                    Console.WriteLine(usuario.Nombre);
                    Console.WriteLine(usuario.Correo);
                }

                MenuPrincipal();
                opcionMenuP = Convert.ToInt16(Console.ReadLine());
                string idCuenta;
                switch (opcionMenuP) {
                    case 1:// Agregar Cuenta
                        Console.WriteLine();
                        MenuCrearCuentaCliente();
                        opcionMenuCC = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Ingrese Numero de Cuenta: ");
                        idCuenta = Console.ReadLine();
                        Console.Write("Ingrese el Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese monto inicial: ");
                        double balance = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese porcetaje de interes (entre 1 - 100): ");
                        int interes = Convert.ToInt16(Console.ReadLine());
                        if (opcionMenuCC == 1) {
                            CuentaBasica basica = new CuentaBasica(idCuenta,nombre,balance,interes);
                            cuentas.Add(basica);
                            Console.WriteLine("Cuenta creada satisfactoriamente...");
                        } else if (opcionMenuCC==2) {
                            CuentaPremium premium = new CuentaPremium(idCuenta, nombre, balance, interes);
                            cuentas.Add(premium);
                            Console.WriteLine("Cuenta creada satisfactoriamente...");
                        } else if(opcionMenuCC==3) {
                            Console.WriteLine("Gracias por crear su cuenta con nosotros..");
                        }
                        else
                        {
                            Console.WriteLine("Opción Invalida..");
                        }

                        break;
                    case 2: // Borrar Cuenta
                        Console.WriteLine();
                        Console.WriteLine("=================BORRAR CUENTA=================");
                        Console.Write("Ingrese Numero de Cuenta: ");
                        idCuenta = Console.ReadLine();
                        Cuenta buscarCuentaExistente = cuentas.Find(c=>c.IdCuenta==idCuenta);
                        if (buscarCuentaExistente !=null)
                        {
                            cuentas.Remove(buscarCuentaExistente);
                            Console.Write("Cuenta eliminada con exito..");
                        }
                        else {
                            Console.Write("Lo sentimos, no hemos encontrado su cuenta..");
                        }
                        break;
                    case 3: // Depositar
                        Console.WriteLine();
                        Console.WriteLine("=================DEPOSITO=================");
                        Console.Write("Ingrese Numero de Cuenta: ");
                        idCuenta = Console.ReadLine();
                        Console.Write("Monto del deposito: ");
                        double deposito = Convert.ToDouble(Console.ReadLine());
                        foreach (Cuenta elemento in cuentas) {
                            if (elemento.IdCuenta.Equals(idCuenta)) {
                                elemento.Deposito(deposito);
                                Console.WriteLine("Deposito exitoso...");
                            }
                        }
                        break;
                    case 4: // Retirar
                        Console.WriteLine();
                        Console.WriteLine("=================RETIRO=================");
                        Console.Write("Ingrese Numero de Cuenta: ");
                        idCuenta = Console.ReadLine();
                        Console.Write("Monto del Retiro: ");
                        double retiro = Convert.ToDouble(Console.ReadLine());
                        foreach (Cuenta elemento in cuentas)
                        {
                            if (elemento.IdCuenta.Equals(idCuenta))
                            {
                                elemento.Retiro(retiro);
                                Console.WriteLine("Retiro exitoso...");
                            }
                        }
                        break;
                    case 5: //Imprimir Reporte
                        Console.WriteLine();
                        Console.WriteLine("=================REPORTE=================");
                        foreach (Cuenta elemento in cuentas) {
                            Console.WriteLine(elemento);
                            Console.WriteLine();
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            } while (opcionMenuP!=0);
            Console.ReadKey();
        }
        private static void MenuPrincipal() {
            Console.WriteLine("=================MENU PRINCIPAL=================");
            Console.WriteLine("1. Agregar Cuenta");
            Console.WriteLine("2. Borrar Cuenta");
            Console.WriteLine("3. Depositar");
            Console.WriteLine("4. Retirar");
            Console.WriteLine("5. Imprimir Reporte");
            Console.WriteLine("0. Salir");
            Console.Write("\nElija una opción: ");

        }
        private static void MenuCrearCuentaCliente()
        {
            Console.WriteLine("=================CREAR CUENTA=================");
            Console.WriteLine("1. Cuenta Básica");
            Console.WriteLine("2. Cuenta Premium");
            Console.WriteLine("3. Salir");
            Console.Write("\nElija una opción: ");
        }
    }
}
