using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;




namespace EntidadesCompartidas
{
     [DataContract]
    public class Cliente
    {

        //atributos
        private int _NumCli;
        private string _NomCli;
        private string _DirCli;
        private string _PassCli;
        private string _UsuCli;

        private List<string> _ListaTel;


        //Propiedades
         [DataMember]
        public int NumCli
        {
            get { return _NumCli; }
            set { _NumCli = value; }
        }
         [DataMember]
        public string NomCli
        {
            get { return _NomCli; }
            set
            {
                if ((value.Trim().Length > 30) || (value.Trim().Length <= 0))
                    throw new Exception("Error en Nombre cliente");
                else
                    _NomCli = value;
            }
        }
         [DataMember]
        public string DirCli
        {
            get { return _DirCli; }
            set
            {
                if ((value.Trim().Length > 30) || (value.Trim().Length <= 0))
                    throw new Exception("Error en Direccion cliente");
                else
                    _DirCli = value;
            }
        }
         [DataMember]
        public string PassCli
        {
            get { return _PassCli; }
            set
            {
                if ((value.Trim().Length > 6) || (value.Trim().Length <= 0))
                    throw new Exception("Error en password de cliente");
                else
                    _PassCli = value;
            }
        }
         [DataMember]
        public string UsuCli
        {
            get { return _UsuCli; }
            set
            {
                if ((value.Trim().Length > 10) || (value.Trim().Length <= 0))
                    throw new Exception("Error en usuario de cliente");
                else
                    _UsuCli = value;
            }
        }
         [DataMember]
        public List<string> ListaTelefonos
        {
            get { return _ListaTel; }
            set { _ListaTel = value; }
        }


        //Constructor completo
        public Cliente(int pNumCli, string pNomCli, string pDirCli, string pUsuCli, string pPassCli, List<string> pLista)
        {
            NumCli = pNumCli;
            NomCli = pNomCli;
            DirCli = pDirCli;
            UsuCli = pUsuCli;
            PassCli = pPassCli;
            ListaTelefonos = pLista;
        }

        //constructor por defecto
        public Cliente()
        {
            NumCli = 0;
            NomCli = "n/d";
            DirCli = "n/d";
            UsuCli = "n/d";
            PassCli = "n/d";
            ListaTelefonos = null;
        }
  
    }
}
