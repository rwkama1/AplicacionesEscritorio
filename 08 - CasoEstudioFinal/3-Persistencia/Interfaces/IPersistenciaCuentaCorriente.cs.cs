using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
  public  interface IPersistenciaCuentaCorriente
    {
        void Alta(EntidadesCompartidas.CuentaCorriente pCuenta);
        void Baja(EntidadesCompartidas.CuentaCorriente pCuenta);
        EntidadesCompartidas.CuentaCorriente Buscar(int pNumCta);
        List<EntidadesCompartidas.CuentaCorriente> Listado();
        List<EntidadesCompartidas.Movimiento> ListarMovimientosDeCuenta(EntidadesCompartidas.CuentaCorriente pCuenta);
    }
}
