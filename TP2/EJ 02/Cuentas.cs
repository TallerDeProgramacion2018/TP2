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

        public Cuentas()
        {
            this.iCliente = new Cliente(95583134,"Kevin");          //Se considera un cliente por defecto y cuentas con saldo incial
            this.iCuentaCorriente = new Cuenta(500,350);            //para poder hacer operaciones
            this.iCajaAhorro = new Cuenta(300,100);
        }
    }
}
