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

        public int registrationnumber { get => RegistrationNumber; set => RegistrationNumber = value; }
        public string firstname { get => FirstName; set => FirstName = value; }
        public string lastname { get => LastName; set => LastName = value; }
        public int phonenumber { get => PhoneNumber; set => PhoneNumber = value; }
        public string address { get => Address; set => Address = value; }
        public string chitid { get => ChitId; set => ChitId = value; }



    }
}
