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

        static void VentanaPrincipal()
        {
            Console.Clear();
            Console.WriteLine("     Elija la operacion que desea realizar.");
            Console.WriteLine();
            Console.WriteLine("1: Consultar saldo de caja de ahorro.");
            Console.WriteLine("2: Consultar saldo de la cuenta corriente.");
            Console.WriteLine("3: Transferir dinero hacia cuenta corrinte.");
            Console.WriteLine("4: Transferir dinero hacia caja de ahorro.");
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
                        Fachada.TransferirCuentaCorriente(monto);
                        Console.WriteLine($"Operacion completada con éxito, el nuevo saldo es {Fachada.ObtenerSaldoCuentaCorriente():0.00}");
                        Console.ReadKey();
                        VentanaPrincipal();
                        break;
                    }

                case "4":
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese monto a transferir: ");
                        double monto = Convert.ToDouble(Console.ReadLine());
                        Fachada.TransferirCajaDeAhorro(monto);
                        Console.WriteLine($"Operacion completada con éxito, el nuevo saldo es {Fachada.ObtenerSaldoCajaDeAhorro():0.00}");
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
