using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_03
{
    class ControladordeFachada
    {
        Juego juego =new Juego();

        private Partida iPartida;
        private List<Partida> iPartidasTerminadas;
        
        public void InicializarPartida(string pJugador, string[] pPalabras)
        {
            Random random = new Random();
            int numRandom = random.Next(0, 29);
            string palabra = pPalabras[numRandom];
            this.iPartida= new Partida(pJugador, palabra);
        }

        public bool Intento(char pLetra)
        {
            if(juego.BuscarCoincidencia(pLetra))
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
