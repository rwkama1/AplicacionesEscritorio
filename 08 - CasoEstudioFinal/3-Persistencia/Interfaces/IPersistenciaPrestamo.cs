using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public interface IPersistenciaPrestamo
    {
        List<EntidadesCompartidas.Prestamo> ListoPrestamosCliente(EntidadesCompartidas.Cliente unCliente);
        void Alta(EntidadesCompartidas.Prestamo pPrestamo);
        List<EntidadesCompartidas.Prestamo> ListoPrestamos();
    }
}
