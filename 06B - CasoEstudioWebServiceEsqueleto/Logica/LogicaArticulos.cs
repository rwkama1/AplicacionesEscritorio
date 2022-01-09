using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    internal class LogicaArticulos:ILogicaArticulo
    {
        //singleton
        private static LogicaArticulos _miInstancia;
        private LogicaArticulos() { }
        public static LogicaArticulos GetInstancia()
        {
            if (_miInstancia == null)
                _miInstancia = new LogicaArticulos();
            return (_miInstancia);
        }


        //operaciones
        public void AgregarArticulo(Articulo A)
        {
            IPersistenciaArticulo FArticulo = FabricaPersistencia.getPersistenciaArticulo();
            FArticulo.AgregarArticulo(A);
        }
        public void EliminarArticulo(Articulo A)
        {
            IPersistenciaArticulo FArticulo = FabricaPersistencia.getPersistenciaArticulo();
            FArticulo.EliminarArticulo(A);
        }
        public void ModificarArticulo(Articulo A)
        {
            IPersistenciaArticulo FArticulo = FabricaPersistencia.getPersistenciaArticulo();
            FArticulo.ModificarArticulo(A);
        }
        public Articulo BuscarArticulo(int pCodigo)
        {
            IPersistenciaArticulo FArticulo = FabricaPersistencia.getPersistenciaArticulo();
            return (FArticulo.BuscarArticulo(pCodigo));
        }
        public List<Articulo> ListarArticulo()
        {
            IPersistenciaArticulo FArticulo = FabricaPersistencia.getPersistenciaArticulo();
            return (FArticulo.ListarArticulo());
        }
    }
}
