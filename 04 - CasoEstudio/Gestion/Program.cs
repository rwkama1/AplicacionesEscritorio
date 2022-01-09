using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gestion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]//es un atributo para clases, modifica comportamientos,impactan en la definicion que lo sigue, en nuestro caso
            //lo que lo sigue es una clase, se puede poner para operaciones, clases atributos, propiedades etc, cambian el comportamiento
            //de esos
            //en nuestro caso hace que una ejecucion comun se pueda hacer en multi hilos
        static void Main()
        {
            Application.EnableVisualStyles();//La clase aplication me permite armar una aplicacion, es una clase no un objeto, ACA ES LA CLASE APLICACION
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPresentacion());//operacion run permite comenzar un hilo de ejecucion apartir de un objeto
            //Dado el objeto creo el hilo de ejecucion, el objeto que le paso parametro es el primer formulario que quiero yo ver

            //Hay una diferencia entre no ver formulario y que el formulario haya desaparecido de memoria,si borro yo un objeto de memoria
            //se borra el objeto, si yo oculto un formulario en realidad el formulario desaparece en la parte grafica de windows
            //si quiero ocultar un formulario y no lo quiero quitar, LO VOY A OCULTAR,
        }
    }
}
