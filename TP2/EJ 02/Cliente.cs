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
        private string iTipoDocumento;

        public Cliente(int pDNI, string pNombre)
        {
            this.iDNI = pDNI;
            this.iNombre = pNombre;
            this.iTipoDocumento = "DNI";
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

        public string TipoDocumento
        {
            get { return this.iTipoDocumento; }
            set { this.iTipoDocumento = value; }
        }

    }
}
