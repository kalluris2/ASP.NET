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
    public partial class DataInsertion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            PatientInformation Values = new PatientInformation();
           // insertDataGridView.DataSource=
            foreach (GridViewRow row in insertDataGridView.Rows)
            {
                Values.RegistrationNumber = ((Label)row.FindControl("lable1")).Text;
                Values.FirstName = ((Label)row.FindControl("lable2")).Text;
                Values.LastName = ((Label)row.FindControl("lable3")).Text;
                Values.AdmittedDate = ((Label)row.FindControl("lable4")).Text;
                Values.AdmittedWard = ((Label)row.FindControl("lable5")).Text;
                Values.Reason = ((Label)row.FindControl("lable6")).Text;
                Values.WardShiftedTo = ((Label)row.FindControl("lable7")).Text;
                Values.DischargedDate = ((Label)row.FindControl("lable8")).Text;
            }
            DataModifications InsertDataGridView = new DataModifications();
            if (InsertDataGridView.InsertPatientDetails(Values))
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Data entered successfully');</script>");
            else
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Data not saved');</script>");
        }
    }
}