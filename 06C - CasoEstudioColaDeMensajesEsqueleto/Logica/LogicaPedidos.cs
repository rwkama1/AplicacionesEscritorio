using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
   internal class LogicaPedidos: ILogicaPedidos
    {
        //singleton
        private static LogicaPedidos _miInstancia;
        private LogicaPedidos() { }
        public static LogicaPedidos GetInstancia()
        {
            if (_miInstancia == null)
                _miInstancia = new LogicaPedidos();
            return (_miInstancia);
        }


        //operaciones
       public void AltaPedido(Pedido pPedido)
       {
           FabricaPersistencia.getPersistenciaPedido().AltaPedido(pPedido);
       }

       public List<Pedido> ListarPedidos()
       {
           return(FabricaPersistencia.getPersistenciaPedido().ListarPedidos());
       }

    }
}
