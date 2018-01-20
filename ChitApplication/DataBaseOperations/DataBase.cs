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
            string connectionstring = ConfigurationManager.ConnectionStrings["Dbconnection"].ToString();
            return new SqlConnection(connectionstring);

        }

        public bool InsertRegistration(Details Values)
        {
            try
            {
                connection = DataBaseConnection();
                connection.Open();
                SqlCommand cmd = new SqlCommand("spInsertRegistration", connection);
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
                throw ex;
               // Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
            finally
            {
                connection.Close();
            }
            //return false;

        }
        public bool InsertPaymentDetails(Details Values)
        {
            try
            {
                connection = DataBaseConnection();
                connection.Open();
                SqlCommand cmd = new SqlCommand("spInsertPaymentDetails", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@registrationumber", SqlDbType.Int).Value = Values.registrationnumber;
                cmd.Parameters.Add("@paidby", SqlDbType.VarChar, 30).Value = Values.firstname;
                cmd.Parameters.Add("@paiddate", SqlDbType.VarChar, 30).Value = Values.paiddate;
                cmd.Parameters.Add("@amountpaid", SqlDbType.Int).Value = Values.amountpaid;
                cmd.Parameters.Add("@paymentid", SqlDbType.Int).Value = Values.paymentid;
                cmd.Parameters.Add("@chitid", SqlDbType.VarChar, 10).Value = Values.chitid;
                cmd.Parameters.Add("@emino", SqlDbType.Int).Value = Values.emino;
                cmd.ExecuteNonQuery();
                return true;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
