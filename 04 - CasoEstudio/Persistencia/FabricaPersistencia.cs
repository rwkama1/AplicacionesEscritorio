using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;

namespace Persistencia
{
    public class FabricaPersistencia
    {
        public static IPersistenciaAutor getPersistenciaAutor()
        {
            return (PersistenciaAutor.GetInstancia());
        }

        public static IPersistenciaUsuario getPersistenicaUsuario()
        {
            return (PersistenciaUsuario.GetInstancia());
        }

        public static IPersistenciaTipo getPersistenciaTipoLibro()
        {
            return (PersistenciaTipo.GetInstancia());
        }

        public static IPersistenciaLibro getPersistenciaLibro()
        {
            return (PersistenciaLibro.GetInstancia());
        }
    }
}
