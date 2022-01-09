using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    [Serializable]
   public class Produccion:Articulo
    {
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
         public Produccion(int pcodigo,string pnombre, decimal pPrecio,DateTime pfecha)
            : base(pcodigo, pnombre, pPrecio)
        {
            Fecha = pfecha;
        }
         public Produccion()
             
         {
            
         }

    }
}
