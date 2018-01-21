using DataBaseOperations;
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
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            Log.WriteDebugLog("registration button is clicked");
            try
            {
                Details Values = new Details();

                Values.firstname = FirstNameTextBox.Text;
                Values.lastname = LastNameTextBox.Text;
                Values.address = AddressTextBox.Text;

                if (!(Regex.IsMatch(RegistrationNumberTextBox.Text, pattern: "^[ 0-9]")))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('registratio number contains only numbers');</script>");
                    Log.WriteDebugLog("registration number not entered");
                }
                
                else if (!(Regex.IsMatch(Values.firstname, pattern: "^[ a-z]")))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter first name only in small's ');</script>");
                    Log.WriteDebugLog("first name not entered");
                }
                
                else if (!(Regex.IsMatch(Values.lastname, pattern: "^[ a-z]")))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter last name only in small's ');</script>");
                    Log.WriteDebugLog("last name not entered");
                }
                
                else if (string.IsNullOrEmpty(Values.address))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter last name');</script>");
                    Log.WriteDebugLog("address not entered");
                }
                else if (string.IsNullOrEmpty(PhoneNumberTextBox.Text))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter phone number');</script>");
                    Log.WriteDebugLog("phone number not entered");
                }
                else if (ChitIdRadioButton.SelectedIndex < 0)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('select chit policy id');</script>");
                    Log.WriteDebugLog("chit id not selected");
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
                    Log.WriteDebugLog("values are entered");
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
                        Log.WriteDebugLog("data entered into database");
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
            Log.WriteDebugLog("payment button is clicked");
            Response.Redirect("PaymentForm.aspx");
            Log.WriteDebugLog("payment page is displayed");

        }

        protected void ViewButton_Click(object sender, EventArgs e)
        {
            Log.WriteDebugLog("view persons registered for particular chit button is clicked");
            Response.Redirect("ViewPerson.aspx");
            Log.WriteDebugLog("view person page is displayed");
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Log.WriteDebugLog("delete button is clicked to delete a record");
            Response.Redirect("DeleteForm.aspx");
            Log.WriteDebugLog("delete form is displayed");
        }
    }
}