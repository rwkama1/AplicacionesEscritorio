using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using Persistencia;
using System.Xml;

namespace Logica
{
    internal class LogicaCliente:ILogicaCliente
    {
        //Singleton
        private static LogicaCliente _instancia = null;
        private LogicaCliente() { }
        public static LogicaCliente GetInstancia()
        {
            if (_instancia == null)
                _instancia = new LogicaCliente();
            return _instancia;
        }

        //operaciones
        public void Alta(Cliente unCliente)
        {
            FabricaPersistencia.GetPersistenciaCliente().Alta(unCliente);
        }

        public void Baja(Cliente unCliente)
        {
            FabricaPersistencia.GetPersistenciaCliente().Baja(unCliente);
        }

        public void Modificar(Cliente unCliente)
        {
            FabricaPersistencia.GetPersistenciaCliente().Modificar(unCliente);
        }

        public List<Cliente> Listar()
        {
            return ( FabricaPersistencia.GetPersistenciaCliente().Listar());
        }

        public Cliente Buscar(int pNumCli)
        {
            return (FabricaPersistencia.GetPersistenciaCliente().Buscar(pNumCli));
        }

       public List<Cuenta> ListaCuentasDeCliente(Cliente pCLiente)
        {
            return Persistencia.FabricaPersistencia.GetPersistenciaCliente().ListaCuentasDeCliente(pCLiente);
        }

       public Cliente Logueo(string pUsu, string pPass)
       {
           return Persistencia.FabricaPersistencia.GetPersistenciaCliente().Logueo(pUsu, pPass);
       }

       public XmlDocument ListaMovsDeCliente(Cliente pCLiente)
       {
           //obtengo datos
           List<Movimiento> _lista = Persistencia.FabricaPersistencia.GetPersistenciaCliente().ListaMovsDeCliente(pCLiente);

           //convierto a xml
           XmlDocument _Documento = new XmlDocument();
           _Documento.LoadXml("<?xml version='1.0' encoding='utf-8' ?> <Raiz> </Raiz>");
           XmlNode _raiz = _Documento.DocumentElement;

           //recorro la lista para crear los nodos
           foreach (Movimiento unM in _lista)
           {
               XmlElement _IdMov = _Documento.CreateElement("IdMov");
               _IdMov.InnerText = unM.IdMov.ToString();

               XmlElement _NumCta = _Documento.CreateElement("NumCta");
               _NumCta.InnerText = unM.UnaCuenta.NumCta.ToString();

               XmlElement _FechaMov = _Documento.CreateElement("FechaMov");
               _FechaMov.InnerText = unM.FechaMov.ToString("yyyyMMdd");

               XmlElement _MontoMov = _Documento.CreateElement("MontoMov");
               _MontoMov.InnerText = unM.MontoMov.ToString();

               XmlElement _TipoMov = _Documento.CreateElement("TipoMov");
               _TipoMov.InnerText = unM.TipoMov;

               XmlElement _Nodo = _Documento.CreateElement("Movimiento");
               _Nodo.AppendChild(_IdMov);
               _Nodo.AppendChild(_NumCta);
               _Nodo.AppendChild(_FechaMov);
               _Nodo.AppendChild(_MontoMov);
               _Nodo.AppendChild(_TipoMov);

               _raiz.AppendChild(_Nodo);

           }

           //retorno los datos en formato XML
           return _Documento;
       }

    }
}
