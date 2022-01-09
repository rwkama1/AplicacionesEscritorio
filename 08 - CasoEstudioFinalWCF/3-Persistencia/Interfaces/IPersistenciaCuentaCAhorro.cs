using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
   public interface IPersistenciaCuentaCAhorro
    {
       void Alta(EntidadesCompartidas.CuentaCAhorro pCuenta);
       void Baja(EntidadesCompartidas.CuentaCAhorro pCuenta);
       EntidadesCompartidas.CuentaCAhorro Buscar(int pNumCta);
       List<EntidadesCompartidas.CuentaCAhorro> Listado();
       List<EntidadesCompartidas.Movimiento> ListarMovimientosDeCuenta(EntidadesCompartidas.CuentaCAhorro pCuenta);
    }
}
