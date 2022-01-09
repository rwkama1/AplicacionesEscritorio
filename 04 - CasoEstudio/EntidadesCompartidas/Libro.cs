using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
   public class Libro
    {
      
        //atributos
        private int _codigo;
        private String _nombre;
        private String _reseña;
        private Autor _unAutor;
        private TipoLibro _unTipo;

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

        public String Reseña
        {
            get { return _reseña; }
            set { _reseña = value; }
        }

        public Autor UnAutor
        {
            get { return _unAutor; }
            set { _unAutor = value; }
        }

        public TipoLibro UnTipo
        {
            get { return _unTipo; }
            set { _unTipo = value; }
        }

        //Contructor
        public Libro(int pCodigo, String pNombre, String pReseña, Autor pAutor, TipoLibro pTipoLibro)
        {
            _codigo = pCodigo;
            _nombre = pNombre;
            _reseña = pReseña;
            _unAutor = pAutor;
            _unTipo = pTipoLibro;
        }

    }
}
