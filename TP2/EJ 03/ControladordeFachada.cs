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


        public char[] InicializarPartida(string pJugador)
        {
            juego.InicializarPartida(pJugador);
            return juego.PartidaActual.ArregloJuego;
        }

        public ResultadoIntento Intento(char pLetra)
        {
            ResultadoIntento resultado = new ResultadoIntento();
            resultado.Intento = juego.PartidaActual.BuscarCoincidencia(pLetra);
            resultado.Finalizado = juego.PartidaActual.Controlar();
            resultado.ArregloJuego = juego.PartidaActual.ArregloJuego;
            return resultado;
        }

        public Partida[] ListarMejores()
        {
            juego.OrdenarPartidas();
            Partida[] result = new Partida[5];
            result = juego.MejoresCinco(juego.PartidasTerminadas);
            return result;

        }

        public void ConfigurarFallos (int pFallos)
        {
            juego.PartidaActual.CantidadFallos = pFallos;
        }

        public bool Finalizar ()
        {
            if (juego.PartidaActual.ControlFallos())
            {
                return false;
            }
            else
                return true;
        }

        public void AlmacenarPartida()
        {
            juego.GuardarPartida();
        }

    }
}
