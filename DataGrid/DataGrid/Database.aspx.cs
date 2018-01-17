using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataGrid
{
    public partial class Database : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Name = @"Data Source=DESKTOP-BA6B0TS;Initial Catalog=Hospital;Integrated Security=true";
            SqlConnection connection = new SqlConnection(Name);
            connection.Open();
            string command = "select * from PatientInformation";
            SqlCommand cmd = new SqlCommand(command, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            connection.Close();


        }
    }
}