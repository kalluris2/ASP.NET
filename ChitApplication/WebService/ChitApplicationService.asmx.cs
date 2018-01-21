using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PersonDetails.Model;
using DataBaseOperations;
using System.Data;

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
            
            try
            {
                DataBase obj = new DataBase();
                bool check = obj.InsertRegistration(values);
                return check;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public bool InsertPaymentDetails(Details values)
        {
            try
            {
                DataBase obj = new DataBase();
                bool check = obj.InsertPaymentDetails(values);
                return check;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public bool LoginDetails(Details values)
        {
            try
            {
                DataBase obj = new DataBase();
                bool check = obj.EmployeeLogin(values);
                return check;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        [WebMethod]
        public List<PersonDetails.Model.Details> ViewPersons(string value)
        {
            try
            {
                DataBase obj = new DataBase();
                var data = obj.ViewPerson(value);
                List<PersonDetails.Model.Details> details = new List<PersonDetails.Model.Details>();
                foreach (DataRow item in data.Rows)
                {
                    //List<PersonDetails.Model.Details> details = new List<PersonDetails.Model.Details>();
                    PersonDetails.Model.Details Instance = new Details();
                    Instance.registrationnumber = Convert.ToInt32(item[0]);
                    Instance.firstname = item[1].ToString();
                    Instance.lastname = item[2].ToString();
                    Instance.phonenumber = Convert.ToInt32(item[3]);
                    Instance.address = item[4].ToString();
                    details.Add(Instance);

                }
                return details;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        [WebMethod]
        public bool DeleteRecord(int id)
        {
            try
            {

                DataBase obj = new DataBase();
                bool check = obj.DeleteRecord(id);
                return check;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

    }
}
