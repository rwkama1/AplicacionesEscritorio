using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;

namespace Logica
{
   public interface ILogicaTipo
    {
       TipoLibro BuscarTipo(int pCodigo);
       List<TipoLibro> ListarTipo();
   }
}
