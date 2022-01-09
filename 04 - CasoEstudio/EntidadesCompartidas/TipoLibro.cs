using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
   public class TipoLibro:IComparable
    {
        //atributos
        private int _codigo;
        private String _nombre;
        private int _estanteria;

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

        public int Estanteria
        {
            get { return _estanteria; }
            set { _estanteria = value; }
        }

       //Contructor
        public TipoLibro(int pCodigo, String pNombre, int pEstanteria)
        {
            _codigo = pCodigo;
            _nombre = pNombre;
            _estanteria = pEstanteria;
        }

        //operaciones
        public override string ToString()
        {
            return (_codigo.ToString() + " - " + _nombre.Trim() + " - " + _estanteria.ToString());
        }

        //metodo a implementar de la interface
        public int CompareTo(object obj)
        {
            TipoLibro _unLibro = (TipoLibro)obj;
            return (this.Codigo.CompareTo(_unLibro.Codigo));
        }

    }
}
