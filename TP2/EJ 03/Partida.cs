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
        private List<char> iListaIntentos;
        private char[] iArregloJuego;

        public Partida(string pJugador, string pPalabra)
        {
            this.iFechaHora = DateTime.Now;
            this.iJugador = pJugador;
            this.iPalabra = pPalabra;
        }

        public int CantidadFallos
        {
            get { return this.iCantidadFallosMaxima; }
            set { this.iCantidadFallosMaxima = value; }
        }

        public TimeSpan Duracion()
        {
            return iFechaHoraFin.Subtract(iFechaHora);
        }

        public int Fallo
        {
            get { return this.iFallos; }
            set { this.iFallos = value; }
        }

        public bool Victoria
        {
            get { return this.iVictoria ; }
            set { this.iVictoria = true; }
        }

        public DateTime FechaFin
        {
            get { return this.iFechaHoraFin; }
            set { this.iFechaHoraFin = DateTime.Now; }
        }

        public string Palabra
        {
            get { return this.iPalabra; }
            set { this.iPalabra = value; }
        }

        public void InicializarArregloJuego()
        {
            char[] arregloJuego = new char[this.iPalabra.Length];
            for (int i = 0; i < arregloJuego.Length; i++)
            {
                arregloJuego[i] = '_';
            }

            this.iArregloJuego= arregloJuego;
        }

    }
}
