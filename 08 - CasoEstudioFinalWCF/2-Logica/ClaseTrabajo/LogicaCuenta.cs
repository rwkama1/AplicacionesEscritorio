using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    internal class LogicaCuenta:ILogicaCuenta
    {
        //Singleton
        private static LogicaCuenta _instancia = null;
        private LogicaCuenta() { }
        public static LogicaCuenta GetInstancia()
        {
            if (_instancia == null)
                _instancia = new LogicaCuenta();
            return _instancia;
        }

        //operaciones
        public void Alta(Cuenta unaCuenta)
        {
            if (unaCuenta is CuentaCorriente)
                FabricaPersistencia.GetPersistenciaCuentaCorriente().Alta((CuentaCorriente)unaCuenta);
            else
               FabricaPersistencia.GetPersitenciaCuentaCAhorro().Alta((CuentaCAhorro)unaCuenta);
        }

        public void Baja(Cuenta unaCuenta)
        {
            if (unaCuenta is CuentaCorriente)
                FabricaPersistencia.GetPersistenciaCuentaCorriente().Baja((CuentaCorriente)unaCuenta);
            else
                FabricaPersistencia.GetPersitenciaCuentaCAhorro().Baja((CuentaCAhorro)unaCuenta);
        }

        public Cuenta Buscar(int pNumCta)
        {
            Cuenta _unaCuenta = null;
            _unaCuenta = FabricaPersistencia.GetPersistenciaCuentaCorriente().Buscar(pNumCta);
            if (_unaCuenta == null)
                _unaCuenta = FabricaPersistencia.GetPersitenciaCuentaCAhorro().Buscar(pNumCta);
            return _unaCuenta;
        }

        public List<Cuenta> ListarTodas()
        {
            List<Cuenta> _lista = new List<Cuenta>();
            List<CuentaCorriente> _listaCC = FabricaPersistencia.GetPersistenciaCuentaCorriente().Listado();
            List<CuentaCAhorro> _listaCA = FabricaPersistencia.GetPersitenciaCuentaCAhorro().Listado();

            foreach (CuentaCorriente _unaCuenta in _listaCC)
                _lista.Add(_unaCuenta);

            foreach (CuentaCAhorro _unaCuenta in _listaCA)
                _lista.Add(_unaCuenta);

            return _lista;
        }

        public List<CuentaCorriente> ListarCuentaCorriente()
        {
           return (FabricaPersistencia.GetPersistenciaCuentaCorriente().Listado()); 
        }

        public List<Movimiento> ListarMovimientosDeCuenta(Cuenta unaCuenta)
        {
            List<Movimiento> _lista = null;

            if (unaCuenta is CuentaCAhorro)
                _lista = FabricaPersistencia.GetPersitenciaCuentaCAhorro().ListarMovimientosDeCuenta((CuentaCAhorro)unaCuenta);

            if (unaCuenta is CuentaCorriente)
                _lista = FabricaPersistencia.GetPersistenciaCuentaCorriente().ListarMovimientosDeCuenta((CuentaCorriente)unaCuenta);

            return _lista;
 
        }
    }
}
