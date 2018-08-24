using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_02
{
    class Cuenta
    {
        private double iSaldo;
        private double iAcuerdo;

        public Cuenta(double pAcuerdo)
        {
            this.iSaldo = 0;
            this.iAcuerdo = pAcuerdo;
        }

        public Cuenta(double pAcuerdo, double pSaldo)
        {
            this.iSaldo = pSaldo;
            this.iAcuerdo = pAcuerdo;
        }

        public double Saldo
        {
            get { return this.iSaldo; }
            set { this.iSaldo = value; }
        }

        public double Acuerdo
        {
            get { return this.iAcuerdo; }
            set { this.iAcuerdo = value; }
        }

        public double AcreditarSaldo(double pSaldo)
        {
            return iSaldo + pSaldo;
        }

        public bool DebitarSaldo(double pSaldo)
        {
            if (this.iSaldo >= pSaldo)
            {
                this.iSaldo -= pSaldo;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
