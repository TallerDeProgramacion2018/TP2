using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_03
{
    class Partida
    {
        private DateTime iFechaHora;
        private DateTime iFechaHoraFin;
        private bool iVictoria;
        private string iJugador;
        private int iCantidadFallosMaxima = 10;
        private int iFallos = 0;
        private string iPalabra;
        private List<char> iListaIntentos = new List<char>();
        private char[] iArregloJuego;

        public Partida(string pJugador, string pPalabra)            
        {
            this.iFechaHora = DateTime.Now;
            this.iJugador = pJugador;
            this.iPalabra = pPalabra;
        }

        public string NombreJugador
        {
            get {return this.iJugador; }
            set { this.iJugador = value; }
        }

        public int CantidadFallos
        {
            get { return this.iCantidadFallosMaxima; }
            set { this.iCantidadFallosMaxima = value; }
        }

        public TimeSpan Duracion()                                  //Este metodo calcula la duracion de la partida haciendo
        {                                                           //La resta entre la fecha de inicio y la fecha de fianlizacion
            return this.iFechaHoraFin - this.iFechaHora;
        }

        public int Fallos
        {
            get { return this.iFallos; }
            set { this.iFallos = value; }
        }

        public bool Victoria
        {
            get { return this.iVictoria; }
            set { this.iVictoria = true; }
        }

        public DateTime FechaFin
        {
            get { return this.iFechaHoraFin; }
            set { this.iFechaHoraFin = value; }
        }

        public DateTime FechaInicio
        {
            get { return this.iFechaHora; }
            set { this.iFechaHora = DateTime.Now; }
        }

        public string Palabra
        {
            get { return this.iPalabra; }
            set { this.iPalabra = value; }
        }

        public void InicializarArregloJuego()                       //Inicializa un arreglo con guiones bajos en todas sus posiciones
        {                                                           //Este arreglo tiene el mismo tamaño que la palabra a adivinar                 
            char[] arregloJuego = new char[this.iPalabra.Length];
            for (int i = 0; i < arregloJuego.Length; i++)
            {
                arregloJuego[i] = '_';
            }

            this.iArregloJuego = arregloJuego;
        }

        public char[] ArregloJuego                                  
        {
            get { return this.iArregloJuego; }
            set { this.iArregloJuego = value; }
        }

        public List<char> ListaIntentos
        {
            get { return this.iListaIntentos; }
            set { this.iListaIntentos = value; }
        }

        public void Revelar(char pLetra)                            //Este metodo ubica la letra adivinada en la posicion
        {                                                           //correspondiente del arreglo del juego (el de guiones)
            for (int i = 0; i < this.iPalabra.Length; i++)
            {
                if (this.iPalabra[i] == pLetra)
                {
                    this.iArregloJuego[i] = pLetra;
                }
            }
        }

        public bool BuscarCoincidencia(char pLetra)                 //Este metodo confirma si la letra ingresada por el jugador
        {                                                           //esta en la paabra a adivinar
            bool exito = false;                                     //Si esta devuelve true y sino devuelve false
            for (int i = 0; ((i < iPalabra.Length) && (exito == false)); i++)
            {
                if (iPalabra[i] == pLetra)
                {
                    exito = true;
                }
            }

            if (exito)
            {
                this.Revelar(pLetra);
                return true;
            }
            else
            {
                this.iListaIntentos.Add(pLetra);
                this.Fallos += 1;
                return false;
            }
        }

        public void Finalizar(bool pResultado)                      
        {
            this.iFechaHoraFin = this.FechaFin;

            if (pResultado)
                this.iVictoria = this.Victoria;
        }

        public bool ControlPalabra()                                //Este metodo devuelve true si la palabra a adivinar es igual
        {                                                           //al arreglo juego
            bool iguales = true;

            for (int i = 0; i < (this.Palabra.Length) && (iguales); i++)
            {
                if (this.iPalabra[i] != this.iArregloJuego[i])
                {
                    iguales = false;
                }
            }

            if (iguales)
                return true;
            else
                return false;

        }

        public bool ControlFallos()                                 
        {
            if (this.iFallos > this.iCantidadFallosMaxima)
                return true;
            else
                return false;
        }

        public bool Controlar()                                     //El metodo controlar evalua si el juego debe finalizarse
        {                                                           //ya sea porque el jugador exedio los fallos permitidos
            if (this.ControlFallos())                               //o porque adivino la palabra
            {
                this.Finalizar(false);
                return true;
            }
                
            else
            {
                if (this.ControlPalabra())
                {
                    this.Finalizar(true);
                    return true;
                }
                    
            }

            return false;
        }

        public int FallosRestantes()
        {
            return this.CantidadFallos - this.Fallos;
        }
    }
}
