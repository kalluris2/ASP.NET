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
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                Details Values = new Details();
                Values.firstname = FirstNameTextBox.Text;
                Values.lastname = LastNameTextBox.Text;
                Values.address = AddressTextBox.Text;
                
                if (!(Regex.IsMatch(RegistrationNumberTextBox.Text, pattern: "^[ 0-9]")))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('registratio number contains only numbers');</script>");
                }
                else if (string.IsNullOrEmpty(RegistrationNumberTextBox.Text))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter registration number');</script>");

                }
                else if (!(Regex.IsMatch(Values.firstname, pattern: "^[ a-z]")))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter first name only in small's ');</script>");

                }
                else if (string.IsNullOrEmpty(Values.firstname))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter first name');</script>");

                }
                else if (!(Regex.IsMatch(Values.lastname, pattern: "^[ a-z]")))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter last name only in small's ');</script>");

                }
                else if (string.IsNullOrEmpty(Values.lastname))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter last name');</script>");

                }
                else if (string.IsNullOrEmpty(Values.address))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter last name');</script>");

                }
                else if (string.IsNullOrEmpty(PhoneNumberTextBox.Text))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter phone number');</script>");

                }
                else
                {
                    Values.registrationnumber = Convert.ToInt32(RegistrationNumberTextBox.Text);
                    Values.phonenumber = Convert.ToInt32(PhoneNumberTextBox.Text);

                }
            }

            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
        }
    }
}