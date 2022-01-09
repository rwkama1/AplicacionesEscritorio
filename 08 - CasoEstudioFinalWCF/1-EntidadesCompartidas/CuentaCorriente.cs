using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace EntidadesCompartidas
{
        [DataContract]
    public class CuentaCorriente : Cuenta
    {
        //atributos
        private double _minimoCta;


        //propiedades
             [DataMember]
        public double MinimoCta
        {
            get { return _minimoCta; }
            set { _minimoCta = value; }
        }
         [DataMember]
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
