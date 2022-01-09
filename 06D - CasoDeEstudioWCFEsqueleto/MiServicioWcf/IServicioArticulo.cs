using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EntidadesCompartidas;
using Logica;

namespace MiServicioWcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioArticulo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioArticulo
    {
        [OperationContract]
        void AgregarArticulo(Articulo A);
        [OperationContract]
        void EliminarArticulo(Articulo A);
        [OperationContract]
        void ModificarArticulos(Articulo A);
        [OperationContract]
        Articulo BuscarArticulo(int pCodigo);
        [OperationContract]
       List<Articulo> ListarArticulos();

    }
}
