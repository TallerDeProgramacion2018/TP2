using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_01
{
    class ControladorDeFachada
    {

        // Este método en base a coordenadas y un radio, crea un objeto circulo y le pide su área.
        public double AreaCirculo(double pX, double pY, double pRadio)
        {
            Punto centro = new Punto(pX, pY);
            Circulo circulo = new Circulo(centro, pRadio);

            return circulo.Area;
        }

        public double PerimetroCirculo(double pX, double pY, double pRadio)
        {
            Punto centro = new Punto(pX, pY);
            Circulo circulo = new Circulo(centro, pRadio);

            return circulo.Perimetro;
        }

        // Este método en base a coordenadas, crea tres puntos, con los cuales crea un objeto triangulo y le pide su área.
        public double AreaTriangulo(double pPuntoX1, double pPuntoY1, double pPuntoX2, double pPuntoY2, double pPuntoX3, double pPuntoY3)
        {
            Punto punto1 = new Punto(pPuntoX1, pPuntoY1);
            Punto punto2 = new Punto(pPuntoX2, pPuntoY2);
            Punto punto3 = new Punto(pPuntoX3, pPuntoY3);

            Triangulo triangulo = new Triangulo(punto1, punto2, punto3);

            return triangulo.Area;
        }

        public double PerimetroTriangulo(double pPuntoX1, double pPuntoY1, double pPuntoX2, double pPuntoY2, double pPuntoX3, double pPuntoY3)
        {
            Punto punto1 = new Punto(pPuntoX1, pPuntoY1);
            Punto punto2 = new Punto(pPuntoX2, pPuntoY2);
            Punto punto3 = new Punto(pPuntoX3, pPuntoY3);

            Triangulo triangulo = new Triangulo(punto1, punto2, punto3);

            return triangulo.Perimetro;
        }
    }
}