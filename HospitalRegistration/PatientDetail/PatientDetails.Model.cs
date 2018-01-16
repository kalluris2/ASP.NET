using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDetail
{
    public class PatientInformation
    {
        public string RegistrationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AdmittedDate { get; set; }
        public string AdmittedWard { get; set; }
        public string Reason { get; set; }
        public string DischargedDate { get; set; }
        public string WardShiftedTo { get; set; }
    }
}
