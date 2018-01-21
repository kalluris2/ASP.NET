using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDetails.Model
{
    public class Details
    {
        private int RegistrationNumber;
        private string FirstName = "";
        private string LastName = "";
        private int PhoneNumber;
        private string Address = "";
        private string ChitId = "";
        private string PaidDate = "";
        private int AmountPaid;
        private int PaymentId;
        private int EMINo;
        private string Password = "";
        private int EmployeeId;

        public int registrationnumber { get => RegistrationNumber; set => RegistrationNumber = value; }
        public string firstname { get => FirstName; set => FirstName = value; }
        public string lastname { get => LastName; set => LastName = value; }
        public int phonenumber { get => PhoneNumber; set => PhoneNumber = value; }
        public string address { get => Address; set => Address = value; }
        public string chitid { get => ChitId; set => ChitId = value; }
        public string paiddate { get => PaidDate; set => PaidDate = value; }
        public int amountpaid { get => AmountPaid; set => AmountPaid = value; }
        public int paymentid { get => PaymentId; set => PaymentId = value; }
        public int emino { get => EMINo; set => EMINo = value; }
        public string password { get => Password; set => Password = value; }
        public int employeeid { get => EmployeeId; set => EmployeeId = value; }




    }
}
