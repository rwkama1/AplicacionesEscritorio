using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
   public interface IPeristenciaEmpleado
    {
       EntidadesCompartidas.Empleado Logueo(int pCI, string pPass);
    }
}
