using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
//incluyo el servicio
using ReferenciaCalculosMatematicos;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

     protected void btnCalculoF_Click(object sender, EventArgs e)
    {
        try
        {
            //obtengo el numero para calcular factorial
            long numero = Convert.ToInt64(txtNumero.Text);
            //consumo directamente una operacion del WS
            lblDespliego.Text = "Resultado del Factorial " + new ReferenciaCalculosMatematicos.CalculosMatematicos().Factorial(numero);
            //limpio cajas de ingreso
            txtNumero.Text = "";
        }
        catch (Exception ex)
        {
            lblDespliego.Text = ex.Message;
        }
 
    }

    protected void btnCalculoP_Click(object sender, EventArgs e)
    {
        try
        {
            //obtengo los numeros para calcular potencia
            double _base = Convert.ToDouble(txtBase.Text);
            double exponente = Convert.ToDouble(txtExponente.Text);
            //creo un objeto que me permita consumir el WS a atraves del SOAP
            //consumo directamente de una operacion del WS
           //ReferenciaCalculosMatematicos.CalculosMatematicosSoapClient unServicio = new CalculosMatematicosSoapClient("CalculosMatematicosSoap");
           lblDespliego.Text = "Resultado de la potencia " + new ReferenciaCalculosMatematicos.CalculosMatematicos().Potencia(_base, exponente);
            //limpio cajas de ingreso
            txtBase.Text = "";
            txtExponente.Text = "";

        }
        catch (Exception ex)
        {
            lblDespliego.Text = ex.Message;
            
        }
   
    }
}
