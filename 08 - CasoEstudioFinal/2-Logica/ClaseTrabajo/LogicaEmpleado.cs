using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    internal class LogicaEmpleado: ILogicaEmpleado
    {
         //Singleton
        private static LogicaEmpleado _instancia = null;
        private LogicaEmpleado() { }
        public static LogicaEmpleado GetInstancia()
        {
            if (_instancia == null)
                _instancia = new LogicaEmpleado();
            return _instancia;
        }

        //operaciones
        public EntidadesCompartidas.Empleado Logueo(int pCI, string pPass)
        {
            return Persistencia.FabricaPersistencia.GetPersitenciaEmpleado().Logueo(pCI, pPass);
        }
    }
}
