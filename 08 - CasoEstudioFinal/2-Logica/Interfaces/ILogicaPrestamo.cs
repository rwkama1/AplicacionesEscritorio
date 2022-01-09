using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public interface ILogicaPrestamo
    {
        List<EntidadesCompartidas.Prestamo> ListoPrestamosCliente(EntidadesCompartidas.Cliente unCliente);
        void Alta(EntidadesCompartidas.Prestamo pPrestamo);
        List<EntidadesCompartidas.Prestamo> ListoPrestamos();
    }
}
