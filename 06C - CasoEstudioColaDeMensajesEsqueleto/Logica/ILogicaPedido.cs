using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;

namespace Logica
{
    public interface ILogicaPedidos
    {
        void AltaPedido(Pedido pPedido);
        List<Pedido> ListarPedidos();
    }
}
