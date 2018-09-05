using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_03
{
    class ResultadoIntento
    {
        private bool iFinalizado;
        private bool iIntento;


        public ResultadoIntento()
        {

        }
        public bool Finalizado
        {
            get { return this.iFinalizado; }
            set { this.iFinalizado = value; }
        }

        public bool Intento
        {
            get { return this.iIntento; }
            set { this.iIntento = value; }
        }
    }

    
}
