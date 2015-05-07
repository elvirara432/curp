using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Zodiaco
{
    /// <summary>
    /// Descripción breve de ZodiacoWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ZodiacoWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Fecha(DateTime fecha)
        {
            string zodiaco=string.Empty;
            int a = fecha.Year;
            if (fecha >= new DateTime(a, 3, 20)&&fecha<= new DateTime(a, 4, 20))
            {
                zodiaco = "Aries";
            }

            if (fecha >= new DateTime(a, 4, 20) && fecha <= new DateTime(a, 5, 21))
            {
                zodiaco = "Tauro";
            }

            if (fecha >= new DateTime(a, 5, 21) && fecha <= new DateTime(a, 6, 21))
            {
                zodiaco = "Géminis";
            }

            if (fecha >= new DateTime(a, 6, 21) && fecha <= new DateTime(a, 7, 23))
            {
                zodiaco = "Cáncer";
            }

            if (fecha >= new DateTime(a, 7, 23) && fecha <= new DateTime(a, 8, 23))
            {
                zodiaco = "Leo";
            }

            if (fecha >= new DateTime(a, 8, 23) && fecha <= new DateTime(a, 9, 23))
            {
                zodiaco = "Virgo";
            }

            if (fecha >= new DateTime(a, 9, 23) && fecha <= new DateTime(a, 10, 23))
            {
                zodiaco = "Libra";
            }

            if (fecha >= new DateTime(a, 10, 23) && fecha <= new DateTime(a, 11, 22))
            {
                zodiaco = "Escorpio";
            }

            if (fecha >= new DateTime(a, 11, 22) && fecha <= new DateTime(a, 12, 22))
            {
                zodiaco = "Sagitario";
            }

            if (fecha >= new DateTime(a, 12, 22) || fecha <= new DateTime(a, 1, 20))
            {
                zodiaco = "Capricornio";
            }

            if (fecha >= new DateTime(a, 1, 20) && fecha <= new DateTime(a, 2, 18))
            {
                zodiaco = "Acuario";
            }

            if (fecha >= new DateTime(a, 2, 18) && fecha <= new DateTime(a, 3, 20))
            {
                zodiaco = "Piscis";
            }
            return zodiaco;
        }
    }
}
