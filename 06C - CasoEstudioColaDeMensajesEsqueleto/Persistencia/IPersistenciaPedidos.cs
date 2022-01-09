using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;

namespace Persistencia
{
  public interface IPersistenciaPedidos
    {
      void AltaPedido(Pedido pPedido);
      List<Pedido> ListarPedidos();
    }
}
