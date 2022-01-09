using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
namespace EntidadesCompartidas
{
     [DataContract]
   public class Prestamo
    {
       //atributos
       private int _IdPres;
       private Cliente _unCliente;
       private DateTime _FechaPres;
       private double _MontoPres;
       private Boolean _AprobadoPres;


       //propiedades
          [DataMember]
       public int Id
       {
           get { return _IdPres; }
           set { _IdPres = value; }
       }
          [DataMember]
       public Cliente UnCliente
       {
           get { return _unCliente; }
           set { _unCliente = value; }
       }
          [DataMember]
       public DateTime Fecha
       {
           get { return _FechaPres; }
           set { _FechaPres = value; }
       }
          [DataMember]
       public double Monto
       {
           get { return _MontoPres; }
           set
           {
               if (value > 0)
                   _MontoPres = value;
               else
                   throw new Exception("No se pueden realizar prestamos de montos negativos");
           }
       }
         [DataMember]
       public Boolean Aprobado
       {
           get { return _AprobadoPres; }
           set { _AprobadoPres = value; }
       }

       //constructor
       public Prestamo(int pIdPres, Cliente pUnCliente, DateTime pFechaPres, double pMontoPres, Boolean pAprobadoPres)
       {
           Id = pIdPres;
           UnCliente = pUnCliente;
           Fecha = pFechaPres;
           Monto = pMontoPres;
           Aprobado = pAprobadoPres;
       }

       //constructor por defecto
       public Prestamo()
       {
           Id = 0;
           UnCliente = null;
           Fecha = DateTime.Now;
           Monto = 1;
           Aprobado = false;
       }
    }
}
