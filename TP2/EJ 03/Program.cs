using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_03
{
    class Program
    {
        static ControladordeFachada Fachada = new ControladordeFachada();

        static void VentanaJugar()
        {
            ResultadoIntento resultado = new ResultadoIntento();
            Console.Write("Ingrese Su nombre:");
            string jugador = Console.ReadLine();
            char[] arregloJuego = Fachada.InicializarPartida(jugador);
            Console.Clear();

            while (resultado.Finalizado == false)
            {
                Console.Clear();
                Console.WriteLine("INGRESE SU INTENTO:");
                Console.WriteLine();
                Console.WriteLine("        ");
                for (int i = 0; i < arregloJuego.Length; i++)
                {
                    Console.Write($"{arregloJuego[i]} ");
                }

                string intento = Console.ReadLine();
                resultado = Fachada.Intento(intento[0]);
            }
        }

        static void VentanaPrincipal()
        {
            Console.Clear();
            Console.WriteLine(" - AHORCADO -");
            Console.WriteLine();
            Console.WriteLine("1 - Jugar");
            Console.WriteLine("2 - Configurar cantidad de fallos");
            Console.WriteLine("3 - Mejores Partidas");
            Console.WriteLine("0 - Salir");

            var entrada = Console.ReadKey();
            switch (entrada.Key)
            {
                case ConsoleKey.D1:
                    {
                        VentanaJugar();
                        break;
                    }

                /*case ConsoleKey.D2:
                    {
                        VentanaMejores();
                        break;
                    }*/

                case ConsoleKey.D0:
                    {
                        break;
                    }
            }
               
        }

        static void Main(string[] args)
        {
            VentanaPrincipal();
        }
    }
}
