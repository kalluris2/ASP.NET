using DatabaseOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChitApp;

namespace ChitApp
{
    public partial class LoginPag : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                int EmployeeId = Convert.ToInt32(EmployeeIdTextBox.Text);
                string Password = PasswordTextBox.Text;
                Database Data = new Database();
                if (Data.EmployeeLogin(EmployeeId, Password))
                {
                    
                    Sites Pages = new Sites();
                    Pages.PageDisplay();
                    Response.Write("login successful");
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}