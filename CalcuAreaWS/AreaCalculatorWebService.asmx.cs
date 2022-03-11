using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalcuAreaWS
{
    /// <summary>
    /// Descripción breve de AreaCalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreaCalculatorWebService : System.Web.Services.WebService
    {

        

        [WebMethod]
        public string AreaCuadrado(int lados)
        {
            var resul = lados * lados;
            return resul.ToString();
        }

        [WebMethod]
        public string AreaTriangulo(int bases, int altura)
        {
            var resultado = (bases * altura) / 2;
            return resultado.ToString();

        }

        [WebMethod]
        public string AreaCirculo(float Radio)
        {
            var resultado = Radio * Radio * 3.14;
            return resultado.ToString();
        }

    }
}
