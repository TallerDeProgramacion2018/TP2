using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_04
{
    class Complejo
    {
        private readonly double iReal;          // Parámetros de sólo lectura para asegurar inmutabilidad del objeto.
        private readonly double iImaginario;


        public Complejo(double pReal, double pImaginario)
        {
            iReal = pReal;
            iImaginario = pImaginario;
        }


        public double Real => iReal;


        public double Imaginario => iImaginario;


        public bool EsReal()
        {
            if (this.iImaginario == 0)
            {
                return true;
            }
            else
                return false;
        }


        public bool EsImaginario()
        {
            if (iImaginario == 0)
            {
                return false;
            }
            else
                return true;
        }


        public bool EsIgual(Complejo pOtroComplejo)
        {
            if ((iReal == pOtroComplejo.Real)&(Math.Abs(iImaginario) == Math.Abs(pOtroComplejo.Imaginario)))
            {
                return true;
            }
            else
                return false;
        }


        public bool EsIgual(double pReal, double pImaginario)
        {
            if ((iReal == pReal) & (Math.Abs(iImaginario) == Math.Abs(pImaginario)))
            {
                return true;
            }
            else
                return false;
        }


        public double Magnitud()
        {
            double result = Math.Sqrt(Math.Pow(this.iReal, 2) + Math.Pow(this.iImaginario, 2));
            return result;
        }


        public double ArgumentoEnRadiantes
        {
            get { return (Math.PI*0.5*Math.Sign(iImaginario) - Math.Atan2(iReal,iImaginario)); }
        }


        public double ArgumentoEnGrados
        {
            get { return (ArgumentoEnRadiantes * (180 / Math.PI));  }
        }


        public Complejo Conjugado()
        {
            return new Complejo(iReal, -iImaginario);
        }


        public Complejo Sumar(Complejo pOtroComplejo)
        {
            double real = iReal + pOtroComplejo.Real;
            double imaginario = iImaginario + pOtroComplejo.Imaginario;
            return new Complejo(real, imaginario);
        }


        public Complejo Restar(Complejo pOtroComplejo)
        {
            double real = iReal - pOtroComplejo.Real;
            double imaginario = iImaginario - pOtroComplejo.Imaginario;
            return new Complejo(real, imaginario);
        }


        public Complejo MultiplicarPor(Complejo pOtroComplejo)
        {
            double real = iReal * pOtroComplejo.Real - iImaginario * pOtroComplejo.Imaginario;
            double imaginario = iReal * pOtroComplejo.Imaginario + iImaginario * pOtroComplejo.Real;
            return new Complejo(real, imaginario);
        }


        public Complejo DividirPor(Complejo pOtroComplejo)
        {
            double real = (iReal * pOtroComplejo.Real + iImaginario * pOtroComplejo.Imaginario)/
                          (Math.Pow(pOtroComplejo.Real,2) + Math.Pow(pOtroComplejo.Imaginario,2));

            double imaginario = (iImaginario * pOtroComplejo.Real - iReal * pOtroComplejo.Imaginario)/
                                (Math.Pow(pOtroComplejo.Real, 2) + Math.Pow(pOtroComplejo.Imaginario, 2));

            return new Complejo(real, imaginario);
        }
    }
}
