using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Curp
{
    /// <summary>
    /// Descripción breve de ServicioCurp
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioCurp : System.Web.Services.WebService
    {

        [WebMethod]
        public string Generar(string nombre, string apaterno, string amaterno, string dia, string mes, string ano, string sexo)
        {
            string curp = apaterno.Substring(0, 1).ToUpper();

            for (int i = 1; i < apaterno.Length; i++)
            {
                if (apaterno.Substring(i, 1).ToUpper() == "A" || apaterno.Substring(i, 1).ToUpper() == "E" || apaterno.Substring(i, 1).ToUpper() == "I" || apaterno.Substring(i, 1).ToUpper() == "O" || apaterno.Substring(i, 1).ToUpper() == "U")
                {
                    curp += apaterno.Substring(i, 1).ToUpper();

                    break;
                }
            }

            if (dia.Length == 1)
            { curp += "0" + dia; }
            else { curp += dia.Substring(0,2); }


            if (mes.Length == 1)
            { curp += "0" + mes; }
            else { curp += mes.Substring(0, 2); }

            curp += amaterno.Substring(0, 1).ToUpper();
            curp += nombre.Substring(0, 1).ToUpper();
            curp += ano.Substring(2, 2);
            curp += mes.Substring(0, 2);
            curp += dia.Substring(0, 2);
            curp += sexo.Substring(0, 1);

            return curp;
        }
    }
}
