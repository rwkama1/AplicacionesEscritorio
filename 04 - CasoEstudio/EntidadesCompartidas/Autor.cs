using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Autor : IComparable
    {
        //atributos
        private int _codigo;
        private String _nombre;
        private String _nacionalidad;

        //propiedades
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public String Nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }

        //Contructor
        public Autor(int pCodigo, String pNombre, String pNacionalidad)
        {
            _codigo = pCodigo;
            _nombre = pNombre;
            _nacionalidad = pNacionalidad;
        }

        //operaciones
        public override string ToString()
        {
            return (_codigo.ToString() + " - " + _nombre.Trim() + " - " + _nacionalidad.Trim());
        }

        //metodo a implementar de la interface
        public int CompareTo(object obj)
        {
            Autor _unAutor = (Autor)obj;
            return (this.Codigo.CompareTo(_unAutor.Codigo));
        }

    }
}

