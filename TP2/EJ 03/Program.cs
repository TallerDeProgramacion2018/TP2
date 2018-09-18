﻿using System;
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
            Console.Clear();
            ResultadoIntento resultado = new ResultadoIntento();
            Console.Write("Ingrese Su nombre:");
            string jugador = Console.ReadLine();
            char[] arregloJuego = Fachada.InicializarPartida(jugador);
            Console.Clear();

            Console.WriteLine("Desea cambiar la cantidad de fallos?");
            Console.WriteLine("Ingrese S para Si o N para No");
            char respuesta = Convert.ToChar(Console.ReadLine());

            if (respuesta == 's')
            {
                VentanaConfigurarFallos();
            }


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

            if (Fachada.Finalizar())
            {
                Console.Clear();
                Console.WriteLine("     ---     VICTORIA    ---");
                Console.ReadKey();
                Fachada.AlmacenarPartida();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("     ---     DERROTA   ---");
                Console.ReadKey();
            }

            VentanaPrincipal();
        }

        static void VentanaConfigurarFallos()
        {
            Console.Clear();
            Console.Write("Ingrese la cantidad de fallos maximos que desea:");
            int cantFallos = Convert.ToInt32 (Console.ReadLine());

            Fachada.ConfigurarFallos(cantFallos);
            
        }

        static void VentanaMejores_5_Partidas()
        {
            Console.WriteLine("Estas son las mejores 5 partidas ganadas:");
            Partida[] resultado = Fachada.ListarMejores();

            for (int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine("Nombre: " + resultado[i].NombreJugador);
                Console.WriteLine(resultado[i].Duracion());
                Console.WriteLine();
            }
            Console.ReadLine();

            VentanaPrincipal();
        }

        static void VentanaPrincipal()
        {
            Console.Clear();
            Console.WriteLine(" - AHORCADO -");
            Console.WriteLine();
            Console.WriteLine("1 - Jugar");
            Console.WriteLine("2 - Mejores Partidas");
            Console.WriteLine("0 - Salir");

            var entrada = Console.ReadKey();
            switch (entrada.Key)
            {
                case ConsoleKey.D1:
                    {
                        VentanaJugar();
                        break;
                    }

                case ConsoleKey.D2:
                    {
                        VentanaMejores_5_Partidas();
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
