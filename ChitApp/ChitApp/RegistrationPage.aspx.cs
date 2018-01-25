using DatabaseOperations;
using Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChitApp
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
                RegistrationModel Values = new RegistrationModel();
                Values.RegistrationNumber = Convert.ToInt32(RegistrationIdTextBox.Text);
                Values.FirstName = FirstNameTextBox.Text;
                Values.SecondName = LastNameTextBox.Text;
                Values.PhoneNumber = Convert.ToInt32(PhnoTextBox.Text);
                Values.ChitId = ChitIdTextBox.Text;
                Values.Address = AddressTextBox.Text;
                Database Data = new Database();
                if (Data.InsertRegistration(Values))
                {
                    Response.Write("data registered successfully");
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
    }
}