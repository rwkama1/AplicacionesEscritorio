using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;

namespace Logica
{
   public interface ILogicaAutor
    {
        Autor BuscarAutor(int pCodigo);
        List<Autor> ListarAutor();
        void Alta(Autor autor);
        void Eliminar(Autor autor);
        void Modificar(Autor autor);
   }
}
