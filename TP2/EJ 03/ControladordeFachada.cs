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

        private Partida iPartida;
        private List<Partida> iPartidasTerminadas;

        public ResultadoIntento Intento(char pLetra)
        {
            ResultadoIntento resultado = new ResultadoIntento;
            resultado.Intento = iPartida.BuscarCoincidencia(pLetra);
            resultado.Finalizado=iPartida.Controlar();
            return resultado;
        }
    }
}
