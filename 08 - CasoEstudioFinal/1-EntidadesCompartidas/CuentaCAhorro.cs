using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    [Serializable]
    public class CuentaCAhorro: Cuenta
    {

        //atributos
        private int _movsCta;
        private double _CostoMovsCta;

        //propiedades
        public int MovsCta
        {
            get { return _movsCta; }
            set { _movsCta = value; }
        }

        public double CostoMovsCta
        {
            get { return _CostoMovsCta;}
            set { _CostoMovsCta = value; }
        }

       public override string TipoCuenta
       {
           get { return "Caja de Ahorro"; }
           set { }
       }

        //constructores
        public CuentaCAhorro(int pNumCta, Cliente pUnCliente, double pSaldoCuenta, int pMovsCta, double pcostoMovsCta)
            : base(pNumCta, pUnCliente, pSaldoCuenta)
        {
            _movsCta = pMovsCta;
            _CostoMovsCta = pcostoMovsCta;
        }

        //constructor por defecto
        public CuentaCAhorro()
        {
        }

    }
}
