using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalRegistration
{
    public partial class BindingData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Name = @"Data Source=DESKTOP-BA6B0TS;Initial Catalog=Hospital;Integrated Security=true";
            SqlConnection connection = new SqlConnection(Name);
            connection.Open();
            string command = "select * from PatientInformation";
            SqlCommand cmd = new SqlCommand(command, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataGridView.DataSource = reader;
            DataGridView.DataBind();
            connection.Close();

        }
    }
}