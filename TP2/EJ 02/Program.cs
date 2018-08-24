using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_02
{
    class Program
    {
        static void Main(string[] args)
        {
            ControladorFachada controladorFachada;
            Console.WriteLine("Elija la operacion que desea realizar.");
            Console.ReadLine();
            Console.WriteLine("Opcion 1: Consultar saldo de caja de ahorro.");
            Console.WriteLine("Opcion 2: Consultar saldo de la cuenta corriente.");
            Console.WriteLine("Opcion 2: Transferir dinero hacia cuenta corrinte.");
            Console.WriteLine("Opcion 3: Transferir dinero hacia caja de ahorro.");

            int opcion = Console.ReadLine();

            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("El saldo de su cuenta es: {0}", controladorFachada.obtenerSaldoCajaDeAhorro());
                    }

            }
        }
    }
}
