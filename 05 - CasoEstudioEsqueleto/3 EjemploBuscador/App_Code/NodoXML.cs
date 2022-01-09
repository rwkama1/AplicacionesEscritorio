using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


//la clase implementa la interfaz IComparable, para tener la operacion ComparteTo necesaria para cuando se desea ordenar una lista
//que contenga objetos de esta clase
public class NodoXML:IComparable
{
    //atributos que describen a un nodo de un archivo XML
    private string nombre;
    private string ruta;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public string Ruta
    {

        get { return ruta; }
        set { ruta = value; }
 
    }
	public NodoXML(string pnombre,string pruta)
	{
        Nombre = pnombre;
        Ruta = pruta;
	}
    public int CompareTo(object pObjeto)
    {
        if (pObjeto == null)
        {
            return 1;
        }
        else if (this == null)
            return -1;
        else
            return this.nombre.CompareTo(((NodoXML)pObjeto).nombre);
    }
}