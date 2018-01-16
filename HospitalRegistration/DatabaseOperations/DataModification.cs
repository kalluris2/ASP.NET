using PatientDetail;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;


namespace DatabaseOperations
{
    public class DataModifications
    {
        SqlConnection connection = null;

        public SqlConnection DatabaseConnect()
        {
            string Name = @"Data Source=DESKTOP-BA6B0TS;Initial Catalog=Hospital;Integrated Security=true";
            return new SqlConnection(Name);
        }
        public bool InsertPatientDetails(PatientInformation Values)
        {
            try
            {
                connection = DatabaseConnect();
                connection.Open();
                SqlCommand cmd = new SqlCommand("spInsertPatientDetails", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@registrationno", SqlDbType.VarChar, 10).Value = Values.RegistrationNumber;
                cmd.Parameters.Add("@firstname", SqlDbType.VarChar, 30).Value = Values.FirstName;
                cmd.Parameters.Add("@lastname", SqlDbType.VarChar, 30).Value = Values.LastName;
                cmd.Parameters.Add("@admitteddate", SqlDbType.Date).Value = Values.AdmittedDate;
                cmd.Parameters.Add("@admittedward", SqlDbType.VarChar, 50).Value = Values.AdmittedWard;
                cmd.Parameters.Add("@reason", SqlDbType.VarChar, 30).Value = Values.Reason;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                // throw new Exception(ex.Message.ToString());
                // Response.Write("<script>alert('" + Server.HtmlEncode(ex.ToString()) + "')</script>");
                HttpContext.Current.Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public bool UpdatePatientDetails(PatientInformation Values)
        {
            try
            {
                connection = DatabaseConnect();
                connection.Open();
                SqlCommand cmd = new SqlCommand("spUpdatePatientDetails", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@registrationno", SqlDbType.VarChar, 10).Value = Values.RegistrationNumber;
                cmd.Parameters.Add("@dischargeddate", SqlDbType.VarChar, 15).Value = Values.DischargedDate;
                cmd.Parameters.Add("@wardshiftedto", SqlDbType.VarChar, 20).Value = Values.WardShiftedTo;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        /*public void DataBinding()
        {
            try
            {
                connection = DatabaseConnect();
                connection.Open();
                string command = "select * from PatientInformation";
                SqlCommand cmd = new SqlCommand(command, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                Data

            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
            finally
            {
                connection.Close();
            }
        }*/
    }
}
