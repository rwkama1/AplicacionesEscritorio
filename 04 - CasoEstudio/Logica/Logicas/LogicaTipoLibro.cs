using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    internal class LogicaTipo : ILogicaTipo
    {
        //singleton
        private static LogicaTipo _miInstancia;
        private LogicaTipo() { }
        public static LogicaTipo GetInstancia()
        {
            if (_miInstancia == null)
                _miInstancia = new LogicaTipo();
            return _miInstancia;
        }
  
        //operaciones
        public TipoLibro BuscarTipo(int pCodigo)
        {
            return (FabricaPersistencia.getPersistenciaTipoLibro().BuscarTipo(pCodigo));
        }
        public List<TipoLibro> ListarTipo()
        {
            return (FabricaPersistencia.getPersistenciaTipoLibro().ListarTipo());
        }
    }
}
