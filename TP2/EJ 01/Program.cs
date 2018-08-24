using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_01
{
    class Program
    {
        static ControladorDeFachada Fachada = new ControladorDeFachada();

        static void VentanaTriangulo()
        {
            Console.Clear();
            Console.WriteLine("  1. Calcular área");
            Console.WriteLine("  2. Calcular perímetro");

            var entrada = Console.ReadKey();
            switch (entrada.Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.Write("Ingrese la abscisa del primer punto: ");
                        string x1s = Console.ReadLine();
                        double x1 = Convert.ToDouble(x1s);

                        Console.Write("Ingrese la ordenada del primer punto: ");
                        string y1s = Console.ReadLine();
                        double y1 = Convert.ToDouble(y1s);

                        Console.Write("Ingrese la abscisa del segundo punto: ");
                        string x2s = Console.ReadLine();
                        double x2 = Convert.ToDouble(x2s);

                        Console.Write("Ingrese la ordenada del segundo punto: ");
                        string y2s = Console.ReadLine();
                        double y2 = Convert.ToDouble(y2s);

                        Console.Write("Ingrese la abscisa del tercer punto: ");
                        string x3s = Console.ReadLine();
                        double x3 = Convert.ToDouble(x3s);

                        Console.Write("Ingrese la ordenada del tercer punto: ");
                        string y3s = Console.ReadLine();
                        double y3 = Convert.ToDouble(y3s);

                        double areaTriangulo = Fachada.AreaTriangulo(x1, y1, x2, y2, x3, y3);
                        Console.WriteLine($"El área del triángulo es {areaTriangulo:0.000}");
                        Console.ReadLine();
                        break;
                    }

                case ConsoleKey.D2:
                    {
                        Console.Write("Ingrese la abscisa del primer punto: ");
                        string x1s = Console.ReadLine();
                        double x1 = Convert.ToDouble(x1s);

                        Console.Write("Ingrese la ordenada del primer punto: ");
                        string y1s = Console.ReadLine();
                        double y1 = Convert.ToDouble(y1s);

                        Console.Write("Ingrese la abscisa del segundo punto: ");
                        string x2s = Console.ReadLine();
                        double x2 = Convert.ToDouble(x2s);

                        Console.Write("Ingrese la ordenada del segundo punto: ");
                        string y2s = Console.ReadLine();
                        double y2 = Convert.ToDouble(y2s);

                        Console.Write("Ingrese la abscisa del tercer punto: ");
                        string x3s = Console.ReadLine();
                        double x3 = Convert.ToDouble(x3s);

                        Console.Write("Ingrese la ordenada del tercer punto: ");
                        string y3s = Console.ReadLine();
                        double y3 = Convert.ToDouble(y3s);

                        double perimetroTriangulo = Fachada.PerimetroTriangulo(x1, y1, x2, y2, x3, y3);
                        Console.WriteLine($"El perímetro del triángulo es {perimetroTriangulo:0.000}");
                        Console.ReadLine();
                        break;
                    }

                case ConsoleKey.D0:
                    {
                        VentanaPrincipal();
                        break;
                    }
            }
        }

        static void VentanaCirculo()
        {
            Console.Clear();

            Console.WriteLine("  1. Calcular área");
            Console.WriteLine("  2. Calcular perímetro");

            var entrada = Console.ReadKey();
            switch (entrada.Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.Write("Ingrese la abscisa del primer punto: ");
                        string x1s = Console.ReadLine();
                        double x1 = Convert.ToDouble(x1s);

                        Console.Write("Ingrese la ordenada del primer punto: ");
                        string y1s = Console.ReadLine();
                        double y1 = Convert.ToDouble(y1s);

                        Console.Write("Ingrese el radio del circulo: ");
                        string radios = Console.ReadLine();
                        double radio = Convert.ToDouble(radios);

                        double areaCirculo = Fachada.AreaCirculo(x1, y1, radio);
                        Console.WriteLine($"El área del círculo es {areaCirculo:0.000}");
                        Console.ReadLine();
                        break;
                    }

                case ConsoleKey.D2:
                    {
                        Console.Write("Ingrese la abscisa del primer punto: ");
                        string x1s = Console.ReadLine();
                        double x1 = Convert.ToDouble(x1s);

                        Console.Write("Ingrese la ordenada del primer punto: ");
                        string y1s = Console.ReadLine();
                        double y1 = Convert.ToDouble(y1s);

                        Console.Write("Ingrese el radio del circulo: ");
                        string radios = Console.ReadLine();
                        double radio = Convert.ToDouble(radios);

                        double perimetroCirculo = Fachada.PerimetroCirculo(x1, y1, radio);
                        Console.WriteLine($"El perímetro del círculo es {perimetroCirculo:0.000}");
                        Console.ReadLine();
                        break;

                    }

                case ConsoleKey.D0:
                    {
                        VentanaPrincipal();
                        break;
                    }
            }
        }

            static void VentanaPrincipal()
            {
                Console.Clear();
                Console.WriteLine(" - Geometría - ");
                Console.WriteLine();

                Console.WriteLine(" Seleccione la opción para continuar:");
                Console.WriteLine();
                Console.WriteLine("  1. Triángulo");
                Console.WriteLine("  2. Circulo");
                Console.WriteLine("  0. Salir");

                var entrada = Console.ReadKey();
                switch (entrada.Key)
                {
                    case ConsoleKey.D1:
                        {
                            VentanaTriangulo();
                            break;
                        }

                    case ConsoleKey.D2:
                        {
                            VentanaCirculo();
                            break;
                        }
                    case ConsoleKey.D0: break;
                }

            }

            static void Main(string[] args)
            {
                VentanaPrincipal();
            }
    }
}
