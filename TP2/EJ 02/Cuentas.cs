using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_02
{
    class Cuentas
    {
        private Cliente iCliente;
        private Cuenta iCuentaCorriente;
        private Cuenta iCajaAhorro;

        public Cuenta CuentaCorriente
        {
            get { return this.iCuentaCorriente; }
            set { this.iCuentaCorriente = value; }
        }

        public Cuenta CajaAhorro
        {
            get { return this.iCajaAhorro; }
            set { this.iCajaAhorro = value; }
        }

        public Cuentas(Cliente pCliente)
        {
            this.iCliente = pCliente;
            this.iCuentaCorriente.Saldo = 0;
            this.iCajaAhorro.Saldo = 0;

        }
    }
}
