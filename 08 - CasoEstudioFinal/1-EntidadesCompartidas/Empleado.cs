using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    [Serializable]
    public class Empleado
    {
        //atributos
        private int _CiEmp;
        private string _NomEmp;
        private string _PassEmp;


        //Propiedades
        public int CiEmp
        {
            get { return _CiEmp; }
            set { _CiEmp = value; }
        }

        public string NomEmp
        {
            get { return _NomEmp; }
            set
            {
                if ((value.Trim().Length > 30) || (value.Trim().Length <= 0))
                    throw new Exception("Error en Nombre Empleado");
                else
                    _NomEmp = value;
            }
        }

        public string PassEmp
        {
            get { return _PassEmp; }
            set
            {
                if ((value.Trim().Length > 6) || (value.Trim().Length <= 0))
                    throw new Exception("Error en password de empleado");
                else
                    _PassEmp = value;
            }
        }


        //Constructor 
        public Empleado(int pCiEmp, string pNomEmp, string pPassEmp)
        {
            CiEmp = pCiEmp;
            NomEmp = pNomEmp;
            PassEmp = pPassEmp;
        }

        //constructor por defecto
        public Empleado()
        {
            CiEmp = 0;
            NomEmp = "n/d";
            PassEmp = "n/d";
        }


    }
}
