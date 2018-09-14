using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_03
{
    class Juego
    {
        private string[] iPalabrasPosibles = { "hola", "alumno", "facultad", "hola", "alumno", "facultad", "hola", "alumno", "facultad", "hola", "alumno", "facultad", "hola", "alumno", "facultad", "hola", "alumno", "facultad", "hola", "alumno", "facultad", "hola", "alumno", "facultad", "hola", "alumno", "facultad", "hola", "alumno", "facultad" };
        private string iPalabra;
        private Partida[] iPartidasTerminadas = new Partida[100];
        private Partida iPartidaActual;


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

        public Partida PartidaActual
        {
            get { return this.iPartidaActual; }
            set { this.iPartidaActual = value; }
        }

        public Partida InicializarPartida(string pJugador)
        {
            Random random = new Random();
            int numRandom = random.Next(0, 30);
            string palabra = this.iPalabrasPosibles[numRandom];
            this.iPartidaActual = new Partida(pJugador, palabra);
            this.iPartidaActual.InicializarArregloJuego();

            return iPartidaActual;
        }

        public void OrdenarPartidas()
        {
            Partida t;
            for (int a = 1; a < this.iPartidasTerminadas.Length; a++)
                for (int b = this.iPartidasTerminadas.Length - 1; b >= a; b--)
                {
                    if (this.iPartidasTerminadas[b - 1].Duracion() > this.iPartidasTerminadas[b].Duracion())
                    {
                        t = this.iPartidasTerminadas[b - 1];
                        this.iPartidasTerminadas[b - 1] = this.iPartidasTerminadas[b];
                        this.iPartidasTerminadas[b] = t;
                    }
                }
        }

        public Partida[] MejoresCinco(Partida[] pArreglo)
        {

            Partida[] result = new Partida[5];

            for (int i = 0; i < 5; i++)
            {
                result[i] = pArreglo[i];
            }

            return result;
        }

        public Partida[] PartidasTerminadas
        {
            get { return this.iPartidasTerminadas; }
            set { this.iPartidasTerminadas = value; }
        }

        public void GuardarPartida()
        {
            this.iPartidasTerminadas[this.iPartidasTerminadas.Length - 3] = this.PartidaActual;
        }

        public void Precarga()
        {
            for (int i = 0; i < 5; i++)
            {
                this.PartidasTerminadas[i] = new Partida("Kevin","hola");
                this.PartidasTerminadas[i].FechaInicio = new DateTime (2018, 2, 22, 5, 25, 0);
                this.PartidasTerminadas[i].FechaFin = new DateTime(2018, 2, 22, 5, 50, 0);
                this.PartidasTerminadas[i].Victoria = true;
            }
        }
    }
}
