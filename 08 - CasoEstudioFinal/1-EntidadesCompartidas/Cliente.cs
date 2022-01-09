using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EntidadesCompartidas
{
    [Serializable]
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
        public int NumCli
        {
            get { return _NumCli; }
            set { _NumCli = value; }
        }

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
