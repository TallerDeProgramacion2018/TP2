using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_02
{
    class ControladorFachada
    {
                
        Cuentas cuentas = new Cuentas();
        
        public double ObtenerSaldoCajaDeAhorro ()
        {
            return  cuentas.CajaAhorro.Saldo;
        }

        public double ObtenerSaldoCuentaCorriente()
        {
            return cuentas.CuentaCorriente.Saldo;
        }

        // En estos métodos se controla si las operaciónes son posibles, y si lo son, se realiza. Devuelve un boolean según cada caso.
        public bool TransferirCajaDeAhorro(double pMonto)       
        {

            if (cuentas.CuentaCorriente.DebitarSaldo(pMonto) == true)
            {
                cuentas.CajaAhorro.AcreditarSaldo(pMonto);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransferirCuentaCorriente (double pMonto)
        { 

            if (cuentas.CajaAhorro.DebitarSaldo(pMonto) == true)
            {
                cuentas.CuentaCorriente.AcreditarSaldo(pMonto);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
