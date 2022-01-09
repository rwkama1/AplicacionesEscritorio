using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
   public class FabricaLogica
    {
       public static ILogicaCliente GetLogicaCliente()
       {
           return (LogicaCliente.GetInstancia());
       }

       public static ILogicaCuenta GetLogicaCuenta()
       {
           return (LogicaCuenta.GetInstancia());
       }

       public static ILogicaMovimiento GetLogicaMovimiento()
       {
           return (LogicaMovimiento.GetInstancia());
       }

       public static ILogicaEmpleado GetLogicaEmpleado()
       {
           return (LogicaEmpleado.GetInstancia());
       }

       public static ILogicaPrestamo GetLogicaPrestamo()
       {
           return (LogicaPrestamo.GetInstancia());
       }

    }
}
