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
    public partial class PaymentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PayButton_Click(object sender, EventArgs e)
        {
            
            Log.WriteDebugLog("pay  button is clicked");
            try
            {
                Details Values = new Details();
                Values.firstname = PaidByTextBox.Text;
                Values.paiddate = PaidDateTextBox.Text;
                if (!(Regex.IsMatch(RegistrationTextBox.Text, pattern: "^[ 0-9]")))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('registratio number contains only numbers');</script>");
                    Log.WriteDebugLog("registration number is not entered");
                }
                else if (!(Regex.IsMatch(PaymentIdTextBox.Text, pattern: "^[ 0-9]")))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Payment Id contains only numbers');</script>");
                    Log.WriteDebugLog("payment id not entered");
                }
                else if (!(Regex.IsMatch(Values.firstname, pattern: "^[ a-z]")))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter first name only in small's ');</script>");
                    Log.WriteDebugLog("first name not entered");
                }
                else if (string.IsNullOrEmpty(Values.paiddate))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter paid date ');</script>");
                    Log.WriteDebugLog("last name not entered");
                }
                else if (!(Regex.IsMatch(AmountPaidTextBox.Text, pattern: "^[ 0-9]")))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert(' amount paid should be in numbers  ');</script>");
                    Log.WriteDebugLog("amount not entered");
                }
                else
                {
                    Values.registrationnumber = Convert.ToInt32(RegistrationTextBox.Text);
                    Values.paymentid = Convert.ToInt32(PaymentIdTextBox.Text);
                    Values.emino = Convert.ToInt32(EmiNoTextBox.Text);
                    Values.amountpaid = Convert.ToInt32(AmountPaidTextBox.Text);
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
                    Log.WriteDebugLog("fields are entered correctly");
                    ServiceReference.ChitApplicationServiceSoapClient serviceObj = new ServiceReference.ChitApplicationServiceSoapClient();
                    ChitApplication.ServiceReference.Details obj = new ServiceReference.Details();
                    obj.registrationnumber = Values.registrationnumber;
                    obj.firstname = Values.firstname;
                    obj.paiddate = Values.paiddate;
                    obj.chitid = Values.chitid;
                    obj.paymentid = Values.paymentid;
                    obj.emino = Values.emino;
                    if (serviceObj.InsertPaymentDetails(obj))
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Data inserted successfully');</script>");
                        Log.WriteDebugLog("payment info  entered into database");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
        
    }
}