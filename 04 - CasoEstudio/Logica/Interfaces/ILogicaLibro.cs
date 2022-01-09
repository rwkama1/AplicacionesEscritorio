using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;

namespace Logica
{
    public interface ILogicaLibro
    {
        void AltaLibro(Libro unLibro);
        void BajaLibro(Libro unLibro);
        void ModificaLibro(Libro unLibro);
        Libro BuscarLibro(int pIsbn);
        List<Libro> ListarLibro();
        List<Libro> ListarLibroPorTipo(TipoLibro unTipo);
    }
}
