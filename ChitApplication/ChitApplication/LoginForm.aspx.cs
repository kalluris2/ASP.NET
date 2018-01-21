using Logging;
using PersonDetails.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChitApplication
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Log.WriteDebugLog("login page is opened");
            Details Values = new Details();
            if (!(Regex.IsMatch(EmployeeIdTextBox.Text, pattern: "^[ 0-9]")))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('employee id contains only numbers');</script>");
                Log.WriteDebugLog("login failed due to wrong employee id");
            }
            else if (!(Regex.IsMatch(PasswordTextBox.Text, pattern: "^[ a-z0-9]*$")))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('please enter correct password');</script>");
                Log.WriteDebugLog("login failed due to wrong password");
            }
            else
            {
                Values.employeeid = Convert.ToInt32(EmployeeIdTextBox.Text);
                Values.password = (PasswordTextBox.Text);
                Log.WriteDebugLog("employee details are entered correctly");
                Log.WriteDebugLog("login button is clicked");
                ServiceReference.ChitApplicationServiceSoapClient serviceObj = new ServiceReference.ChitApplicationServiceSoapClient();
                
                ChitApplication.ServiceReference.Details obj = new ServiceReference.Details();
                
                obj.employeeid = Values.employeeid;
                obj.password = Values.password;
                
                if (serviceObj.LoginDetails(obj))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('login successfully');</script>");
                    Log.WriteDebugLog("login successful");
                    Response.Redirect("RegistrationForm.aspx");
                    Log.WriteDebugLog("registration page is displayed");

                }
            }
        }
    }
}