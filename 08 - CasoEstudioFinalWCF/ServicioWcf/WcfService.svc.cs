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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WcfService" en el código, en svc y en el archivo de configuración a la vez.
    public class WcfService : IWcfService
    {
       //CLIENTE----------------------
        void IWcfService.AltaCliente(Cliente unCliente)
        {
          FabricaLogica.GetLogicaCliente().Alta(unCliente);
        }
        void IWcfService.BajaCliente(Cliente unCliente)
        { 
                FabricaLogica.GetLogicaCliente().Baja(unCliente);
 
        }
        void IWcfService.ModificarCliente(Cliente unCliente)
        {
                FabricaLogica.GetLogicaCliente().Modificar(unCliente);
        }
        Cliente IWcfService.BuscarCliente(int pNumCli)
        {
            Cliente _unCliente = null;
           
                _unCliente = FabricaLogica.GetLogicaCliente().Buscar(pNumCli);

            return _unCliente;
        }
        Cliente IWcfService.LogueoCliente(string pUsu, string pPass)
        {
            Cliente _unCliente = null;
            
                _unCliente = FabricaLogica.GetLogicaCliente().Logueo(pUsu, pPass);
            
            return _unCliente;
        }
        List<Cliente> IWcfService.ListarTodosClientes()
        {
            List<Cliente> _lista = null;
         
                _lista = FabricaLogica.GetLogicaCliente().Listar();
  
            return _lista;
        }
        List<Cuenta> IWcfService.ListaCuentasDeCliente(Cliente pCliente)
        {
            List<Cuenta> _lista = null;
          
                _lista = FabricaLogica.GetLogicaCliente().ListaCuentasDeCliente(pCliente);
  
            return _lista;
        }
        string IWcfService.ListaMovsDeCliente(Cliente pCliente)
        {
            XmlDocument _Documento = null;
           
                _Documento = FabricaLogica.GetLogicaCliente().ListaMovsDeCliente(pCliente);
            return _Documento.OuterXml;
        }
        //CUENTA-----------------------

        void IWcfService.AltaCuenta(Cuenta unaCuenta)
        {

                FabricaLogica.GetLogicaCuenta().Alta(unaCuenta);
           
        }

        void IWcfService.BajaCuenta(Cuenta unaCuenta)
        {
          
                FabricaLogica.GetLogicaCuenta().Baja(unaCuenta);
           
        }

        Cuenta IWcfService.BuscarCuenta(int pNumCta)
        {
            Cuenta _unaCuenta = null;
           
                _unaCuenta = FabricaLogica.GetLogicaCuenta().Buscar(pNumCta);
           
           
            return _unaCuenta;
        }

        List<Cuenta> IWcfService.ListarTodasCuentas()
        {
            List<Cuenta> _lista = null;
          
                _lista = FabricaLogica.GetLogicaCuenta().ListarTodas();
           
           

            return _lista;
        }

        List<CuentaCorriente> IWcfService.ListarCuentaCorriente()
        {
            List<CuentaCorriente> _lista = null;
           
                _lista = FabricaLogica.GetLogicaCuenta().ListarCuentaCorriente();

            return _lista;
        }

        List<Movimiento> IWcfService.ListarMovimientosDeCuenta(Cuenta unaCuenta)
        {
            List<Movimiento> _lista = null;
            
                _lista = FabricaLogica.GetLogicaCuenta().ListarMovimientosDeCuenta(unaCuenta);
           
            return _lista;
        }
        //EMPLEADO
        Empleado IWcfService.LogueoEmpleado(int pCI, string pPass)
        {
            Empleado _unEmp = null;
           
                _unEmp = FabricaLogica.GetLogicaEmpleado().Logueo(pCI, pPass);

            return _unEmp;
        }
        //MOVIMIENTO
        void IWcfService.AltaMovimiento(Movimiento pMovimiento)
        {
            FabricaLogica.GetLogicaMovimiento().MovimientoAlta(pMovimiento);
        }
        List<Movimiento> IWcfService.ListarTodosMovimientos()
        {
            List<Movimiento> _lista = null;
          
                _lista = FabricaLogica.GetLogicaMovimiento().ListarTodosLosMovimientos();
            return _lista;
        }
        //PRESTAMOS

        void IWcfService.AltaPrestamo(Prestamo pPrestamo)
        {
           
                FabricaLogica.GetLogicaPrestamo().Alta(pPrestamo);
           
        }


         List<Prestamo> IWcfService.ListoPrestamosCliente(Cliente unCliente)
        {
            List<Prestamo> _lista = null;
           
                _lista = FabricaLogica.GetLogicaPrestamo().ListoPrestamosCliente(unCliente);
  
            return _lista;
        }


         List<Prestamo> IWcfService.ListoTodosPrestamos()
        {
            List<Prestamo> _lista = null;
            
                _lista = FabricaLogica.GetLogicaPrestamo().ListoPrestamos();
           

            return _lista;
        }
    }
}
