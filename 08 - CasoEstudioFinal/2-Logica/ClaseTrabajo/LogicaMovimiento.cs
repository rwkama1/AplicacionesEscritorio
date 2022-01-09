using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    internal class LogicaMovimiento:ILogicaMovimiento
    {
        //Singleton
        private static LogicaMovimiento _instancia = null;
        private LogicaMovimiento() { }
        public static LogicaMovimiento GetInstancia()
        {
            if (_instancia == null)
                _instancia = new LogicaMovimiento();
            return _instancia;
        }

        //operaciones
        public void MovimientoAlta(Movimiento pMovimiento)
        {
            //Verificacion de retiro en cuenta corriente por el minimo
            if ((pMovimiento.UnaCuenta is CuentaCorriente) && (pMovimiento.TipoMov=="R"))
            {
                double _cuenta = pMovimiento.UnaCuenta.SaldoCuenta - pMovimiento.MontoMov;
                if (_cuenta < ((CuentaCorriente)pMovimiento.UnaCuenta).MinimoCta)
                    throw new Exception("El retiro supera el monto minimo de la cuenta");
            }

            //Verificacion en cualer tipo de moviento para caja de ahorro. Solo gratis 25 movs por mes
            if (pMovimiento.UnaCuenta is CuentaCAhorro) 
            {
                if (((CuentaCAhorro)pMovimiento.UnaCuenta).MovsCta >=25)
                    throw new Exception("Supera la cantidad d Movimientos Gratis");
            }

            FabricaPersistencia.GetPersitenciaMovimiento().Alta(pMovimiento);
        }

        public List<EntidadesCompartidas.Movimiento> ListarTodosLosMovimientos()
        {
            return (Persistencia.FabricaPersistencia.GetPersitenciaMovimiento().ListarTodosLosMovimientos());
        }

    }
}
