using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace EntidadesCompartidas
{
    [KnownType(typeof(CuentaCorriente))]
    [KnownType(typeof(CuentaCAhorro))]
      [DataContract]
   public class Cuenta
    {

       // atributos
       private int _NumCta;
       private Cliente _unCliente;
       private double _SaldoCta;


       //propiedades
        [DataMember]
       public int NumCta
       {
           get { return _NumCta; }
           set { _NumCta = value; }
       }
       [DataMember]
       public Cliente UnCliente
       {
           get { return _unCliente; }
           set { _unCliente = value; }
       }
     [DataMember]
       public double SaldoCuenta
       {
           get { return _SaldoCta; }
           set { _SaldoCta = value; }
       }
         [DataMember]
       public string MiCliente
       {
           get { return _unCliente.NomCli; }
           set { }
       }
         [DataMember]
       public virtual string TipoCuenta
       {
           get { return "No hay Tipo"; }
           set { }
       }

        //constructores
       public Cuenta(int pNumCta, Cliente pUnCliente, double pSaldoCuenta)
       {
           NumCta = pNumCta;
           UnCliente = pUnCliente;
           _SaldoCta = pSaldoCuenta;
       }

       //constructor por defecto
       public Cuenta()
       {
           NumCta = 0;
           UnCliente = null;
           _SaldoCta = 0;
       }

       //operaciones
       public override string ToString()
       {
           return (this.NumCta.ToString().Trim() + " - " + this.UnCliente.NomCli + " - ");
       }
 
    }
}
