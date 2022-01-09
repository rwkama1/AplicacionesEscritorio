using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
   internal class LogicaPrestamo: ILogicaPrestamo
    {

       //Singleton
        private static LogicaPrestamo _instancia = null;
        private LogicaPrestamo() { }
        public static LogicaPrestamo GetInstancia()
        {
            if (_instancia == null)
                _instancia = new LogicaPrestamo();
            return _instancia;
        }

        //operaciones

        public List<EntidadesCompartidas.Prestamo> ListoPrestamosCliente(EntidadesCompartidas.Cliente unCliente)
        {
            return(Persistencia.FabricaPersistencia.GetPersistenciaPrestamo().ListoPrestamosCliente(unCliente));
        }

        public void Alta(EntidadesCompartidas.Prestamo pPrestamo)
        {
            Persistencia.FabricaPersistencia.GetPersistenciaPrestamo().Alta(pPrestamo);
        }

        public List<EntidadesCompartidas.Prestamo> ListoPrestamos()
        {
            return (Persistencia.FabricaPersistencia.GetPersistenciaPrestamo().ListoPrestamos());
        }

    }
}
