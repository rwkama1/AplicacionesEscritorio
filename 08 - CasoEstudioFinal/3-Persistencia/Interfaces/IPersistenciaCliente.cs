using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public interface IPersistenciaCliente
    {
        void Alta(EntidadesCompartidas.Cliente unCliente);
        void Baja(EntidadesCompartidas.Cliente unCliente);
        void Modificar(EntidadesCompartidas.Cliente unCliente);
        EntidadesCompartidas.Cliente Buscar(int pNumCli);
        List<EntidadesCompartidas.Cliente> Listar();
        List<EntidadesCompartidas.Cuenta> ListaCuentasDeCliente(EntidadesCompartidas.Cliente pCLiente);
        EntidadesCompartidas.Cliente Logueo(string pUsu, string pPass);
        List<EntidadesCompartidas.Movimiento> ListaMovsDeCliente(EntidadesCompartidas.Cliente pCLiente);

    }
}
