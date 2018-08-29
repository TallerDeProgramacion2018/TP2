using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_03
{
    class ControladordeFachada
    {
        public char[] InicializarPartida(string pJugador, string[] pPalabras)
        {
            Random random = new Random();
            int numRandom = random.Next(0, 29);
            string palabra = pPalabras[numRandom];
            Partida partida = new Partida(pJugador, palabra);

            char[] arregloJuego = new char[palabra.Length];
            return arregloJuego;
        }

    }
}
