using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_03
{
    class Juego
    {
        private string iPalabra;

        public bool Intento( char pLetra)
        {
            bool exito=false;
            for (int i = 0; ((i < this.iPalabra.Length)&&(exito==false)); i++)
            {
                if (this.iPalabra[i] == pLetra)
                {
                    exito = true;
                    return true;
                }
            }
            return false;
        }

        public void Revelar(char pLetra, char[] pArreglo)
        {
            for (int i = 0; i < this.iPalabra.Length; i++)
			{
                if (this.iPalabra[i] == pLetra)
                {
                    pArreglo[i] = pLetra;
                }
			}
        }



    }
}
