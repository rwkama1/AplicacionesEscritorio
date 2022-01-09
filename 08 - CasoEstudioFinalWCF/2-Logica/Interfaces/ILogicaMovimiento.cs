using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
   public interface ILogicaMovimiento
    {
       void MovimientoAlta(EntidadesCompartidas.Movimiento pMovimiento);
       List<EntidadesCompartidas.Movimiento> ListarTodosLosMovimientos();

    }
}
