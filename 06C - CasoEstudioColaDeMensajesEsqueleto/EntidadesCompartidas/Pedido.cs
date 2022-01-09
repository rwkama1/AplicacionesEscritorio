using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    [Serializable]
    public class Pedido
    {
        //atributos
        private int _NumPedido;
        private string _NomCliente;
        private string _DirCliente;
        private Articulo _unARticulo;


        //propiedades
        public int NumPedido
        {
            get { return _NumPedido; }
            set { _NumPedido = value; }
        }

        public string NomCliente
        {
            get { return _NomCliente; }
            set { _NomCliente = value; }
        }

        public string DirCliente
        {
            get { return _DirCliente; }
            set { _DirCliente = value; }
        }

        public Articulo UnARticulo
        {
            get { return _unARticulo; }
            set { _unARticulo = value; }
        }

        //constructo por defecto para la serializacion
        public Pedido()
        {
            NumPedido = 0;
            NomCliente = "";
            DirCliente = "";
            UnARticulo = null;
        }

        //constructor comun
        public Pedido(int pNum, string pNom, string pDir, Articulo pArt)
        {
            NumPedido = pNum;
            NomCliente = pNom;
            DirCliente = pDir;
            UnARticulo = pArt;
        }

        //operaciones
        public override string ToString()
        {
            return (this.NumPedido.ToString() + " - " + this.NomCliente.Trim() + " - " + this.UnARticulo.Nombre);
        }

    }
}
