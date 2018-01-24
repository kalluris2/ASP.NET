using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentModel
{
    public class PaymentModel
    {
        public string DatePaidOn { get; set; }
        public string PaidBy { get; set; }
        public string PaymentId { get; set; }
        public int AmountPaid { get; set; }
        public int RegistrationNumber { get; set; }
        public int EmiNumber { get; set; }
    }
}
