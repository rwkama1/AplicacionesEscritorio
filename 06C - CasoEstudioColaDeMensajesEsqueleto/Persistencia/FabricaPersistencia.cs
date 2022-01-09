using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;

namespace Persistencia
{
    public class FabricaPersistencia
    {
        public static IPersistenciaArticulo getPersistenciaArticulo()
        {
            return (PersistenciaArticulos.GetInstancia());
        }

        public static IPersistenciaPedidos getPersistenciaPedido()
        {
            return (PersistenciaPedidos.GetInstancia());
        }

    }
}
