using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;



using EntidadesCompartidas;
using Logica;
using System.Xml;
using System.Web.Services.Protocols;




/// <summary>
/// Descripción breve de MiServicio
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class MiServicio : System.Web.Services.WebService
{

    public MiServicio()
    {

        //Eliminar la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    } 

    #region OperacionesDelServicio

    private void GeneroSoapException(Exception ex)
    {
        //generacion manual de excepcion SOAP - para poder obtener solo el mensaje enviado por alguna de las capas

        //1.- se debe crear un nodo xml (NodoError) el cual sera utilizado  para cargar el atributo Details de la exception SOAP
        XmlDocument _undoc = new System.Xml.XmlDocument();
        XmlNode _NodoError = _undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);

        //2.- Se crea un nodo xml (NodoDetalle) q contendra el texto del error
        XmlNode _NodoDetalle = _undoc.CreateNode(XmlNodeType.Element, "Error", "");
        _NodoDetalle.InnerText = ex.Message;
        _NodoError.AppendChild(_NodoDetalle);

        //4. Creacion manual y lanzamiento de la exception SOAP
        SoapException _MiEx = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, _NodoError);
        throw _MiEx;
    }

    #endregion

    #region SolucionSer

    //necesario para q serialize los dos tipos de cuentas hacia el WS
    [WebMethod]
    public void ParaPoderSerializar(CuentaCorriente unaCC, CuentaCAhorro unaCA) { }

    //necesario para q serialize el tipo de cuenta no usado directamente desde el WS
    [WebMethod]
    public CuentaCAhorro ParaPoderSerializarCA()
    {
        return new CuentaCAhorro();
    }

    #endregion

    #region LogicaCliente

    [WebMethod]
    public void AltaCliente(Cliente unCliente)
    {
        try
        {
            FabricaLogica.GetLogicaCliente().Alta(unCliente);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }

    [WebMethod]
    public void BajaCliente(Cliente unCliente)
    {
        try
        {
            FabricaLogica.GetLogicaCliente().Baja(unCliente);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }

    [WebMethod]
    public void ModificarCliente(Cliente unCliente)
    {
        try
        {
            FabricaLogica.GetLogicaCliente().Modificar(unCliente);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }

    [WebMethod]
    public Cliente BuscarCliente(int pNumCli)
    {
        Cliente _unCliente = null;
        try
        {
           _unCliente= FabricaLogica.GetLogicaCliente().Buscar(pNumCli);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
        return _unCliente;
    }

    [WebMethod]
    public Cliente LogueoCliente(string pUsu, string pPass)
    {
        Cliente _unCliente = null;
        try
        {
            _unCliente = FabricaLogica.GetLogicaCliente().Logueo(pUsu, pPass);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
        return _unCliente;
    }

    [WebMethod]
    public List<Cliente> ListarTodosClientes()
    {
        List<Cliente> _lista = null;
        try
        {
            _lista = FabricaLogica.GetLogicaCliente().Listar();
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }

        return _lista;
    }

    [WebMethod]
    public List<Cuenta> ListaCuentasDeCliente(Cliente pCliente)
    {
        List<Cuenta> _lista = null;
        try
        {
            _lista = FabricaLogica.GetLogicaCliente().ListaCuentasDeCliente(pCliente);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }

        return _lista;
    }

    [WebMethod]
    public XmlDocument ListaMovsDeCliente(Cliente pCliente)
    {
        XmlDocument _Documento = null;
        try
        {
            _Documento = FabricaLogica.GetLogicaCliente().ListaMovsDeCliente(pCliente);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }

        return _Documento;
    }


    #endregion

    #region LogicaCuenta

    [WebMethod]
    public void AltaCuenta(Cuenta unaCuenta)
    {
        try
        {
            FabricaLogica.GetLogicaCuenta().Alta(unaCuenta);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }

    [WebMethod]
    public void BajaCuenta(Cuenta unaCuenta)
    {
        try
        {
            FabricaLogica.GetLogicaCuenta().Baja(unaCuenta);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }

    [WebMethod]
    public Cuenta BuscarCuenta(int pNumCta)
    {
        Cuenta _unaCuenta = null;
        try
        {
            _unaCuenta = FabricaLogica.GetLogicaCuenta().Buscar(pNumCta);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
        return _unaCuenta;
    }

    [WebMethod]
    public List<Cuenta> ListarTodasCuentas()
    {
        List<Cuenta> _lista = null;
        try
        {
            _lista = FabricaLogica.GetLogicaCuenta().ListarTodas();
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }

        return _lista;
    }

    [WebMethod]
    public List<CuentaCorriente> ListarCuentaCorriente()
    {
        List<CuentaCorriente> _lista = null;
        try
        {
            _lista = FabricaLogica.GetLogicaCuenta().ListarCuentaCorriente();
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }

        return _lista;
    }

    [WebMethod]
    public List<Movimiento> ListarMovimientosDeCuenta(Cuenta unaCuenta)
    {
        List<Movimiento> _lista = null;
        try
        {
            _lista = FabricaLogica.GetLogicaCuenta().ListarMovimientosDeCuenta(unaCuenta);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }

        return _lista;
    }

    #endregion

    #region LogicaEmpleado

    [WebMethod]
    public Empleado LogueoEmpleado(int pCI, string pPass)
    {
        Empleado _unEmp = null;
        try
        {
            _unEmp = FabricaLogica.GetLogicaEmpleado().Logueo(pCI, pPass);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
        return _unEmp;
    }

    #endregion

    #region LogicaMovimiento

    [WebMethod]
    public void AltaMovimiento(Movimiento pMovimiento)
    {
        try
        {
            FabricaLogica.GetLogicaMovimiento().MovimientoAlta(pMovimiento);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }

    [WebMethod]
    public List<Movimiento> ListarTodosMovimientos()
    {
        List<Movimiento> _lista = null;
        try
        {
            _lista = FabricaLogica.GetLogicaMovimiento().ListarTodosLosMovimientos();
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }

        return _lista;
    }

    #endregion

    #region LogicaPrestamo

    [WebMethod]
    public void AltaPrestamo(Prestamo pPrestamo)
    {
        try
        {
            FabricaLogica.GetLogicaPrestamo().Alta(pPrestamo);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }

    [WebMethod]
    public List<Prestamo> ListoPrestamosCliente(Cliente unCliente)
    {
        List<Prestamo> _lista = null;
        try
        {
            _lista = FabricaLogica.GetLogicaPrestamo().ListoPrestamosCliente(unCliente);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }

        return _lista;
    }

    [WebMethod]
    public List<Prestamo> ListoTodosPrestamos()
    {
        List<Prestamo> _lista = null;
        try
        {
            _lista = FabricaLogica.GetLogicaPrestamo().ListoPrestamos();
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }

        return _lista;
    }

    #endregion

}
