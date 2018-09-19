using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_03
{
    class ControladordeFachada
    {
        Juego juego = new Juego();

        public void Precargar()
        {
            juego.Precarga();
        }


        public char[] InicializarPartida(string pJugador)
        {
            juego.InicializarPartida(pJugador);
            return juego.PartidaActual.ArregloJuego;

        }

        public ResultadoIntento Intento(char pLetra)                                //Evalua si el intento ingresado por el jugador
        {                                                                           //es valido o no
            ResultadoIntento resultado = new ResultadoIntento();                   
            resultado.Intento = juego.PartidaActual.BuscarCoincidencia(pLetra);
            resultado.Finalizado = juego.PartidaActual.Controlar();
            resultado.ArregloJuego = juego.PartidaActual.ArregloJuego;
            return resultado;
        }

        public Partida[] ListarMejores()                                            //Obtiene un arrgelo con las mejores 5 partidas
        {
            juego.OrdenarPartidas();
            Partida[] result = new Partida[5];
            result = juego.MejoresCinco();
            return result;
        }

        public int ObtenerFallos()
        {
            return juego.PartidaActual.FallosRestantes();
        }

        public void ConfigurarFallos (int pFallos)
        {
            juego.PartidaActual.CantidadFallos = pFallos;
        }

        public bool Finalizar ()                                                    //Evalua si los fallos cometidos por el juegador
        {                                                                           //exedieron la cantidad maxima de fallos
            if (juego.PartidaActual.ControlFallos())
            {
                return false;
            }
            else
                return true;
        }

        public void AlmacenarPartida()                                              //Almacena una partida en la lista de partidas
        {                                                                           //Finalizadas de la clase juego
            juego.GuardarPartida();
        }

    }
}
