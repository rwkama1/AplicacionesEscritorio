using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    internal class LogicaLibro : ILogicaLibro
    {
        //singleton
        private static LogicaLibro _miInstancia;
        private LogicaLibro() { }
        public static LogicaLibro GetInstancia()
        {
            if (_miInstancia == null)
                _miInstancia = new LogicaLibro();
            return _miInstancia;
        }
  
        //operaciones
        public void AltaLibro(Libro unLibro)
        {
            FabricaPersistencia.getPersistenciaLibro().AltaLibro(unLibro);
        }

        public void BajaLibro(Libro unLibro)
        {
            FabricaPersistencia.getPersistenciaLibro().BajaLibro(unLibro);
        }

        public void ModificaLibro(Libro unLibro)
        {
            FabricaPersistencia.getPersistenciaLibro().ModificaLibro(unLibro);
        }

        public Libro BuscarLibro(int pIsbn)
        {
            return (FabricaPersistencia.getPersistenciaLibro().BuscarLibro(pIsbn));
        }

        public List<Libro> ListarLibro()
        {
            return (FabricaPersistencia.getPersistenciaLibro().ListarLibro());
        }

        public List<Libro> ListarLibroPorTipo(TipoLibro unTipo)
        {
            return (FabricaPersistencia.getPersistenciaLibro().ListarLibroPorTipo(unTipo));
        }

    }
}
