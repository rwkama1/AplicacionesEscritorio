using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    internal class LogicaAutor:ILogicaAutor
    {
        //singleton
        private static LogicaAutor _miInstancia;
        private LogicaAutor() { }
        public static LogicaAutor GetInstancia()
        {
            if (_miInstancia == null)
                _miInstancia = new LogicaAutor();
            return _miInstancia;
        }
  
        //operaciones
        public Autor BuscarAutor(int pCodigo)
        {
            return (FabricaPersistencia.getPersistenciaAutor().BuscarAutor(pCodigo));
        }
        public List<Autor> ListarAutor()
        {
            return (FabricaPersistencia.getPersistenciaAutor().ListarAutor());
        }
        public void Alta(Autor autor)
        {
            FabricaPersistencia.getPersistenciaAutor().Alta(autor);
        }
        public void Eliminar(Autor autor)
        {
            FabricaPersistencia.getPersistenciaAutor().Eliminar(autor);
        }
        public void Modificar(Autor autor)
        {
            FabricaPersistencia.getPersistenciaAutor().Modificar(autor);
        }
    }
}
