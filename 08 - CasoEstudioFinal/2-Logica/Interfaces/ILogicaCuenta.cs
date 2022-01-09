using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;


namespace Logica
{
    public interface ILogicaCuenta
    {
        void Alta(Cuenta unaCuenta);
        void Baja(Cuenta unaCuenta);
        Cuenta Buscar(int pNumCta);
        List<Cuenta> ListarTodas();
        List<CuentaCorriente> ListarCuentaCorriente();
        List<Movimiento> ListarMovimientosDeCuenta(Cuenta unaCuenta);
 
    }
}
