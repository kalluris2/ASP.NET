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

        /*public DataTable DataBinding()
        {
            
            try
            {
                //string Name = @"Data Source=DESKTOP-BA6B0TS;Initial Catalog=Hospital;Integrated Security=true";
                //SqlConnection connection = new SqlConnection(Name);
                connection = DatabaseConnect();
                connection.Open();
                string command = "select * from PatientInformation";
                SqlCommand cmd = new SqlCommand(command, connection);
                DataSet Data = new DataSet();
                SqlDataAdapter Adapter = new SqlDataAdapter();
                Adapter.Fill(Data);
                var table = Data.Tables[0];
                return table;
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
        /*public List<PatientInformation> ViewData()
        {
            try
            {
                connection = DatabaseConnect();
                connection.Open();
                string query = "select * from PatientInformation";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dataReader = cmd.ExecuteReader();
                List<PatientInformation> _patientinformation = new List<PatientInformation>();
                while (dataReader.Read())
                {
                    PatientInformation patient = new PatientInformation();
                    patient.FirstName = dataReader[0].ToString();
                    patient.LastName = dataReader[1].ToString();
                    patient.RegistrationNumber = dataReader[2].ToString();
                    patient.AdmittedDate = dataReader[3].ToString();
                    patient.AdmittedWard = dataReader[4].ToString();
                    patient.Reason = dataReader[5].ToString();
                    patient.DischargedDate = dataReader[6].ToString();
                    patient.WardShiftedTo = dataReader[7].ToString();


                    _patientinformation.Add(patient);
                }
                return _patientinformation;
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
