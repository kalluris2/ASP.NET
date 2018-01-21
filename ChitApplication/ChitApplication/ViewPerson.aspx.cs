using Logging;
using PersonDetails.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChitApplication
{
    public partial class ViewPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Log.WriteDebugLog("value selected from drop down list");
            string value = "";
            if (DropDownList.SelectedItem != null)
                value = DropDownList.SelectedItem.ToString();
            ServiceReference.ChitApplicationServiceSoapClient serviceObj = new ServiceReference.ChitApplicationServiceSoapClient();            
            var data =  serviceObj.ViewPersons(value);
            List<PersonDetails.Model.Details> details = new List<PersonDetails.Model.Details>();
            foreach(var item in data)
            {
                Details list = new Details();
                list.registrationnumber = item.registrationnumber;
                list.firstname = item.firstname;
                list.lastname = item.lastname;
                list.phonenumber = item.phonenumber;
                list.address = item.address;
                details.Add(list);
            }
            GridView.DataSource = details;
            GridView.DataBind();
            Log.WriteDebugLog("data is binded to grid view");

        }

        
    }
}