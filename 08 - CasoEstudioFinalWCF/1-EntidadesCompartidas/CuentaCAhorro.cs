using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace EntidadesCompartidas
{
        [DataContract]
    public class CuentaCAhorro: Cuenta
    {

        //atributos
        private int _movsCta;
        private double _CostoMovsCta;

        //propiedades
             [DataMember]
        public int MovsCta
        {
            get { return _movsCta; }
            set { _movsCta = value; }
        }
         [DataMember]
        public double CostoMovsCta
        {
            get { return _CostoMovsCta;}
            set { _CostoMovsCta = value; }
        }
         [DataMember]
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
