using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_03
{
    class Juego
    {
        private string[] iPalabrasPosibles;
        private string iPalabra;


        /*public bool BuscarCoincidencia(char pLetra, char[] pArregloJuego, Partida pPartida)
        {
            bool exito = false;
            for (int i = 0; ((i < pPartida.Palabra.Length) && (exito == false)); i++)
            {
                if (pPartida.Palabra[i] == pLetra)
                {
                    exito = true;
                    return true;
                }
            }
            return false;
        }*/

        public Partida InicializarPartida(string pJugador, string[] pPalabras)
        {
            Random random = new Random();
            int numRandom = random.Next(0, 29);
            string palabra = pPalabras[numRandom];
            Partida partida = new Partida(pJugador, palabra);
            partida.InicializarArregloJuego();

            return partida;
        }


    }
}
