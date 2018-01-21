using Logging;
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
            Log.WriteDebugLog("database connection is called");
            return new SqlConnection(connectionstring);

        }

        public bool InsertRegistration(Details Values)
        {
            Log.WriteDebugLog("Inser registration method is called");
            try
            {
                connection = DataBaseConnection();
                connection.Open();
                Log.WriteDebugLog("connection is opened");
                SqlCommand cmd = new SqlCommand("spInsertRegistration", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@registrationno", SqlDbType.Int).Value = Values.registrationnumber;
                cmd.Parameters.Add("@firstname", SqlDbType.VarChar, 30).Value = Values.firstname;
                cmd.Parameters.Add("@secondname", SqlDbType.VarChar, 30).Value = Values.lastname;
                cmd.Parameters.Add("@phno", SqlDbType.VarChar, 10).Value = Values.phonenumber;
                cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = Values.address;
                cmd.Parameters.Add("@chitid", SqlDbType.VarChar, 10).Value = Values.chitid;
                cmd.ExecuteNonQuery();
                Log.WriteDebugLog("store procedure to insert registration details is execuited");
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
                Log.WriteDebugLog("connection is opened");
            }
            //return false;

        }
        public bool InsertPaymentDetails(Details Values)
        {
            Log.WriteDebugLog("inser payment details method is called");
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
                Log.WriteDebugLog("store procedure for payment details is executed");
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool EmployeeLogin(Details Values)
        {
            Log.WriteDebugLog("employeed login method is called");
            try
            {
                    connection = DataBaseConnection();
                    connection.Open();
                    string command = "select count(EmployeePassword) from Employee where EmployeeId= '" + Values.employeeid + "' and EmployeePassword= '" + Values.password + "'";
                    SqlDataAdapter data = new SqlDataAdapter(command, connection);
                    DataTable table = new DataTable();
                    data.Fill(table);
                    if (table.Rows[0][0].ToString() == "1")
                        return true;
                    else
                        return false;

            }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
        }
        public DataTable ViewPerson(string value)
        {
            Log.WriteDebugLog("view person method is called");
            try
            {
                connection = DataBaseConnection();
                connection.Open();
                string command = "select * from RegistrationDetails where ChitId='" + value + "' ";
                //SqlCommand cmd = new SqlCommand(command, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command,connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool DeleteRecord(int id)
        {
            Log.WriteDebugLog("delete record method is called");
            try
            {
                connection = DataBaseConnection();
                connection.Open();
                string command = "delete from RegistrationDetails where RegistrationNumber='" + id + "'";
                SqlCommand cmd = new SqlCommand(command, connection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        

    }
}
