using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_03
{
    class Juego
    {
        private string[] iPalabrasPosibles = { "hola", "alumno", "facultad", "palabra", "computadora", "pared", "estudiante", "trofeo", "pizarra", "ventana", "murcielago", "odisea", "chau", "mate", "celular", "hueso", "cerveza", "cerebro", "encefalograma", "otorrinolaringologia", "manzana", "almohadon", "led", "implacable", "ojo", "analogo", "hipotesis", "animal", "lentes", "caracter" };
        private string iPalabra;
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

        public Partida InicializarPartida(string pJugador)              //inicializa una nueva partida y la mantiene como partida
        {                                                               //actual
            Random random = new Random();
            int numRandom = random.Next(0, 30);
            string palabra = this.iPalabrasPosibles[numRandom];
            this.iPartidaActual = new Partida(pJugador, palabra);
            this.iPartidaActual.InicializarArregloJuego();

            return iPartidaActual;
        }
            
        public void OrdenarPartidas()                                   //Este metodo ordena las partidas almacenadas segun su
        {                                                               //duracion
            this.PartidasTerminadas = this.PartidasTerminadas.OrderBy(p => (p.FechaFin - p.FechaInicio)).ToList();
        }

        public Partida[] MejoresCinco()                                 //Obtiene las mejores cinco partidas que sonlas 5 primeras
        {                                                               //ya que la lista de partidas almacenadas se ordenan por 
                                                                        //duracion ascendente antes de llamar este metodo
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
            this.PartidaActual.FechaFin = DateTime.Now;
            this.iPartidasTerminadas.Add(this.PartidaActual);    
        }

        public void Precarga()                                          //Se precarga una serie de partidas finalizadas
        {                                                               //para tener idea de algunos tiempos records.
            if (this.PartidasTerminadas.Capacity == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    Partida partida = new Partida(this.iJugadoresPrecargados[i], this.iPalabrasPosibles[i]);
                    this.PartidasTerminadas.Add(partida);
                    this.PartidasTerminadas[i].FechaFin = DateTime.Now.AddSeconds(this.iSegundosPrecargados[i]);
                    this.PartidasTerminadas[i].Victoria = true;
                }
            }
        }
    }
}
