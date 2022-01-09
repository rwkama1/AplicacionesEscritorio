using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
   public interface IPersistenciaMovimiento
    {
        void Alta(EntidadesCompartidas.Movimiento pMovimiento);
        List<EntidadesCompartidas.Movimiento> ListarTodosLosMovimientos();
    }
}
