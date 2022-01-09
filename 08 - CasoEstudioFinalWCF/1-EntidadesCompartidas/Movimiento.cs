using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace EntidadesCompartidas
{
       [DataContract]
    public class Movimiento
    {
        //atributos
        private int _idMov;
        private DateTime _fechaMov;
        private double _MontoMov;
        private string _tipoMov;
        private Cuenta _unaCuenta;


        //propiedades
            [DataMember]
        public int IdMov
        {
            get { return _idMov; }
            set { _idMov = value; }
        }
            [DataMember]
        public DateTime FechaMov
        {
            get { return _fechaMov; }
            set { _fechaMov = value; }
        }
         [DataMember]
        public double MontoMov
        {
            get { return _MontoMov; }
            set
            {
                if (value > 0)
                    _MontoMov = value;
                else
                    throw new Exception("No se pueden realizar movimientos de numeros negativos");
            }
        }
         [DataMember]
        public string TipoMov
        {
            get { return _tipoMov; }
            set
            {
                if ((value != "R") && (value != "D"))
                    throw new Exception("EL tipo de Movimiento no es correcto");
                else
                    _tipoMov = value;
            }
        }
         [DataMember]
        public Cuenta UnaCuenta
        {
            get { return _unaCuenta; }
            set { _unaCuenta = value; }
        }


        //constructor
        public Movimiento(int pIdMov, DateTime pFechaMov, double pMontoMov, string pTipoMov, Cuenta pUnaCuenta)
        {
            IdMov = pIdMov;
            FechaMov = pFechaMov;
            MontoMov = pMontoMov;
            TipoMov = pTipoMov;
            UnaCuenta = pUnaCuenta;
        }

        //constructor por defecto
        public Movimiento()
        {
            IdMov = 0;
            FechaMov = DateTime.Now;
            MontoMov = 1;
            TipoMov = "R";
            UnaCuenta = null;

        }

    }
}
