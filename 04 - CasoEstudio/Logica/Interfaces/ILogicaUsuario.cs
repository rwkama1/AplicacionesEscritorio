using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;

namespace Logica
{
   public interface ILogicaUsuario
    {
        Usuario BuscarUsuario(String pNombre);
   }
}
