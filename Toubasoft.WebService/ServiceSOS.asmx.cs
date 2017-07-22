using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Toubasoft.WebService
{
    /// <summary>
    /// Description résumée de ServiceSOS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceSOS : System.Web.Services.WebService
    {

        [WebMethod]
        public string AddEleve(string nom, string prenom, string addr)
        {
            //Implementation des requettes
            return "Hello World";
        }
    }
}
