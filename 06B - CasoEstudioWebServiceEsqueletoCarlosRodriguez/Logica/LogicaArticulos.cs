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
            if (A is Produccion)
                FabricaPersistencia.getPersistenciaArticulo().AgregarArticulo((Produccion)A);
        }
        public void EliminarArticulo(Articulo A)
        {
            if (A is Produccion)
                FabricaPersistencia.getPersistenciaArticulo().EliminarArticulo((Produccion)A);
        }
        public void ModificarArticulo(Articulo A)
        {
            if (A is Produccion)
                FabricaPersistencia.getPersistenciaArticulo().ModificarArticulo((Produccion)A);
        }
        public Articulo BuscarArticulo(int pCodigo)
        {
            Articulo art = null;
            art = FabricaPersistencia.getPersistenciaArticulo().BuscarArticulo(pCodigo);
            return art;
        }
        public List<Articulo> ListarArticulo()
        {
            IPersistenciaArticulo FArticulo = FabricaPersistencia.getPersistenciaArticulo();
            return (FArticulo.ListarArticulo());
        }
    }
}
