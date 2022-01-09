using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    [Serializable]
    public class CuentaCorriente : Cuenta
    {
        //atributos
        private double _minimoCta;


        //propiedades
        public double MinimoCta
        {
            get { return _minimoCta; }
            set { _minimoCta = value; }
        }

       public override string TipoCuenta
       {
           get { return "Cuenta Corriente";  }
           set { }
       }

        //constructores
        public CuentaCorriente(int pNumCta, Cliente pUnCliente, double pSaldoCuenta, double pMinimoCta)
            : base(pNumCta, pUnCliente, pSaldoCuenta)
        {
            _minimoCta = pMinimoCta;
        }

        //constructor por defecto
        public CuentaCorriente()
        {
            _minimoCta = 0;
        }

    }
}
