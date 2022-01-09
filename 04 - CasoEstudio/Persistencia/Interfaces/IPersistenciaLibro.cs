using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;

namespace Persistencia
{
    public interface IPersistenciaLibro
    {
        void AltaLibro(Libro unLibro);
        void BajaLibro(Libro unLibro);
        void ModificaLibro(Libro unLibro);
        Libro BuscarLibro(int pIsbn);
        List<Libro> ListarLibro();
        List<Libro> ListarLibroPorTipo(TipoLibro unTipo);
    }
}
