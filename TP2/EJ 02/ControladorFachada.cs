using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_02
{
    class ControladorFachada
    {
                
        Cuentas cuenta;

        public ControladorFachada()
        {
            Cliente cliente = new Cliente(123456,"Kevin",0);
            this.cuenta = new Cuentas(cliente);
        }

        public double ObtenerSaldoCajaDeAhorro ()
        {
            return  cuenta.CajaAhorro.Saldo;
        }

        public double ObtenerSaldoCuentaCorriente()
        {
            return cuenta.CuentaCorriente.Saldo;
        }

        public bool TransferirCajaDeAhorro(Cuenta pCuentaCorriente, Cuenta pCajaAhorro, double pMonto)
        {

            if (pCuentaCorriente.DebitarSaldo(pMonto) == true)
            {
                pCajaAhorro.AcreditarSaldo(pMonto);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransferirCuentaCorriente (Cuenta pCuentaCorriente, Cuenta pCajaAhorro, double pMonto)
        { 

            if (pCajaAhorro.DebitarSaldo(pMonto) == true)
            {
                pCuentaCorriente.AcreditarSaldo(pMonto);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
