using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
   public class FabricaPersistencia
    {
       public static IPersistenciaCliente GetPersistenciaCliente()
       {
           return (PersistenciaCliente.GetInstancia());
       }

       public static IPersistenciaCuentaCAhorro GetPersitenciaCuentaCAhorro()
       {
           return (PersistenciaCuentaCAhorro.GetInstancia());
       }

       public static IPersistenciaCuentaCorriente GetPersistenciaCuentaCorriente()
       {
           return (PersistenciaCuentaCorriente.GetInstancia());
       }

       public static IPersistenciaMovimiento GetPersitenciaMovimiento()
       {
           return (PersistenciaMovimiento.GetInstancia());
       }

       public static IPeristenciaEmpleado GetPersitenciaEmpleado()
       {
           return (PersitenciaEmpleado.GetInstancia());
       }

       public static IPersistenciaPrestamo GetPersistenciaPrestamo()
       {
           return (PersistenciaPrestamo.GetInstancia());
       }

    }
}
