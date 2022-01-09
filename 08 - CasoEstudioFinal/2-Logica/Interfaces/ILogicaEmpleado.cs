using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public interface ILogicaEmpleado
    {
        EntidadesCompartidas.Empleado Logueo(int pCI, string pPass);
    }
}
