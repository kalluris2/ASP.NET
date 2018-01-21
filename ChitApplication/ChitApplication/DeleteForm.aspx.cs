using Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChitApplication
{
    public partial class DeleteForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EraseButton_Click(object sender, EventArgs e)
        {
            Log.WriteDebugLog("erase button is clicked");
            int RegistrationNumber ;
            if (!(Regex.IsMatch(DeleteTextBox.Text, pattern: "^[ 0-9]")))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter proper registration number');</script>");
                Log.WriteDebugLog("registration number is not entered");
            }
            else
            {
                RegistrationNumber = Convert.ToInt32(DeleteTextBox.Text);
                ServiceReference.ChitApplicationServiceSoapClient serviceObj = new ServiceReference.ChitApplicationServiceSoapClient();
                if (serviceObj.DeleteRecord(RegistrationNumber))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('record deleted');</script>");
                    Log.WriteDebugLog("record is deleted");
                }
            }
        }
    }
}