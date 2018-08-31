using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_03
{
    class ControladordeFachada
    {
        private Partida iPartida;
        private List<Partida> iPartidasTerminadas;
        
        public void InicializarPartida(string pJugador, string[] pPalabras)
        {
            Random random = new Random();
            int numRandom = random.Next(0, 29);
            string palabra = pPalabras[numRandom];
            this.iPartida= new Partida(pJugador, palabra);
        }

        public char [] InicializarArregloJuego(Partida pPartida)
        { 
            char[] arregloJuego = new char[pPartida.Palabra.Length];
            for (int i = 0; i < arregloJuego.Length; i++)
            {
                arregloJuego[i] = '_';
            }

            return arregloJuego;
        }

        public bool Intento(char pLetra, char[] pArregloJuego, Partida pPartida, List<char> pListaIntentos)
        {
            if(BuscarCoincidencia(pLetra, pArregloJuego, pPartida))
            {
                Revelar(pLetra, pArregloJuego, pPartida);
                return true;
            }
            else
            {
                pListaIntentos.Add(pLetra);
                pPartida.Fallo += 1;
                return false;
            }
        }

        public void IncializarJuego(string pJugador, string[] arregloPalabras)
        {
            Partida partida = InicializarPartida(pJugador, arregloPalabras);
            char[] arregloJuego = InicializarArregloJuego(partida);
            List <char> listaIntentos = ListaIntentos(partida);
        }

    }
}
