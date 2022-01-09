using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
   public class FabricaLogica
    {
       public static ILogicaAutor getLogicaAutor()
       {
           return(LogicaAutor.GetInstancia());
       }

       public static ILogicaUsuario getLogicaUsuario()
       {
           return (LogicaUsuario.GetInstancia());
       }

       public static ILogicaTipo getLogicaTipo()
       {
           return (LogicaTipo.GetInstancia());
       }

       public static ILogicaLibro getLogicaLibro()
       {
           return (LogicaLibro.GetInstancia());
       }
    }
}
