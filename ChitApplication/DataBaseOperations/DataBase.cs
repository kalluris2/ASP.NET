using PersonDetails.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseOperations
{
    public class DataBase
    {
        SqlConnection connection = null;
        public SqlConnection DataBaseConnection()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            return new SqlConnection(connectionstring);

        }

        public bool InsertRegistration(Details Values)
        {
            try
            {
                connection = DataBaseConnection();
                connection.Open();
                SqlCommand cmd = new SqlCommand("spInsertPeopleData", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@registrationno", SqlDbType.Int).Value = Values.registrationnumber;
                cmd.Parameters.Add("@firstname", SqlDbType.VarChar, 30).Value = Values.firstname;
                cmd.Parameters.Add("@secondname", SqlDbType.VarChar, 30).Value = Values.lastname;
                cmd.Parameters.Add("@phno", SqlDbType.VarChar, 10).Value = Values.phonenumber;
                cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = Values.address;
                cmd.Parameters.Add("@chitid", SqlDbType.VarChar, 10).Value = Values.chitid;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }



        }

    }
}
