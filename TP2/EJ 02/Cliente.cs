using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_02
{
    class Cliente
    {
        private int iDNI;
        private string iNombre;
        private TipoDNI iTipoDNI;

        public Cliente(int pDNI, string pNombre)
        {
            this.iDNI = pDNI;
            this.iNombre = pNombre;
        }

        public int DNI
        {
            get { return this.iDNI; }
            set { this.iDNI = value; }
        }

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        public TipoDNI tipoDNI
        {
            get { return this.iTipoDNI; }
            set { this.iTipoDNI = value; }
        }
    }
}
