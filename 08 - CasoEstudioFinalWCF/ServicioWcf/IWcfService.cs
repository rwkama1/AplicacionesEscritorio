using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EntidadesCompartidas;
using Logica;
using System.Xml;
namespace ServicioWcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWcfService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWcfService
    {
        //CLIENTE--------------------------------------------------------------------------------
        [OperationContract]
        void AltaCliente(Cliente unCliente);



        [OperationContract]
        void BajaCliente(Cliente unCliente);


        [OperationContract]
        void ModificarCliente(Cliente unCliente);


        [OperationContract]
        Cliente BuscarCliente(int pNumCli);

        [OperationContract]
        Cliente LogueoCliente(string pUsu, string pPass);


        [OperationContract]
        List<Cliente> ListarTodosClientes();


        [OperationContract]
        List<Cuenta> ListaCuentasDeCliente(Cliente pCliente);


        [OperationContract]
        string ListaMovsDeCliente(Cliente pCliente);
        //CUENTA---------------------------------------------------------------------------
        [OperationContract]
        void AltaCuenta(Cuenta unaCuenta);
       

         [OperationContract]
         void BajaCuenta(Cuenta unaCuenta);
        

          [OperationContract]
        Cuenta BuscarCuenta(int pNumCta);
       

        [OperationContract]
        List<Cuenta> ListarTodasCuentas();
      

        [OperationContract]
        List<CuentaCorriente> ListarCuentaCorriente();
      

         [OperationContract]
       List<Movimiento> ListarMovimientosDeCuenta(Cuenta unaCuenta);
         //EMPLEADO--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         [OperationContract]
         Empleado LogueoEmpleado(int pCI, string pPass);
         //MOVIMIENTO--------------------------------------------------------------------------------------------------------------------------------------------
         [OperationContract]
         void AltaMovimiento(Movimiento pMovimiento);

         [OperationContract]
         List<Movimiento> ListarTodosMovimientos();
         //PRETAMO----------------------------------------------------------------------------------------------------
         [OperationContract]
         void AltaPrestamo(Prestamo pPrestamo);
        

         [OperationContract]
         List<Prestamo> ListoPrestamosCliente(Cliente unCliente);


         [OperationContract]
         List<Prestamo> ListoTodosPrestamos();
        
       
    }
    
}
