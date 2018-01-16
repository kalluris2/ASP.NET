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
    public partial class UpdatePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submittButton_Click(object sender, EventArgs e)
        {
            PatientInformation Values = new PatientInformation();
            Values.RegistrationNumber = registrationTextBox.Text;
            Values.DischargedDate = dischargedDateTextBox.Text;
            Values.WardShiftedTo = movedToTextBox.Text;
            if (string.IsNullOrEmpty(Values.RegistrationNumber))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('enter registration number');</script>");
            }
            /*else if (string.IsNullOrEmpty(Values.DischargedDate))
            {
                Values.DischargedDate = "null";

            }
            else if (string.IsNullOrEmpty(Values.WardShiftedTo))
            {
                Values.WardShiftedTo = "null";
            }*/            
            else
            {
                DataModifications Update = new DataModifications();
                if (Update.UpdatePatientDetails(Values))
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Data Updated successfully');</script>");
                }
                else
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Data not Updated');</script>");
            }
        }

    

        protected void exitButton_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.close()</script>");
            //Page.ClientScript.RegisterOnSubmitStatement(typeof(Page), "closePage", "window.onunload = CloseWindow();");
        }
    }
}