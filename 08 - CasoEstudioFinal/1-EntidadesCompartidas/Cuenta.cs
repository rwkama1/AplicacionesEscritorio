using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{

   [Serializable]
   public class Cuenta
    {

       // atributos
       private int _NumCta;
       private Cliente _unCliente;
       private double _SaldoCta;


       //propiedades
       public int NumCta
       {
           get { return _NumCta; }
           set { _NumCta = value; }
       }

       public Cliente UnCliente
       {
           get { return _unCliente; }
           set { _unCliente = value; }
       }

       public double SaldoCuenta
       {
           get { return _SaldoCta; }
           set { _SaldoCta = value; }
       }

       public string MiCliente
       {
           get { return _unCliente.NomCli; }
           set { }
       }

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
