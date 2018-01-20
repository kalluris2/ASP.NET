using DataBaseOperations;
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
                
                else if (!(Regex.IsMatch(Values.firstname, pattern: "^[ a-z]")))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter first name only in small's ');</script>");

                }
                
                else if (!(Regex.IsMatch(Values.lastname, pattern: "^[ a-z]")))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter last name only in small's ');</script>");

                }
                
                else if (string.IsNullOrEmpty(Values.address))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter last name');</script>");

                }
                else if (string.IsNullOrEmpty(PhoneNumberTextBox.Text))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter phone number');</script>");

                }
                else if (ChitIdRadioButton.SelectedIndex < 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('select chit policy id');</script>");

                }
                else
                {
                    Values.registrationnumber = Convert.ToInt32(RegistrationNumberTextBox.Text);
                    Values.phonenumber = Convert.ToInt32(PhoneNumberTextBox.Text);
                    if (ChitIdRadioButton.SelectedIndex == 0)
                    {
                        Values.chitid = "2lks";
                    }
                    else if (ChitIdRadioButton.SelectedIndex == 1)
                    {
                        Values.chitid = "1lk";
                    }
                    else if (ChitIdRadioButton.SelectedIndex == 2)
                    {
                        Values.chitid = "50k";
                    }
                    else
                    {
                        Values.chitid = "25k";
                    }
                 //   DataBase Insert = new DataBase();
                    ServiceReference.ChitApplicationServiceSoapClient serviceObj = new ServiceReference.ChitApplicationServiceSoapClient();
                    ChitApplication.ServiceReference.Details obj = new ServiceReference.Details();
                    obj.registrationnumber = Values.registrationnumber;
                    obj.firstname = Values.firstname;
                    obj.lastname = Values.lastname;
                    obj.phonenumber = Values.phonenumber;
                    obj.address = Values.address;
                    obj.chitid = Values.chitid;
                    if (serviceObj.InsertRegistration(obj))
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Data inserted successfully');</script>");

                    }

                }  
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            RegistrationNumberTextBox.Text = string.Empty;
            FirstNameTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
            PhoneNumberTextBox.Text = string.Empty;
            AddressTextBox.Text = string.Empty;
        }

        protected void PaymentButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaymentForm.aspx");

        }
    }
}