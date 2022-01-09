using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    [Serializable]
    public class Articulo
    {
        //atributos
        private int _codigo;
        private string _nombre;
        private decimal _precio;
        
        //propiedades 
        //para que sean serializables deben contener seccion de GET y seccion de SET
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }


        //Contructor completo (no se puede usar a traves del WS)
        public Articulo(int pCodigo, string pNombre, decimal pPrecio)
        {
            _codigo = pCodigo;
            _nombre = pNombre;
            _precio = pPrecio;
        }


        //Constructor por Defecto (necesario para la serializacion automatica)
        public Articulo()
        { }



    }
}
