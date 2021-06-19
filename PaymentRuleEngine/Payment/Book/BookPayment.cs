using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    class BookPayment : Payment
    {
        public override string GeneratePaymentSlip()
        {
            return "New Payment Slip Generated for Book";
        }

        public override string GenerateDuplicatePaymentSlip(int paymentID, int OldDeptID)
        {
            return "Duplicate book Payment Slip Generated for Royalty and PaymentID is : " + paymentID;
        }
    }
}
