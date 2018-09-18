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
        //private Partida[] iPartidasTerminadas = new Partida[100];
        List<Partida> iPartidasTerminadas = new List<Partida>();
        private Partida iPartidaActual;

            //Datos para la precarga de jugadores
        private String[] iJugadoresPrecargados = { "Ingacio", "Gaston", "Juan", "Kevin", "Pablo" };
        private int[] iSegundosPrecargados = { 180, 240, 275, 335, 360 };
        

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
            //this.PartidasTerminadas.Sort((p, q) => TimeSpan.Compare((p.FechaFin - p.FechaInicio), (q.FechaFin - q.FechaInicio)));
            this.PartidasTerminadas = this.PartidasTerminadas.OrderBy(p => (p.FechaFin - p.FechaInicio)).ToList();

            /*Partida t;
            for (int a = 1; a < this.iPartidasTerminadas.Capacity; a++)
                for (int b = 0; b < this.iPartidasTerminadas.Capacity - 1; b++)
                {
                    if (this.iPartidasTerminadas[b].Duracion() > this.iPartidasTerminadas[b + 1].Duracion())
                    {
                        t = this.iPartidasTerminadas[b];
                        this.iPartidasTerminadas[b] = this.iPartidasTerminadas[b + 1];
                        this.iPartidasTerminadas[b + 1] = t;
                    }
                }*/
        }

        public Partida[] MejoresCinco()
        {

            Partida[] result = new Partida[5];

            for (int i = 0; i < 5; i++)
            {
                result[i] = this.PartidasTerminadas[i];
            }

            return result;
        }

        public List<Partida> PartidasTerminadas
        {
            get { return this.iPartidasTerminadas; }
            set { this.iPartidasTerminadas = value; }
        }

        public void GuardarPartida()
        {
            //this.iPartidasTerminadas[this.iPartidasTerminadas.Length - 2] = this.PartidaActual;
            this.PartidaActual.FechaFin = DateTime.Now;
            this.iPartidasTerminadas.Add(this.PartidaActual);    
        }

        public void Precarga()
        {
            if (this.PartidasTerminadas.Capacity == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    //this.PartidasTerminadas[i] = new Partida(this.iJugadoresPrecargados[i],"hola");
                    //this.PartidasTerminadas[i].FechaFin = DateTime.Now.AddSeconds(this.iSegundosPrecargados[i]);
                    //this.PartidasTerminadas[i].Victoria = true;

                    Partida partida = new Partida(this.iJugadoresPrecargados[i], "hola");
                    this.PartidasTerminadas.Add(partida);
                    this.PartidasTerminadas[i].FechaFin = DateTime.Now.AddSeconds(this.iSegundosPrecargados[i]);
                    this.PartidasTerminadas[i].Victoria = true;
                }
            }
        }
    }
}
