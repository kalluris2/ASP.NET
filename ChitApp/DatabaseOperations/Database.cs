using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations
{
    public class Database
    {
        SqlConnection connection = null;

        public SqlConnection DatabaseConnect()
        {
            string Name = @"Data Source=DESKTOP-BA6B0TS;Initial Catalog=ChitFund;Integrated Security=true";
            return new SqlConnection(Name);
        }
        public void InsertRegistration(Person inputValues)
        {
            try
            {
                connection = DatabaseConnect();
                connection.Open();
                SqlCommand cmd = new SqlCommand("spInsertPeopleData", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@registrationno", SqlDbType.Int).Value = inputValues.RegistrationNumber;
                cmd.Parameters.Add("@firstname", SqlDbType.VarChar, 30).Value = inputValues.FirstName;
                cmd.Parameters.Add("@secondname", SqlDbType.VarChar, 30).Value = inputValues.SecondName;
                cmd.Parameters.Add("@phno", SqlDbType.VarChar, 10).Value = inputValues.PhoneNumber;
                cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = inputValues.Address;
                cmd.Parameters.Add("@chitid", SqlDbType.VarChar, 10).Value = inputValues.ChitId;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
   
        public bool EmployeeLogin(int id, string password)
        {
            try
            {
                connection = DatabaseConnect();
                connection.Open();
                string command = "select count(Password) from Employees where EmployeeId= '" + id + "' and Password= '" + password + "'";
                SqlDataAdapter data = new SqlDataAdapter(command, connection);
                DataTable table = new DataTable();
                data.Fill(table);
                if (table.Rows[0][0].ToString() == "1")
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            
        }

        public void InsertPayment(Person inputvalues)
        {
            try
            {
                connection = DatabaseConnect();
                connection.Open();
                SqlCommand cmd = new SqlCommand("spInsertChitDetails", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@paymentid", SqlDbType.VarChar, 30).Value = inputvalues.PaymentId;
                cmd.Parameters.Add("@registrationno", SqlDbType.Int).Value = inputvalues.RegistrationNumber;
                cmd.Parameters.Add("@datepaid", SqlDbType.Date).Value = inputvalues.DatePaidOn;
                cmd.Parameters.Add("@chitid", SqlDbType.VarChar, 30).Value = inputvalues.ChitId;
                cmd.Parameters.Add("@amtpaid", SqlDbType.Int).Value = inputvalues.AmountPaid;
                cmd.Parameters.Add("@receivedby", SqlDbType.VarChar, 30).Value = inputvalues.AmountReceivedBy;
                cmd.Parameters.Add("@paidby", SqlDbType.VarChar, 30).Value = inputvalues.FirstName;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
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
