using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PersonDetails.Model;
using DataBaseOperations;

namespace WebService
{
    /// <summary>
    /// Summary description for ChitApplicationService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ChitApplicationService : System.Web.Services.WebService
    {


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public bool InsertRegistration(Details values)
        {
            DataBase obj = new DataBase();
            bool check= obj.InsertRegistration(values);
            return check;
        }

        [WebMethod]
        public bool InsertPaymentDetails(Details values)
        {
            DataBase obj = new DataBase();
            bool check = obj.InsertPaymentDetails(values);
            return check;
        }

    }
}
