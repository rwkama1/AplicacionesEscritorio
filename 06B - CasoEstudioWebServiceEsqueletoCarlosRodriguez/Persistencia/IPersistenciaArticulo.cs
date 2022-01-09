using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;

namespace Persistencia
{
    public interface IPersistenciaArticulo
    {
        void AgregarArticulo(Produccion A);
        void EliminarArticulo(Produccion A);
        void ModificarArticulo(Produccion A);
        Produccion BuscarArticulo(int pCodigo);
        List<Articulo> ListarArticulo();
    }
}
