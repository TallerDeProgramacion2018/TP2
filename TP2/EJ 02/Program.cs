using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_02
{
    class Program
    {
        static ControladorFachada Fachada = new ControladorFachada();

        // Definimos ventanas que luego serán llamadas en el main.

        static void VentanaPrincipal()
        {
            Console.Clear();
            Console.WriteLine("     Elija la operacion que desea realizar.");
            Console.WriteLine();
            Console.WriteLine("1: Consultar saldo de caja de ahorro.");
            Console.WriteLine("2: Consultar saldo de la cuenta corriente.");
            Console.WriteLine("3: Transferir dinero hacia caja de ahorro.");
            Console.WriteLine("4: Transferir dinero hacia cuenta corrinte.");
            Console.WriteLine("0: Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    {
                        Console.Clear();
                        Console.WriteLine("El saldo de su cuenta es: {0}", Fachada.ObtenerSaldoCajaDeAhorro());
                        Console.ReadKey();
                        VentanaPrincipal();
                        break;
                    }

                case "2":
                    {
                        Console.Clear();
                        Console.WriteLine("El saldo de su cuenta es: {0}", Fachada.ObtenerSaldoCuentaCorriente());
                        Console.ReadKey();
                        VentanaPrincipal();
                        break;
                    }

                case "3":
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese monto a transferir: ");
                        double monto = Convert.ToDouble(Console.ReadLine());
                        if (Fachada.TransferirCajaDeAhorro(monto))
                        {
                            Console.WriteLine($"Operacion completada con éxito, el nuevo saldo es {Fachada.ObtenerSaldoCajaDeAhorro():0.00}");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente, la operación no se pudo completar.");
                        }
                        Console.ReadKey();
                        VentanaPrincipal();
                        break;
                    }

                case "4":
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese monto a transferir: ");
                        double monto = Convert.ToDouble(Console.ReadLine());
                        if (Fachada.TransferirCuentaCorriente(monto))
                        {
                            Console.WriteLine($"Operacion completada con éxito, el nuevo saldo es {Fachada.ObtenerSaldoCajaDeAhorro():0.00}");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente, la operación no se pudo completar.");
                        }
                        Console.ReadKey();
                        VentanaPrincipal();
                        break;
                    }

                case "0":
                        break;
            }
        }

        static void Main(string[] args)
        {
            VentanaPrincipal();
        }
    }
}
