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
            get { return this.iVictoria; }
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

        public void Revelar(char pLetra)
        {
            for (int i = 0; i < this.iPalabra.Length; i++)
            {
                if (this.iPalabra[i] == pLetra)
                {
                    this.iArregloJuego[i] = pLetra;
                }
            }
        }

        public bool BuscarCoincidencia(char pLetra)
        {
            bool exito = false;
            for (int i = 0; ((i < iPalabra.Length) && (exito == false)); i++)
            {
                if (iPalabra[i] == pLetra)
                {
                    exito = true;
                    this.Revelar(pLetra);
                    return true;
                }
                else
                {
                    this.ListaIntentos.Add(pLetra);
                    this.Fallo += 1;
                    return false;
                }
            }
            return false;
        }

        /*public void Finalizar ()
        {
            if (ControlFallos())
            {
                this.iFechaHoraFin = DateTime.Now;
            }
            else
            {
                if (this.ControlPalabra ())
                {
                    this.iVictoria = this.Victoria;
                    this.iFechaHoraFin = DateTime.Now;

                }
            }
        }*/

        public void Finalizar(bool pResultado)
        {
            this.iFechaHoraFin = this.FechaFin;

            if (pResultado)
                this.iVictoria = this.Victoria;

        }

        public bool ControlPalabra()
        {
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

        public bool Controlar()
        {
            if (this.ControlFallos())
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
    }
}
