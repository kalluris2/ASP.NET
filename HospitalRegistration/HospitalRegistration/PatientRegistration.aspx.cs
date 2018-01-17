using DatabaseOperations;
using PatientDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalRegistration
{
    public partial class PatientRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            registrationNumberTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            admittedDateTextBox.Text = string.Empty;
            admittedWardTextBox.Text = string.Empty;
            reasonTextBox.Text = string.Empty;
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            PatientInformation Values = new PatientInformation();
            Values.RegistrationNumber = registrationNumberTextBox.Text;
            Values.FirstName = firstNameTextBox.Text;
            Values.LastName = lastNameTextBox.Text;
            Values.AdmittedDate = admittedDateTextBox.Text;
            Values.AdmittedWard = admittedWardTextBox.Text;
            Values.Reason = reasonTextBox.Text;
            if (string.IsNullOrEmpty(Values.RegistrationNumber))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(),"Scripts","<script>alert('enter registration number');</script>");
            }
            else if (string.IsNullOrEmpty(Values.FirstName))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter first name');</script>");

            }
            else if (string.IsNullOrEmpty(Values.LastName))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter last name');</script>");

            }
            else if (string.IsNullOrEmpty(Values.AdmittedDate))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter admitted date');</script>");

            }
            else if (string.IsNullOrEmpty(Values.AdmittedWard))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter admitted ward');</script>");

            }
            else if (string.IsNullOrEmpty(Values.Reason))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter reason for comming to hospital');</script>");

            }
            else
            {
                DataModifications Insert = new DataModifications();
                
                if (Insert.InsertPatientDetails(Values)) 
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Data entered successfully');</script>");
                else
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Data not saved');</script>");



            }

        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdatePage.aspx");
        }

        protected void viewButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("BindingData.aspx");
        }

        protected void insertButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("DataInsertion.aspx");


        }
    }
}