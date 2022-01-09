using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Usuario
    {
        //atributos
        private String _nombre;
        private String _password;

        //Propiedades
        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //Constructor
        public Usuario(String pNom, String pPass)
        {
            _nombre = pNom;
            _password = pPass;
        }

    }
}
