using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    internal class LogicaUsuario:ILogicaUsuario
    {
        //singleton
        private static LogicaUsuario _miInstancia;
        private LogicaUsuario() { }
        public static LogicaUsuario GetInstancia()
        {
            if (_miInstancia == null)
                _miInstancia = new LogicaUsuario();
            return _miInstancia;
        }
  
        //operaciones 
        public Usuario BuscarUsuario(String pNombre)
        {
            return (FabricaPersistencia.getPersistenicaUsuario().BuscarUsuario(pNombre));
        }

    }
}
